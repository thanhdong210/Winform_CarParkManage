
namespace doan
{
    partial class XoaSuaXeHoiForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewXoaSuaXeHoi = new System.Windows.Forms.DataGridView();
            this.buttonUploadHieuXe = new System.Windows.Forms.Button();
            this.textBoxBangSoXe = new System.Windows.Forms.TextBox();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHieuXe = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHieuXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(242, 487);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 30);
            this.buttonRefresh.TabIndex = 58;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(190, 401);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 37);
            this.buttonRemove.TabIndex = 57;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(46, 401);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 37);
            this.buttonEdit.TabIndex = 56;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewXoaSuaXeHoi
            // 
            this.dataGridViewXoaSuaXeHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSuaXeHoi.Location = new System.Drawing.Point(352, 25);
            this.dataGridViewXoaSuaXeHoi.Name = "dataGridViewXoaSuaXeHoi";
            this.dataGridViewXoaSuaXeHoi.RowHeadersWidth = 51;
            this.dataGridViewXoaSuaXeHoi.RowTemplate.Height = 24;
            this.dataGridViewXoaSuaXeHoi.Size = new System.Drawing.Size(740, 492);
            this.dataGridViewXoaSuaXeHoi.TabIndex = 55;
            this.dataGridViewXoaSuaXeHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaXeHoi_CellClick);
            // 
            // buttonUploadHieuXe
            // 
            this.buttonUploadHieuXe.Location = new System.Drawing.Point(232, 274);
            this.buttonUploadHieuXe.Name = "buttonUploadHieuXe";
            this.buttonUploadHieuXe.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadHieuXe.TabIndex = 54;
            this.buttonUploadHieuXe.Text = "Upload";
            this.buttonUploadHieuXe.UseVisualStyleBackColor = true;
            this.buttonUploadHieuXe.Click += new System.EventHandler(this.buttonUploadHieuXe_Click);
            // 
            // textBoxBangSoXe
            // 
            this.textBoxBangSoXe.Location = new System.Drawing.Point(130, 328);
            this.textBoxBangSoXe.Name = "textBoxBangSoXe";
            this.textBoxBangSoXe.Size = new System.Drawing.Size(177, 22);
            this.textBoxBangSoXe.TabIndex = 48;
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(129, 80);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 49;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(130, 34);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(19, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bảng số xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(42, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Hiệu xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Chủ sỡ hữu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Xe ID";
            // 
            // pictureBoxHieuXe
            // 
            this.pictureBoxHieuXe.BackColor = System.Drawing.Color.White;
            this.pictureBoxHieuXe.Location = new System.Drawing.Point(130, 133);
            this.pictureBoxHieuXe.Name = "pictureBoxHieuXe";
            this.pictureBoxHieuXe.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxHieuXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHieuXe.TabIndex = 53;
            this.pictureBoxHieuXe.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxBangSoXe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxChuSoHuu);
            this.panel1.Controls.Add(this.pictureBoxHieuXe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonUploadHieuXe);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 456);
            this.panel1.TabIndex = 59;
            // 
            // XoaSuaXeHoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1102, 543);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewXoaSuaXeHoi);
            this.Controls.Add(this.panel1);
            this.Name = "XoaSuaXeHoiForm";
            this.Text = "XoaSuaXeHoiForm";
            this.Load += new System.EventHandler(this.XoaSuaXeHoiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHieuXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewXoaSuaXeHoi;
        public System.Windows.Forms.Button buttonUploadHieuXe;
        public System.Windows.Forms.PictureBox pictureBoxHieuXe;
        public System.Windows.Forms.TextBox textBoxBangSoXe;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}