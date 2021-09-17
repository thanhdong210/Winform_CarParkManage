
namespace doan
{
    partial class GuiXeForm
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
            this.dataGridViewGuiXe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.radioButtonTuan = new System.Windows.Forms.RadioButton();
            this.radioButtonGio = new System.Windows.Forms.RadioButton();
            this.dateTimePickerHanGui = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayGui = new System.Windows.Forms.DateTimePicker();
            this.buttonGui = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuiXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGuiXe
            // 
            this.dataGridViewGuiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuiXe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGuiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuiXe.Location = new System.Drawing.Point(347, 41);
            this.dataGridViewGuiXe.Name = "dataGridViewGuiXe";
            this.dataGridViewGuiXe.RowHeadersWidth = 51;
            this.dataGridViewGuiXe.RowTemplate.Height = 24;
            this.dataGridViewGuiXe.Size = new System.Drawing.Size(522, 399);
            this.dataGridViewGuiXe.TabIndex = 0;
            this.dataGridViewGuiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuiXe_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.radioButtonNgay);
            this.panel1.Controls.Add(this.radioButtonThang);
            this.panel1.Controls.Add(this.radioButtonTuan);
            this.panel1.Controls.Add(this.radioButtonGio);
            this.panel1.Controls.Add(this.dateTimePickerHanGui);
            this.panel1.Controls.Add(this.dateTimePickerNgayGui);
            this.panel1.Controls.Add(this.buttonGui);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.textBoxChuSoHuu);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 402);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Location = new System.Drawing.Point(170, 151);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(62, 21);
            this.radioButtonNgay.TabIndex = 4;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Location = new System.Drawing.Point(170, 178);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(70, 21);
            this.radioButtonThang.TabIndex = 4;
            this.radioButtonThang.TabStop = true;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTuan
            // 
            this.radioButtonTuan.AutoSize = true;
            this.radioButtonTuan.Location = new System.Drawing.Point(101, 178);
            this.radioButtonTuan.Name = "radioButtonTuan";
            this.radioButtonTuan.Size = new System.Drawing.Size(62, 21);
            this.radioButtonTuan.TabIndex = 4;
            this.radioButtonTuan.TabStop = true;
            this.radioButtonTuan.Text = "Tuần";
            this.radioButtonTuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonGio
            // 
            this.radioButtonGio.AutoSize = true;
            this.radioButtonGio.Location = new System.Drawing.Point(102, 151);
            this.radioButtonGio.Name = "radioButtonGio";
            this.radioButtonGio.Size = new System.Drawing.Size(51, 21);
            this.radioButtonGio.TabIndex = 4;
            this.radioButtonGio.TabStop = true;
            this.radioButtonGio.Text = "Giờ";
            this.radioButtonGio.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerHanGui
            // 
            this.dateTimePickerHanGui.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerHanGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHanGui.Location = new System.Drawing.Point(101, 286);
            this.dateTimePickerHanGui.Name = "dateTimePickerHanGui";
            this.dateTimePickerHanGui.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerHanGui.TabIndex = 3;
            // 
            // dateTimePickerNgayGui
            // 
            this.dateTimePickerNgayGui.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayGui.Location = new System.Drawing.Point(101, 225);
            this.dateTimePickerNgayGui.Name = "dateTimePickerNgayGui";
            this.dateTimePickerNgayGui.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerNgayGui.TabIndex = 3;
            // 
            // buttonGui
            // 
            this.buttonGui.Location = new System.Drawing.Point(157, 342);
            this.buttonGui.Name = "buttonGui";
            this.buttonGui.Size = new System.Drawing.Size(75, 31);
            this.buttonGui.TabIndex = 2;
            this.buttonGui.Text = "Gửi";
            this.buttonGui.UseVisualStyleBackColor = true;
            this.buttonGui.Click += new System.EventHandler(this.buttonGui_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(41, 342);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(101, 99);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(167, 22);
            this.textBoxChuSoHuu.TabIndex = 1;
            this.textBoxChuSoHuu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(101, 52);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(68, 22);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hạn gửi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gửi theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày  gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủ sở hữu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gửi xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xe được nhận gửi";
            // 
            // GuiXeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(881, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewGuiXe);
            this.Controls.Add(this.label6);
            this.Name = "GuiXeForm";
            this.Text = "GuiXeForm";
            this.Load += new System.EventHandler(this.GuiXeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuiXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGuiXe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.Button buttonGui;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.DateTimePicker dateTimePickerHanGui;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayGui;
        public System.Windows.Forms.RadioButton radioButtonNgay;
        public System.Windows.Forms.RadioButton radioButtonThang;
        public System.Windows.Forms.RadioButton radioButtonTuan;
        public System.Windows.Forms.RadioButton radioButtonGio;
        private System.Windows.Forms.Label label7;
    }
}