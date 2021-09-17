
namespace doan
{
    partial class ThemXeDapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUploadHinhXe = new System.Windows.Forms.Button();
            this.buttonUploadNguoiGui = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonThêm = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.pictureBoxHinhXe = new System.Windows.Forms.PictureBox();
            this.pictureBoxNguoiGui = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xe ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ sỡ hữu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Người gửi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(164, 84);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 22);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thông tin xe đạp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonUploadHinhXe
            // 
            this.buttonUploadHinhXe.Location = new System.Drawing.Point(488, 225);
            this.buttonUploadHinhXe.Name = "buttonUploadHinhXe";
            this.buttonUploadHinhXe.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadHinhXe.TabIndex = 5;
            this.buttonUploadHinhXe.Text = "Upload";
            this.buttonUploadHinhXe.UseVisualStyleBackColor = true;
            this.buttonUploadHinhXe.Click += new System.EventHandler(this.buttonUploadHinhXe_Click);
            // 
            // buttonUploadNguoiGui
            // 
            this.buttonUploadNguoiGui.Location = new System.Drawing.Point(748, 225);
            this.buttonUploadNguoiGui.Name = "buttonUploadNguoiGui";
            this.buttonUploadNguoiGui.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadNguoiGui.TabIndex = 5;
            this.buttonUploadNguoiGui.Text = "Upload";
            this.buttonUploadNguoiGui.UseVisualStyleBackColor = true;
            this.buttonUploadNguoiGui.Click += new System.EventHandler(this.buttonUploadNguoiGui_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(58, 203);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(106, 33);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonThêm
            // 
            this.buttonThêm.Location = new System.Drawing.Point(235, 203);
            this.buttonThêm.Name = "buttonThêm";
            this.buttonThêm.Size = new System.Drawing.Size(106, 33);
            this.buttonThêm.TabIndex = 5;
            this.buttonThêm.Text = "Thêm";
            this.buttonThêm.UseVisualStyleBackColor = true;
            this.buttonThêm.Click += new System.EventHandler(this.buttonThêm_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(164, 145);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(177, 22);
            this.textBoxChuSoHuu.TabIndex = 2;
            this.textBoxChuSoHuu.TextChanged += new System.EventHandler(this.textBoxChuSoHuu_TextChanged);
            // 
            // pictureBoxHinhXe
            // 
            this.pictureBoxHinhXe.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinhXe.Location = new System.Drawing.Point(386, 84);
            this.pictureBoxHinhXe.Name = "pictureBoxHinhXe";
            this.pictureBoxHinhXe.Size = new System.Drawing.Size(177, 135);
            this.pictureBoxHinhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhXe.TabIndex = 6;
            this.pictureBoxHinhXe.TabStop = false;
            this.pictureBoxHinhXe.Click += new System.EventHandler(this.pictureBoxHinhXe_Click);
            // 
            // pictureBoxNguoiGui
            // 
            this.pictureBoxNguoiGui.BackColor = System.Drawing.Color.White;
            this.pictureBoxNguoiGui.Location = new System.Drawing.Point(647, 84);
            this.pictureBoxNguoiGui.Name = "pictureBoxNguoiGui";
            this.pictureBoxNguoiGui.Size = new System.Drawing.Size(176, 135);
            this.pictureBoxNguoiGui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNguoiGui.TabIndex = 4;
            this.pictureBoxNguoiGui.TabStop = false;
            this.pictureBoxNguoiGui.Click += new System.EventHandler(this.pictureBoxNguoiGui_Click);
            // 
            // ThemXeDapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(892, 281);
            this.Controls.Add(this.pictureBoxHinhXe);
            this.Controls.Add(this.buttonThêm);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonUploadNguoiGui);
            this.Controls.Add(this.buttonUploadHinhXe);
            this.Controls.Add(this.pictureBoxNguoiGui);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ThemXeDapForm";
            this.Text = "ThemXeDapForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNguoiGui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBoxNguoiGui;
        public System.Windows.Forms.Button buttonUploadHinhXe;
        public System.Windows.Forms.Button buttonUploadNguoiGui;
        public System.Windows.Forms.Button buttonThoat;
        public System.Windows.Forms.Button buttonThêm;
        public System.Windows.Forms.PictureBox pictureBoxHinhXe;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
    }
}