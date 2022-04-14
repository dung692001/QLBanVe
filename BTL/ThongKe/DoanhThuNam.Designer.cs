
namespace BTL.ThongKe
{
    partial class DoanhThuNam
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChartDoanhThuNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThuNam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartDoanhThuNam);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 647);
            this.panel1.TabIndex = 2;
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(576, 12);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(115, 33);
            this.cboNam.TabIndex = 0;
            this.cboNam.SelectionChangeCommitted += new System.EventHandler(this.cboNam_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboNam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 63);
            this.panel2.TabIndex = 1;
            // 
            // ChartDoanhThuNam
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDoanhThuNam.ChartAreas.Add(chartArea1);
            this.ChartDoanhThuNam.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartDoanhThuNam.Legends.Add(legend1);
            this.ChartDoanhThuNam.Location = new System.Drawing.Point(0, 63);
            this.ChartDoanhThuNam.Name = "ChartDoanhThuNam";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.ChartDoanhThuNam.Series.Add(series1);
            this.ChartDoanhThuNam.Size = new System.Drawing.Size(1111, 584);
            this.ChartDoanhThuNam.TabIndex = 2;
            this.ChartDoanhThuNam.Text = "chart1";
            // 
            // DoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThuNam";
            this.Text = "DoanhThuNam";
            this.Load += new System.EventHandler(this.DoanhThuNam_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThuNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDoanhThuNam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboNam;
    }
}