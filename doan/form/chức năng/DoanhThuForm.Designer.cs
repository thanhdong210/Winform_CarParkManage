
namespace doan
{
    partial class DoanhThuForm
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
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.buttonLuuFile = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.panel1.Controls.Add(this.dateTimePickerNgayBatDau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 92);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(283, 35);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerNgayKetThuc.TabIndex = 4;
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(62, 35);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(148, 22);
            this.dateTimePickerNgayBatDau.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tới";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(486, 32);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(100, 33);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.RowHeadersWidth = 51;
            this.dataGridViewDoanhThu.RowTemplate.Height = 24;
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(800, 283);
            this.dataGridViewDoanhThu.TabIndex = 1;
            // 
            // buttonLuuFile
            // 
            this.buttonLuuFile.Location = new System.Drawing.Point(12, 399);
            this.buttonLuuFile.Name = "buttonLuuFile";
            this.buttonLuuFile.Size = new System.Drawing.Size(100, 33);
            this.buttonLuuFile.TabIndex = 2;
            this.buttonLuuFile.Text = "Lưu File";
            this.buttonLuuFile.UseVisualStyleBackColor = true;
            this.buttonLuuFile.Click += new System.EventHandler(this.buttonLuuFile_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(144, 399);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 33);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "In";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // DoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(824, 444);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonLuuFile);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThuForm";
            this.Text = "DoanhThuForm";
            this.Load += new System.EventHandler(this.DoanhThuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        public System.Windows.Forms.Button buttonLuuFile;
        public System.Windows.Forms.Button buttonPrint;
    }
}