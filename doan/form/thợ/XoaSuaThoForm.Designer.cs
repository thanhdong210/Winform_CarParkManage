
namespace doan
{
    partial class XoaSuaThoForm
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
            this.dataGridViewXoaSuaTho = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxTenTho = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaTho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewXoaSuaTho
            // 
            this.dataGridViewXoaSuaTho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXoaSuaTho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXoaSuaTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSuaTho.Location = new System.Drawing.Point(330, 24);
            this.dataGridViewXoaSuaTho.Name = "dataGridViewXoaSuaTho";
            this.dataGridViewXoaSuaTho.RowHeadersWidth = 51;
            this.dataGridViewXoaSuaTho.RowTemplate.Height = 24;
            this.dataGridViewXoaSuaTho.Size = new System.Drawing.Size(604, 366);
            this.dataGridViewXoaSuaTho.TabIndex = 0;
            this.dataGridViewXoaSuaTho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaTho_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(584, 396);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(88, 33);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(166, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 33);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(38, 309);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 33);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin thợ";
            // 
            // dateTimePickerNgaysinh
            // 
            this.dateTimePickerNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaysinh.Location = new System.Drawing.Point(138, 231);
            this.dateTimePickerNgaysinh.Name = "dateTimePickerNgaysinh";
            this.dateTimePickerNgaysinh.Size = new System.Drawing.Size(156, 22);
            this.dateTimePickerNgaysinh.TabIndex = 9;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonNam.Location = new System.Drawing.Point(208, 185);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(58, 21);
            this.radioButtonNam.TabIndex = 7;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = false;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonNu.Location = new System.Drawing.Point(138, 185);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNu.TabIndex = 8;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nu";
            this.radioButtonNu.UseVisualStyleBackColor = false;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(138, 284);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(156, 22);
            this.textBoxSDT.TabIndex = 4;
            // 
            // textBoxTenTho
            // 
            this.textBoxTenTho.Location = new System.Drawing.Point(138, 137);
            this.textBoxTenTho.Name = "textBoxTenTho";
            this.textBoxTenTho.Size = new System.Drawing.Size(156, 22);
            this.textBoxTenTho.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(138, 86);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(78, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(27, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(47, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(58, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(61, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên thợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(67, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã thợ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 366);
            this.panel1.TabIndex = 15;
            // 
            // XoaSuaThoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(946, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerNgaysinh);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxTenTho);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewXoaSuaTho);
            this.Controls.Add(this.panel1);
            this.Name = "XoaSuaThoForm";
            this.Text = "XoaSuaThoForm";
            this.Load += new System.EventHandler(this.XoaSuaThoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaTho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXoaSuaTho;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgaysinh;
        public System.Windows.Forms.RadioButton radioButtonNam;
        public System.Windows.Forms.RadioButton radioButtonNu;
        public System.Windows.Forms.TextBox textBoxSDT;
        public System.Windows.Forms.TextBox textBoxTenTho;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonEdit;
    }
}