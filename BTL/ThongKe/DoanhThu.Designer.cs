
namespace BTL.ThongKe
{
    partial class DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtDoanhThu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 70);
            this.panel2.TabIndex = 4;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(938, 8);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(175, 57);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "        &In Excel";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(185, 16);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(165, 35);
            this.txtThang.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(26, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(153, 57);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "&Tìm tháng :";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(632, 11);
            this.txtDoanhThu.Multiline = true;
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(216, 47);
            this.txtDoanhThu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(412, 22);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh thu tháng :";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 62;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1125, 690);
            this.dgvDoanhThu.TabIndex = 5;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDoanhThu);
            this.Name = "DoanhThu";
            this.Text = "Doanh Thu Theo Tháng";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}