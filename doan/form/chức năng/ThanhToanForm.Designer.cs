
namespace doan
{
    partial class ThanhToanForm
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
            this.dataGridViewThanhToan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.textBoxTienPhaiTra = new System.Windows.Forms.TextBox();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhToan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewThanhToan
            // 
            this.dataGridViewThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThanhToan.Location = new System.Drawing.Point(365, 5);
            this.dataGridViewThanhToan.Name = "dataGridViewThanhToan";
            this.dataGridViewThanhToan.RowHeadersWidth = 51;
            this.dataGridViewThanhToan.RowTemplate.Height = 24;
            this.dataGridViewThanhToan.Size = new System.Drawing.Size(567, 430);
            this.dataGridViewThanhToan.TabIndex = 0;
            this.dataGridViewThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThanhToan_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dateTimePickerNgayTra);
            this.panel1.Controls.Add(this.textBoxTienPhaiTra);
            this.panel1.Controls.Add(this.textBoxChuSoHuu);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.buttonThanhToan);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 385);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(130, 282);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(182, 22);
            this.dateTimePickerNgayTra.TabIndex = 3;
            // 
            // textBoxTienPhaiTra
            // 
            this.textBoxTienPhaiTra.Location = new System.Drawing.Point(130, 216);
            this.textBoxTienPhaiTra.Name = "textBoxTienPhaiTra";
            this.textBoxTienPhaiTra.Size = new System.Drawing.Size(182, 22);
            this.textBoxTienPhaiTra.TabIndex = 2;
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(130, 154);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(182, 22);
            this.textBoxChuSoHuu.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(130, 87);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(79, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(165, 336);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(147, 29);
            this.buttonThanhToan.TabIndex = 1;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(34, 336);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(96, 29);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền phải trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủ sở hữu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(263, 403);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 29);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(944, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewThanhToan);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "ThanhToanForm";
            this.Text = "DongPhatForm";
            this.Load += new System.EventHandler(this.DongPhatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhToan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxTienPhaiTra;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button buttonRefresh;
    }
}