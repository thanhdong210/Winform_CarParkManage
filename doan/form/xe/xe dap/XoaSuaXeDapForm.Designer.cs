
namespace doan
{
    partial class XoaSuaXeDapForm
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
            this.buttonUploadNguoiGui = new System.Windows.Forms.Button();
            this.buttonUploadHinhXe = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewXoaSuaXeDap = new System.Windows.Forms.DataGridView();
            this.pictureBoxHinhXe = new System.Windows.Forms.PictureBox();
            this.pictureBoxNguoiGui = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeDap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUploadNguoiGui
            // 
            this.buttonUploadNguoiGui.Location = new System.Drawing.Point(259, 458);
            this.buttonUploadNguoiGui.Name = "buttonUploadNguoiGui";
            this.buttonUploadNguoiGui.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadNguoiGui.TabIndex = 20;
            this.buttonUploadNguoiGui.Text = "Upload";
            this.buttonUploadNguoiGui.UseVisualStyleBackColor = true;
            this.buttonUploadNguoiGui.Click += new System.EventHandler(this.buttonUploadNguoiGui_Click);
            // 
            // buttonUploadHinhXe
            // 
            this.buttonUploadHinhXe.Location = new System.Drawing.Point(259, 283);
            this.buttonUploadHinhXe.Name = "buttonUploadHinhXe";
            this.buttonUploadHinhXe.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadHinhXe.TabIndex = 21;
            this.buttonUploadHinhXe.Text = "Upload";
            this.buttonUploadHinhXe.UseVisualStyleBackColor = true;
            this.buttonUploadHinhXe.Click += new System.EventHandler(this.buttonUploadHinhXe_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(156, 98);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 13;
            this.textBoxChuSoHuu.TextChanged += new System.EventHandler(this.textBoxChuSoHuu_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(156, 46);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(46, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Người gửi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(78, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chủ sỡ hữu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Xe ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewXoaSuaXeDap
            // 
            this.dataGridViewXoaSuaXeDap.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXoaSuaXeDap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSuaXeDap.Location = new System.Drawing.Point(367, 46);
            this.dataGridViewXoaSuaXeDap.Name = "dataGridViewXoaSuaXeDap";
            this.dataGridViewXoaSuaXeDap.RowHeadersWidth = 51;
            this.dataGridViewXoaSuaXeDap.RowTemplate.Height = 24;
            this.dataGridViewXoaSuaXeDap.Size = new System.Drawing.Size(945, 517);
            this.dataGridViewXoaSuaXeDap.TabIndex = 23;
            this.dataGridViewXoaSuaXeDap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaXeDap_CellClick);
            this.dataGridViewXoaSuaXeDap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaXeDap_CellContentClick);
            // 
            // pictureBoxHinhXe
            // 
            this.pictureBoxHinhXe.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinhXe.Location = new System.Drawing.Point(156, 142);
            this.pictureBoxHinhXe.Name = "pictureBoxHinhXe";
            this.pictureBoxHinhXe.Size = new System.Drawing.Size(177, 135);
            this.pictureBoxHinhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhXe.TabIndex = 22;
            this.pictureBoxHinhXe.TabStop = false;
            this.pictureBoxHinhXe.Click += new System.EventHandler(this.pictureBoxHinhXe_Click);
            // 
            // pictureBoxNguoiGui
            // 
            this.pictureBoxNguoiGui.BackColor = System.Drawing.Color.White;
            this.pictureBoxNguoiGui.Location = new System.Drawing.Point(158, 317);
            this.pictureBoxNguoiGui.Name = "pictureBoxNguoiGui";
            this.pictureBoxNguoiGui.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxNguoiGui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNguoiGui.TabIndex = 17;
            this.pictureBoxNguoiGui.TabStop = false;
            this.pictureBoxNguoiGui.Click += new System.EventHandler(this.pictureBoxNguoiGui_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(37, 490);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 37);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(197, 490);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 37);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "Xóa";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(367, 566);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 30);
            this.buttonRefresh.TabIndex = 25;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 560);
            this.panel1.TabIndex = 26;
            // 
            // XoaSuaXeDapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1324, 621);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewXoaSuaXeDap);
            this.Controls.Add(this.pictureBoxHinhXe);
            this.Controls.Add(this.buttonUploadNguoiGui);
            this.Controls.Add(this.buttonUploadHinhXe);
            this.Controls.Add(this.pictureBoxNguoiGui);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "XoaSuaXeDapForm";
            this.Text = "XoaSuaXeDapForm";
            this.Load += new System.EventHandler(this.XoaSuaXeDapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaXeDap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxHinhXe;
        public System.Windows.Forms.Button buttonUploadNguoiGui;
        public System.Windows.Forms.Button buttonUploadHinhXe;
        public System.Windows.Forms.PictureBox pictureBoxNguoiGui;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewXoaSuaXeDap;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
    }
}