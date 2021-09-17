
namespace doan
{
    partial class XemCTHD
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
            this.textBoxLoaiHopDong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.dataGridViewXemCTHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLoaiHopDong
            // 
            this.textBoxLoaiHopDong.Location = new System.Drawing.Point(313, 71);
            this.textBoxLoaiHopDong.Name = "textBoxLoaiHopDong";
            this.textBoxLoaiHopDong.ReadOnly = true;
            this.textBoxLoaiHopDong.Size = new System.Drawing.Size(63, 22);
            this.textBoxLoaiHopDong.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Loại hợp đồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã hợp đồng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chi tiết hợp đồng";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(313, 36);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.ReadOnly = true;
            this.textBoxMaHD.Size = new System.Drawing.Size(63, 22);
            this.textBoxMaHD.TabIndex = 32;
            // 
            // dataGridViewXemCTHD
            // 
            this.dataGridViewXemCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXemCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXemCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemCTHD.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewXemCTHD.Name = "dataGridViewXemCTHD";
            this.dataGridViewXemCTHD.RowHeadersWidth = 51;
            this.dataGridViewXemCTHD.RowTemplate.Height = 24;
            this.dataGridViewXemCTHD.Size = new System.Drawing.Size(1022, 138);
            this.dataGridViewXemCTHD.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxMaHD);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxLoaiHopDong);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(247, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 106);
            this.panel1.TabIndex = 34;
            // 
            // XemCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1046, 288);
            this.Controls.Add(this.dataGridViewXemCTHD);
            this.Controls.Add(this.panel1);
            this.Name = "XemCTHD";
            this.Text = "XemCTHD";
            this.Load += new System.EventHandler(this.XemCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxLoaiHopDong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewXemCTHD;
        public System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Panel panel1;
    }
}