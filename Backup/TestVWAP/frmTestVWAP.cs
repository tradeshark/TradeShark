using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


	/// <summary>
	/// Summary description for TestVWAP.
	/// </summary>
	/// 

	public class frmTestVWAP : System.Windows.Forms.Form
	{

		private string filename = "";
		private AxSTOCKCHARTXLib.AxStockChartX axStockChartX1;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Button btnZoomIn;
		private System.Windows.Forms.Button btnZoomOut;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Button btnVWAP;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPath;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTestVWAP()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTestVWAP));
			this.axStockChartX1 = new AxSTOCKCHARTXLib.AxStockChartX();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnZoomIn = new System.Windows.Forms.Button();
			this.btnZoomOut = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.btnVWAP = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.axStockChartX1)).BeginInit();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// axStockChartX1
			// 
			this.axStockChartX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axStockChartX1.Enabled = true;
			this.axStockChartX1.Location = new System.Drawing.Point(0, 80);
			this.axStockChartX1.Name = "axStockChartX1";
			this.axStockChartX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axStockChartX1.OcxState")));
			this.axStockChartX1.Size = new System.Drawing.Size(688, 406);
			this.axStockChartX1.TabIndex = 0;
			// 
			// pnlTop
			// 
			this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTop.Controls.Add(this.btnZoomIn);
			this.pnlTop.Controls.Add(this.btnZoomOut);
			this.pnlTop.Controls.Add(this.btnRight);
			this.pnlTop.Controls.Add(this.btnLeft);
			this.pnlTop.Controls.Add(this.label1);
			this.pnlTop.Controls.Add(this.txtLength);
			this.pnlTop.Controls.Add(this.btnVWAP);
			this.pnlTop.Controls.Add(this.btnBrowse);
			this.pnlTop.Controls.Add(this.txtPath);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.ForeColor = System.Drawing.Color.Gainsboro;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(688, 80);
			this.pnlTop.TabIndex = 11;
			// 
			// btnZoomIn
			// 
			this.btnZoomIn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnZoomIn.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnZoomIn.Location = new System.Drawing.Point(112, 40);
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.Size = new System.Drawing.Size(32, 23);
			this.btnZoomIn.TabIndex = 19;
			this.btnZoomIn.Text = "+";
			this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
			// 
			// btnZoomOut
			// 
			this.btnZoomOut.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZoomOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnZoomOut.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnZoomOut.Location = new System.Drawing.Point(80, 40);
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.Size = new System.Drawing.Size(32, 23);
			this.btnZoomOut.TabIndex = 18;
			this.btnZoomOut.Text = "-";
			this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
			// 
			// btnRight
			// 
			this.btnRight.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRight.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnRight.Location = new System.Drawing.Point(40, 40);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(32, 23);
			this.btnRight.TabIndex = 17;
			this.btnRight.Text = ">";
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click_1);
			// 
			// btnLeft
			// 
			this.btnLeft.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLeft.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnLeft.Location = new System.Drawing.Point(8, 40);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(32, 23);
			this.btnLeft.TabIndex = 16;
			this.btnLeft.Text = "<";
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(416, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Length";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLength
			// 
			this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLength.ForeColor = System.Drawing.Color.DarkBlue;
			this.txtLength.Location = new System.Drawing.Point(464, 8);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(56, 20);
			this.txtLength.TabIndex = 13;
			this.txtLength.Text = "";
			// 
			// btnVWAP
			// 
			this.btnVWAP.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnVWAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVWAP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnVWAP.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnVWAP.Location = new System.Drawing.Point(528, 8);
			this.btnVWAP.Name = "btnVWAP";
			this.btnVWAP.TabIndex = 14;
			this.btnVWAP.Text = "VWAP";
			this.btnVWAP.Click += new System.EventHandler(this.btnVWAP_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnBrowse.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnBrowse.Location = new System.Drawing.Point(328, 8);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.TabIndex = 12;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtPath
			// 
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPath.ForeColor = System.Drawing.Color.DarkBlue;
			this.txtPath.Location = new System.Drawing.Point(8, 8);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(312, 20);
			this.txtPath.TabIndex = 11;
			this.txtPath.Text = "";
			// 
			// frmTestVWAP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(688, 486);
			this.Controls.Add(this.axStockChartX1);
			this.Controls.Add(this.pnlTop);
			this.Name = "frmTestVWAP";
			this.Text = "TestVWAP";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.axStockChartX1)).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmTestVWAP());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// open filename
			// run vwap and show chart
			axStockChartX1.RightDrawingSpacePixels=40;
			axStockChartX1.ScalePrecision = 4;
			axStockChartX1.RealTimeXLabels=true;
			int closePanel = this.axStockChartX1.AddChartPanel();
			this.axStockChartX1.AddSeries("EUR.Close",STOCKCHARTXLib.SeriesType.stLineChart,closePanel);
			axStockChartX1.set_SeriesColor("EUR.Close",System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Blue));
			this.axStockChartX1.AddSeries("EUR.VWAP",STOCKCHARTXLib.SeriesType.stLineChart,closePanel);
			axStockChartX1.set_SeriesColor("EUR.VWAP",System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Orange));
			int volPanel = this.axStockChartX1.AddChartPanel();
			this.axStockChartX1.AddSeries("EUR.Volume",STOCKCHARTXLib.SeriesType.stVolumeChart,volPanel);
			axStockChartX1.set_SeriesColor("EUR.Volume",System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Red));

		
		}

		private void btnBrowse_Click(object sender, System.EventArgs e)
		{
			
			System.Windows.Forms.OpenFileDialog oDialog = new OpenFileDialog();
			if (oDialog.ShowDialog() == DialogResult.OK)
			{
				filename = oDialog.FileName;
				this.txtPath.Text = filename;
			}
		}

		private void btnVWAP_Click(object sender, System.EventArgs e)
		{
			if (this.txtPath.Text == "")
			{
				MessageBox.Show("Path not specified.");
				return;
			}

			Fabrefactum.TimeSeries tSeries = new Fabrefactum.TimeSeries();

			using (CSVReader csv = new CSVReader(@txtPath.Text)) 
			{
				string[] fields;
				while ((fields = csv.GetCSVLine()) != null) 
				{
					object[] fieldArray = new object[fields.Length];
					
					fieldArray[0] = DateTime.Parse(fields[0] + " " + fields[1]);
					for (int i = 2; i < fields.Length; i++)
					{
						fieldArray[i-1] = Convert.ToDouble(fields[i]);
					}

					if (fieldArray.Length > 1)
					{
						tSeries.Add(DateTime.Parse(fieldArray[0].ToString()),fieldArray);
					}
				}
			}

			// Calculate VWAP
			int length  = 10;
			if (this.txtLength.Text != "")
			{
				length = Convert.ToInt32(txtLength.Text);
			}

			Fabrefactum.VWAP.Calculate(tSeries,length,4,6,5);
			axStockChartX1.ClearValues("EUR.Close");
			axStockChartX1.ClearValues("EUR.VWAP");
			axStockChartX1.ClearValues("EUR.Volume");

			// Add our points
			for (int i = 0; i < tSeries.Count; i++)
			{
				object[] series = (object[])tSeries[i];
				if ((double)series[6] != double.NaN)
				{
					DateTime date = tSeries.GetDateTime(i);
					double jDate = axStockChartX1.ToJulianDate(date.Year,date.Month,date.Day,date.Hour,date.Minute,date.Second);
					axStockChartX1.AppendValue("EUR.Close",jDate,(double)series[4]);
					axStockChartX1.AppendValue("EUR.VWAP",jDate,(double)series[6]);
					axStockChartX1.AppendValue("EUR.Volume",jDate,(double)series[5]);
				}
			}

			axStockChartX1.CtlUpdate();
		
		}

		private void btnLeft_Click_1(object sender, System.EventArgs e)
		{
			axStockChartX1.ScrollLeft(100);
		}

		private void btnRight_Click_1(object sender, System.EventArgs e)
		{
			axStockChartX1.ScrollRight(100);
		}

		private void btnZoomOut_Click(object sender, System.EventArgs e)
		{
			axStockChartX1.ZoomOut(100);
		}

		private void btnZoomIn_Click(object sender, System.EventArgs e)
		{
			axStockChartX1.ZoomIn(100);
			axStockChartX1.ScrollRight(100);
		}
	}

