
namespace doan
{
    partial class QuanLyXeMayForm
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
            this.dataGridViewQuanLyXeMay = new System.Windows.Forms.DataGridView();
            this.buttonDownloadNguoiGui = new System.Windows.Forms.Button();
            this.buttonUploadNguoiGui = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNguoiGui = new System.Windows.Forms.PictureBox();
            this.textBoxBangSoXe = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelTongXe);
            this.panel1.Location = new System.Drawing.Point(875, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 55);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.buttonSearch.Location = new System.Drawing.Point(932, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 35);
            this.buttonSearch.TabIndex = 70;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(626, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(266, 22);
            this.textBoxSearch.TabIndex = 69;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Tìm kiếm theo chủ sở hữu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(362, 457);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 30);
            this.buttonRefresh.TabIndex = 67;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(184, 402);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(97, 37);
            this.buttonReset.TabIndex = 66;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(52, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 37);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(52, 402);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(103, 37);
            this.buttonRemove.TabIndex = 64;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(178, 340);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(103, 37);
            this.buttonEdit.TabIndex = 63;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewQuanLyXeMay
            // 
            this.dataGridViewQuanLyXeMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyXeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyXeMay.Location = new System.Drawing.Point(362, 61);
            this.dataGridViewQuanLyXeMay.Name = "dataGridViewQuanLyXeMay";
            this.dataGridViewQuanLyXeMay.RowHeadersWidth = 51;
            this.dataGridViewQuanLyXeMay.RowTemplate.Height = 24;
            this.dataGridViewQuanLyXeMay.Size = new System.Drawing.Size(737, 390);
            this.dataGridViewQuanLyXeMay.TabIndex = 62;
            this.dataGridViewQuanLyXeMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyXeMay_CellClick);
            // 
            // buttonDownloadNguoiGui
            // 
            this.buttonDownloadNguoiGui.Location = new System.Drawing.Point(233, 272);
            this.buttonDownloadNguoiGui.Name = "buttonDownloadNguoiGui";
            this.buttonDownloadNguoiGui.Size = new System.Drawing.Size(89, 23);
            this.buttonDownloadNguoiGui.TabIndex = 57;
            this.buttonDownloadNguoiGui.Text = "Download";
            this.buttonDownloadNguoiGui.UseVisualStyleBackColor = true;
            this.buttonDownloadNguoiGui.Click += new System.EventHandler(this.buttonDownloadNguoiGui_Click);
            // 
            // buttonUploadNguoiGui
            // 
            this.buttonUploadNguoiGui.Location = new System.Drawing.Point(146, 272);
            this.buttonUploadNguoiGui.Name = "buttonUploadNguoiGui";
            this.buttonUploadNguoiGui.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadNguoiGui.TabIndex = 58;
            this.buttonUploadNguoiGui.Text = "Upload";
            this.buttonUploadNguoiGui.UseVisualStyleBackColor = true;
            this.buttonUploadNguoiGui.Click += new System.EventHandler(this.buttonUploadNguoiGui_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(145, 91);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 52;
            this.textBoxChuSoHuu.TextChanged += new System.EventHandler(this.textBoxChuSoHuu_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(145, 42);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 53;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Người gửi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(30, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Bảng số xe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Chủ sỡ hữu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Xe ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxNguoiGui
            // 
            this.pictureBoxNguoiGui.BackColor = System.Drawing.Color.White;
            this.pictureBoxNguoiGui.Location = new System.Drawing.Point(146, 131);
            this.pictureBoxNguoiGui.Name = "pictureBoxNguoiGui";
            this.pictureBoxNguoiGui.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxNguoiGui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNguoiGui.TabIndex = 56;
            this.pictureBoxNguoiGui.TabStop = false;
            this.pictureBoxNguoiGui.Click += new System.EventHandler(this.pictureBoxNguoiGui_Click);
            // 
            // textBoxBangSoXe
            // 
            this.textBoxBangSoXe.Location = new System.Drawing.Point(145, 312);
            this.textBoxBangSoXe.Name = "textBoxBangSoXe";
            this.textBoxBangSoXe.Size = new System.Drawing.Size(176, 22);
            this.textBoxBangSoXe.TabIndex = 53;
            this.textBoxBangSoXe.TextChanged += new System.EventHandler(this.textBoxBangSoXe_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Location = new System.Drawing.Point(12, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 487);
            this.panel2.TabIndex = 72;
            // 
            // QuanLyXeMayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewQuanLyXeMay);
            this.Controls.Add(this.buttonDownloadNguoiGui);
            this.Controls.Add(this.buttonUploadNguoiGui);
            this.Controls.Add(this.pictureBoxNguoiGui);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.textBoxBangSoXe);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyXeMayForm";
            this.Text = "QuanLyXeMayForm";
            this.Load += new System.EventHandler(this.QuanLyXeMayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridViewQuanLyXeMay;
        public System.Windows.Forms.Button buttonDownloadNguoiGui;
        public System.Windows.Forms.Button buttonUploadNguoiGui;
        public System.Windows.Forms.PictureBox pictureBoxNguoiGui;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxBangSoXe;
        private System.Windows.Forms.Panel panel2;
    }
}