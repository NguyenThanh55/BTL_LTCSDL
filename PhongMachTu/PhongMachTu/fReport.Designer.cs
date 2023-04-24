namespace PhongMachTu
{
    partial class fReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.chartThuoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PhongMachTu.rThongKeThuoc.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(984, 456);
            this.reportViewer.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // chartThuoc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThuoc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThuoc.Legends.Add(legend2);
            this.chartThuoc.Location = new System.Drawing.Point(12, 71);
            this.chartThuoc.Name = "chartThuoc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "ChartThuoc";
            this.chartThuoc.Series.Add(series2);
            this.chartThuoc.Size = new System.Drawing.Size(358, 333);
            this.chartThuoc.TabIndex = 1;
            this.chartThuoc.Text = "Biểu đồ";
            title2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "Biểu đồ thuốc theo nhóm thuốc";
            title2.Text = "Biểu đồ thuốc theo nhóm thuốc";
            this.chartThuoc.Titles.Add(title2);
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 456);
            this.Controls.Add(this.chartThuoc);
            this.Controls.Add(this.reportViewer);
            this.Name = "fReport";
            this.Text = "fReport";
            this.Load += new System.EventHandler(this.fReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuoc;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
    }
}