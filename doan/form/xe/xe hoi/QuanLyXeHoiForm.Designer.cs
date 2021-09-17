
namespace doan
{
    partial class QuanLyXeHoiForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTongXe = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewQuanLyXeHoi = new System.Windows.Forms.DataGridView();
            this.buttonDownloadHieuXe = new System.Windows.Forms.Button();
            this.buttonUploadHieuXe = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxBangSoXe = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHieuXe = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyXeHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHieuXe)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelTongXe);
            this.panel1.Location = new System.Drawing.Point(871, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 55);
            this.panel1.TabIndex = 94;
            // 
            // labelTongXe
            // 
            this.labelTongXe.AutoSize = true;
            this.labelTongXe.Location = new System.Drawing.Point(41, 18);
            this.labelTongXe.Name = "labelTongXe";
            this.labelTongXe.Size = new System.Drawing.Size(63, 17);
            this.labelTongXe.TabIndex = 0;
            this.labelTongXe.Text = "Tổng xe:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Teal;
            this.buttonSearch.Location = new System.Drawing.Point(928, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 35);
            this.buttonSearch.TabIndex = 93;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(622, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(266, 22);
            this.textBoxSearch.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 91;
            this.label9.Text = "Tìm kiếm theo chủ sở hữu";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(358, 456);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 30);
            this.buttonRefresh.TabIndex = 90;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(191, 421);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 37);
            this.buttonReset.TabIndex = 89;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(31, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 37);
            this.buttonAdd.TabIndex = 88;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(31, 421);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 37);
            this.buttonRemove.TabIndex = 87;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(190, 357);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 37);
            this.buttonEdit.TabIndex = 86;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewQuanLyXeHoi
            // 
            this.dataGridViewQuanLyXeHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyXeHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyXeHoi.Location = new System.Drawing.Point(358, 60);
            this.dataGridViewQuanLyXeHoi.Name = "dataGridViewQuanLyXeHoi";
            this.dataGridViewQuanLyXeHoi.RowHeadersWidth = 51;
            this.dataGridViewQuanLyXeHoi.RowTemplate.Height = 24;
            this.dataGridViewQuanLyXeHoi.Size = new System.Drawing.Size(737, 390);
            this.dataGridViewQuanLyXeHoi.TabIndex = 85;
            this.dataGridViewQuanLyXeHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyXeHoi_CellClick);
            // 
            // buttonDownloadHieuXe
            // 
            this.buttonDownloadHieuXe.Location = new System.Drawing.Point(227, 263);
            this.buttonDownloadHieuXe.Name = "buttonDownloadHieuXe";
            this.buttonDownloadHieuXe.Size = new System.Drawing.Size(89, 23);
            this.buttonDownloadHieuXe.TabIndex = 83;
            this.buttonDownloadHieuXe.Text = "Download";
            this.buttonDownloadHieuXe.UseVisualStyleBackColor = true;
            this.buttonDownloadHieuXe.Click += new System.EventHandler(this.buttonDownloadHieuXe_Click);
            // 
            // buttonUploadHieuXe
            // 
            this.buttonUploadHieuXe.Location = new System.Drawing.Point(141, 263);
            this.buttonUploadHieuXe.Name = "buttonUploadHieuXe";
            this.buttonUploadHieuXe.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadHieuXe.TabIndex = 84;
            this.buttonUploadHieuXe.Text = "Upload";
            this.buttonUploadHieuXe.UseVisualStyleBackColor = true;
            this.buttonUploadHieuXe.Click += new System.EventHandler(this.buttonUploadHieuXe_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(140, 81);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 77;
            // 
            // textBoxBangSoXe
            // 
            this.textBoxBangSoXe.Location = new System.Drawing.Point(125, 307);
            this.textBoxBangSoXe.Name = "textBoxBangSoXe";
            this.textBoxBangSoXe.Size = new System.Drawing.Size(176, 22);
            this.textBoxBangSoXe.TabIndex = 79;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(141, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(44, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Hiệu xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(8, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Bảng số xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Chủ sỡ hữu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Xe ID";
            // 
            // pictureBoxHieuXe
            // 
            this.pictureBoxHieuXe.BackColor = System.Drawing.Color.White;
            this.pictureBoxHieuXe.Location = new System.Drawing.Point(140, 122);
            this.pictureBoxHieuXe.Name = "pictureBoxHieuXe";
            this.pictureBoxHieuXe.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxHieuXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHieuXe.TabIndex = 82;
            this.pictureBoxHieuXe.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.textBoxBangSoXe);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Location = new System.Drawing.Point(16, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 492);
            this.panel2.TabIndex = 95;
            // 
            // QuanLyXeHoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewQuanLyXeHoi);
            this.Controls.Add(this.buttonDownloadHieuXe);
            this.Controls.Add(this.buttonUploadHieuXe);
            this.Controls.Add(this.pictureBoxHieuXe);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyXeHoiForm";
            this.Text = "QuanLyXeHoiForm";
            this.Load += new System.EventHandler(this.QuanLyXeHoiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyXeHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHieuXe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTongXe;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyXeHoi;
        public System.Windows.Forms.Button buttonDownloadHieuXe;
        public System.Windows.Forms.Button buttonUploadHieuXe;
        public System.Windows.Forms.PictureBox pictureBoxHieuXe;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxBangSoXe;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}