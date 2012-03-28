using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FinancialEngineering.Common.Utils;
using System.Data.SqlClient;
using System.Web.DataSets.Entities;
using System.IO;

namespace FinancialEngineering.Data.SyncDatabase
{
    class Program
    {
        private static DataTable GetSchemaTable()
        {
            string query = "SELECT * FROM QT_DailyQuote where 1=0";


            DataTable tblSchema;

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("QT_DailyQuote");
                    adpt.Fill(dt);
                    tblSchema = dt.Clone();
                    cnn.Close();
                }
            }
            return tblSchema;

        }
        static string constr = @"Data Source=(local);Initial Catalog=JYDB;Integrated Security=True";
        static int SyncTable<T>(string tableName) where T : DataTable
        {
            int r = 0;
            EnhancedUriBuilder uriBuilder = new EnhancedUriBuilder("http://218.6.198.202:8081/SData/" + tableName);

            T dataTable = HttpUtil.PerformHttpGetBinaryObject<T>(uriBuilder.Uri.AbsoluteUri, true);
            SqlConnection sqlConnection = new SqlConnection(constr);


            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(constr);
            sqlBulkCopy.DestinationTableName = tableName;
            sqlBulkCopy.BatchSize = dataTable.Rows.Count;

            sqlConnection.Open();
            var command = new SqlCommand("truncate table " + tableName, sqlConnection);
            command.ExecuteNonQuery();
            if (dataTable != null && dataTable.Rows.Count != 0)
            {
                r = dataTable.Rows.Count;
                sqlBulkCopy.WriteToServer(dataTable);
            }
            sqlBulkCopy.Close();
            sqlConnection.Close();
            return r;
        }
        static int SyncQT_TradingDayNew()
        {
            int r = 0;
            EnhancedUriBuilder uriBuilder = new EnhancedUriBuilder("http://218.6.198.202:8081/SData/QT_TradingDayNew");

            var dataTable = HttpUtil.PerformHttpGetBinaryObject<System.Web.DataSets.JYDBDataSet.QT_TradingDayNewDataTable>(uriBuilder.Uri.AbsoluteUri, true);
            SqlConnection sqlConnection = new SqlConnection(constr);


            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(constr);
            sqlBulkCopy.DestinationTableName = "QT_TradingDayNew";
            sqlBulkCopy.BatchSize = dataTable.Rows.Count;

            sqlConnection.Open();
            var command = new SqlCommand("truncate table QT_TradingDayNew", sqlConnection);
            command.ExecuteNonQuery();
            if (dataTable != null && dataTable.Rows.Count != 0)
            {
                r = dataTable.Rows.Count;
                sqlBulkCopy.WriteToServer(dataTable);
            }
            sqlBulkCopy.Close();
            sqlConnection.Close();
            return r;
        }

        static int SyncQT_DaiyQuote(DateTime dateStart, DateTime dateEnd)
        {
            int r = 0;
            EnhancedUriBuilder uriBuilder = new EnhancedUriBuilder("http://218.6.198.202:8081/SData/DailyQuote");
            uriBuilder.QueryItems.Add("startDate", dateStart.ToString("yyyyMMdd"));
            uriBuilder.QueryItems.Add("endDate", dateEnd.ToString("yyyyMMdd"));
            QT_DailyQuote[] result = HttpUtil.PerformHttpGetBinaryObject<QT_DailyQuote[]>(uriBuilder.Uri.AbsoluteUri, true);
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();
            var command = new SqlCommand("SELECT count(*) FROM QT_DailyQuote WHERE tradingDay ='" + dateEnd.ToString("yyyyMMdd") + "'", sqlConnection);
            
            var total = (int)command.ExecuteScalar();

            if (total > 0) return -1;

            DataTable dataTable = GetSchemaTable();
            string passportKey;
            for (int j = 0; j < result.Count(); j++)
            {
                passportKey = Guid.NewGuid().ToString();
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = result[j].ID;
                dataRow[1] = result[j].InnerCode;
                dataRow[2] = result[j].TradingDay;
                if (result[j].PrevClosePrice.HasValue)
                {
                    dataRow[3] = result[j].PrevClosePrice;
                }
                else
                {
                    dataRow[3] = DBNull.Value;
                }
                if (result[j].OpenPrice.HasValue)
                {
                    dataRow[4] = result[j].OpenPrice;
                }
                else
                {
                    dataRow[4] = DBNull.Value;
                }
                if (result[j].HighPrice.HasValue)
                {
                    dataRow[5] = result[j].HighPrice;
                }
                else
                {
                    dataRow[5] = DBNull.Value;
                }
                if (result[j].LowPrice.HasValue)
                {
                    dataRow[6] = result[j].LowPrice;
                }
                else
                {
                    dataRow[6] = DBNull.Value;
                }
                if (result[j].ClosePrice.HasValue)
                {
                    dataRow[7] = result[j].ClosePrice;
                }
                else
                {
                    dataRow[7] = DBNull.Value;
                }
                if (result[j].TurnoverVolume.HasValue)
                {
                    dataRow[8] = result[j].TurnoverVolume;
                }
                else
                {
                    dataRow[8] = DBNull.Value;
                }
                if (result[j].TurnoverValue.HasValue)
                {
                    dataRow[9] = result[j].TurnoverValue;
                }
                else
                {
                    dataRow[9] = DBNull.Value;

                }
                if (result[j].TurnoverDeals.HasValue)
                {

                    dataRow[10] = result[j].TurnoverDeals.Value;
                }
                else
                {
                    dataRow[10] = DBNull.Value;
                }
                dataRow[11] = result[j].XGRQ;
                dataRow[12] = result[j].JSID;
                dataTable.Rows.Add(dataRow);
            }

            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(constr);
            sqlBulkCopy.DestinationTableName = "QT_DailyQuote";
            sqlBulkCopy.BatchSize = dataTable.Rows.Count;

         
            if (dataTable != null && dataTable.Rows.Count != 0)
            {
                r = dataTable.Rows.Count;
                sqlBulkCopy.WriteToServer(dataTable);
            }
            sqlBulkCopy.Close();
            sqlConnection.Close();
            return r;
        }

        static private bool CheckIfHasSync()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();
            var command = new SqlCommand("select count(*) FROM SyncHistory WHERE SyncResult = 1 and SyncDate = '" + DateTime.Now.ToString("yyyyMMdd") + "'", sqlConnection);
            int total = (int)command.ExecuteScalar();
            return total > 0;
        }
        static private void WriteSyncResult()
        {

        }
        static void Main(string[] args)
        {
            var s = File.AppendText(@"C:\Users\Administrator\Desktop\Sync.txt");
            var dateNow = DateTime.Now;
            var date = ":::" + dateNow.ToShortDateString() + ":::   ";
            try
            {
                var a = SyncTable<System.Web.DataSets.JYDBDataSet.QT_TradingDayNewDataTable>("QT_TradingDayNew");
                s.WriteLine(date + "同步 QT_TradingDayNew:  " + a.ToString());
                Console.WriteLine(date + "同步 QT_TradingDayNew:  " + a.ToString());
                var b = SyncTable<System.Web.DataSets.JYDBDataSet.SecuMainDataTable>("SecuMain");
                s.WriteLine(date + "同步 SecuMain:  " + b.ToString());
                Console.WriteLine(date + "同步 SecuMain:  " + b.ToString());
                var c = SyncTable<System.Web.DataSets.JYDBDataSet.QT_AdjustingFactorDataTable>("QT_AdjustingFactor");
                s.WriteLine(date + "同步 QT_AdjustingFactor:  " + c.ToString());
                Console.WriteLine(date + "同步 QT_AdjustingFactor:  " + c.ToString());
                var e = SyncQT_DaiyQuote(dateNow, dateNow);
                s.WriteLine(date + "同步 QT_DaiyQuote:  " + e.ToString());
                Console.WriteLine(date + "同步 QT_DaiyQuote:  " + e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("同步完成");
                s.Flush();
                s.Dispose();
            }
        }
    }
}
