
namespace doan
{
    partial class XoaSuaXeMayForm
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
            this.dataGridViewXoaSuaXeMay = new System.Windows.Forms.DataGridView();
            this.buttonUploadNguoiGui = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBangSoXe = new System.Windows.Forms.TextBox();
            this.pictureBoxNguoiGui = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(252, 461);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 30);
            this.buttonRefresh.TabIndex = 42;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(181, 378);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 37);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(47, 378);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 37);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewXoaSuaXeMay
            // 
            this.dataGridViewXoaSuaXeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSuaXeMay.Location = new System.Drawing.Point(366, 12);
            this.dataGridViewXoaSuaXeMay.Name = "dataGridViewXoaSuaXeMay";
            this.dataGridViewXoaSuaXeMay.RowHeadersWidth = 51;
            this.dataGridViewXoaSuaXeMay.RowTemplate.Height = 24;
            this.dataGridViewXoaSuaXeMay.Size = new System.Drawing.Size(733, 479);
            this.dataGridViewXoaSuaXeMay.TabIndex = 39;
            this.dataGridViewXoaSuaXeMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaXeMay_CellClick);
            this.dataGridViewXoaSuaXeMay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaXeMay_CellContentClick);
            // 
            // buttonUploadNguoiGui
            // 
            this.buttonUploadNguoiGui.Location = new System.Drawing.Point(242, 285);
            this.buttonUploadNguoiGui.Name = "buttonUploadNguoiGui";
            this.buttonUploadNguoiGui.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadNguoiGui.TabIndex = 36;
            this.buttonUploadNguoiGui.Text = "Upload";
            this.buttonUploadNguoiGui.UseVisualStyleBackColor = true;
            this.buttonUploadNguoiGui.Click += new System.EventHandler(this.buttonUploadNguoiGui_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(140, 84);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 31;
            this.textBoxChuSoHuu.TextChanged += new System.EventHandler(this.textBoxChuSoHuu_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(140, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 32;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(41, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Người gửi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Chủ sỡ hữu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Xe ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(41, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Bảng số xe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxBangSoXe
            // 
            this.textBoxBangSoXe.Location = new System.Drawing.Point(139, 332);
            this.textBoxBangSoXe.Name = "textBoxBangSoXe";
            this.textBoxBangSoXe.Size = new System.Drawing.Size(177, 22);
            this.textBoxBangSoXe.TabIndex = 31;
            this.textBoxBangSoXe.TextChanged += new System.EventHandler(this.textBoxBangSoXe_TextChanged);
            // 
            // pictureBoxNguoiGui
            // 
            this.pictureBoxNguoiGui.BackColor = System.Drawing.Color.White;
            this.pictureBoxNguoiGui.Location = new System.Drawing.Point(140, 144);
            this.pictureBoxNguoiGui.Name = "pictureBoxNguoiGui";
            this.pictureBoxNguoiGui.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxNguoiGui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNguoiGui.TabIndex = 35;
            this.pictureBoxNguoiGui.TabStop = false;
            this.pictureBoxNguoiGui.Click += new System.EventHandler(this.pictureBoxNguoiGui_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 436);
            this.panel1.TabIndex = 43;
            // 
            // XoaSuaXeMayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1102, 504);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewXoaSuaXeMay);
            this.Controls.Add(this.buttonUploadNguoiGui);
            this.Controls.Add(this.pictureBoxNguoiGui);
            this.Controls.Add(this.textBoxBangSoXe);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "XoaSuaXeMayForm";
            this.Text = "XoaSuaXeMayForm";
            this.Load += new System.EventHandler(this.XoaSuaXeMayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewXoaSuaXeMay;
        public System.Windows.Forms.Button buttonUploadNguoiGui;
        public System.Windows.Forms.PictureBox pictureBoxNguoiGui;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxBangSoXe;
        private System.Windows.Forms.Panel panel1;
    }
}