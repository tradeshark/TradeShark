using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.DataSets;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Caching;
using System.Web.DataSets.Entities;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.Entity;
using System.Collections;
using System.ComponentModel;
using System.Web.DataSets.JYDBDataSetTableAdapters;
using System.Web.DataSets.Model;
using System.Data;


namespace RiskEvaluation.Controllers
{
    public class SDataController : Controller
    {
        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
            base.OnResultExecuting(filterContext);
            
        }
        private void SerializeTable(DataTable dataTable)
        {
            dataTable.RemotingFormat = System.Data.SerializationFormat.Binary;

            if (dataTable.Rows.Count > 0)
            {
                new BinaryFormatter().Serialize(this.Response.OutputStream, dataTable);

            }
        }
        public ActionResult SecuMain()
        {
            var adapter = new SecuMainTableAdapter();
            this.SerializeTable(adapter.GetData());
            return null;
        }
        public ActionResult QT_AdjustingFactor()
        {
            var adapter = new QT_AdjustingFactorTableAdapter();
            this.SerializeTable(adapter.GetData());
            return null;
        }
        public ActionResult QT_TradingDayNew()
        {
            var adapter = new QT_TradingDayNewTableAdapter();
            this.SerializeTable(adapter.GetData());
            return null;
        }
        public ActionResult DailyQuote(string startDate ,string endDate)
        {
            var start = DateTime.ParseExact(startDate,"yyyyMMdd",null);
            var end = DateTime.ParseExact(endDate,"yyyyMMdd",null);
            using (var context = new JYDBContext(
               @"Data Source=10.254.8.204,1435;Initial Catalog=JYDB;Persist Security Info=True
                ;User ID=sa;Password=hxdb666
                    ;Pooling=False"))
            {
               
                var result = context.QT_DailyQuote.Where(d => d.TradingDay >= start && d.TradingDay <= end);
                if(result != null)
                {
                   new BinaryFormatter().Serialize(this.Response.OutputStream, result.ToArray());
                   return null;
                   XmlSerializer serializer = new XmlSerializer(typeof(QT_DailyQuote[]));
                   StringWriter writer = new StringWriter();
                   serializer.Serialize(writer, result.ToArray());
                   var s = writer.ToString();
                   return this.Content(s, "text/xml");
                }
               
                return null;
                
            }
        }
        public ActionResult Data(string stock,int? total,string date)
        {
            stock = string.IsNullOrEmpty(stock) ? null : stock;
            total = total ?? 60;
            date = date?? DateTime.Now.AddDays(-1).ToShortDateString();
            string s = null;
            var cache = MemoryCache.Default;
            var key = "SData" + (total == null ? "" : "_" + total.ToString()) + (date == null ? "" : "_" + date) + (stock == null ? "" : "_" + stock.ToString());
            var cacheObj = cache[key];
            if (cacheObj != null)
            {
                s = (string)cacheObj;
                return this.Content(s, "text/xml");
            }
            else
            {
                var data = new DBStockQuoteData().GetStockPrice(stock, total.Value, DateTime.ParseExact(date,"yyyyMMdd",null));
                XmlSerializer serializer = new XmlSerializer(typeof(StockPrice[]));
                StringWriter writer = new StringWriter();
                serializer.Serialize(writer, data);
                s = writer.ToString();
                cache.Set(key, s, DateTimeOffset.UtcNow.AddHours(23));
                return this.Content(s, "text/xml");
            }
        }
        //public ActionResult Return(string startDate, string endDate, string secuCodeList)
        //{
        //    if (string.IsNullOrEmpty(secuCodeList)) throw new ArgumentException();
        //    var data = new DBStockQuoteData().CalcReturn(secuCodeList.Split(',').ToList(), DateTime.ParseExact(startDate, "yyyyMMdd", null),
        //        DateTime.ParseExact(endDate, "yyyyMMdd", null));
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<StockReturn>));
        //    StringWriter writer = new StringWriter();
        //    serializer.Serialize(writer, data);
        //    var s = writer.ToString();
        //    return this.Content(s, "text/xml");
        //}
    }
}
