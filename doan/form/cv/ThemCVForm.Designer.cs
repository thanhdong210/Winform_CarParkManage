
namespace doan
{
    partial class ThemCVForm
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.textBoxMaTho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLoaiCongViec = new System.Windows.Forms.ComboBox();
            this.dataGridViewTho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewThongTinXe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonXeDap = new System.Windows.Forms.Button();
            this.buttonXeMay = new System.Windows.Forms.Button();
            this.buttonXeHoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID xe";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(133, 55);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(74, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(176, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 29);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Thoat";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(36, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin công việc";
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(133, 103);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(166, 22);
            this.textBoxChuSoHuu.TabIndex = 1;
            // 
            // textBoxMaTho
            // 
            this.textBoxMaTho.Location = new System.Drawing.Point(133, 209);
            this.textBoxMaTho.Name = "textBoxMaTho";
            this.textBoxMaTho.Size = new System.Drawing.Size(74, 22);
            this.textBoxMaTho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chủ sở hữu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại công việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã thợ";
            // 
            // comboBoxLoaiCongViec
            // 
            this.comboBoxLoaiCongViec.FormattingEnabled = true;
            this.comboBoxLoaiCongViec.Items.AddRange(new object[] {
            "Sua xe",
            "Rua xe",
            "Trong coi xe"});
            this.comboBoxLoaiCongViec.Location = new System.Drawing.Point(133, 153);
            this.comboBoxLoaiCongViec.Name = "comboBoxLoaiCongViec";
            this.comboBoxLoaiCongViec.Size = new System.Drawing.Size(166, 24);
            this.comboBoxLoaiCongViec.TabIndex = 3;
            // 
            // dataGridViewTho
            // 
            this.dataGridViewTho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTho.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewTho.Name = "dataGridViewTho";
            this.dataGridViewTho.RowHeadersWidth = 51;
            this.dataGridViewTho.RowTemplate.Height = 24;
            this.dataGridViewTho.Size = new System.Drawing.Size(511, 310);
            this.dataGridViewTho.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxChuSoHuu);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxLoaiCongViec);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMaTho);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(547, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 348);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewThongTinXe
            // 
            this.dataGridViewThongTinXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongTinXe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewThongTinXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinXe.Location = new System.Drawing.Point(896, 61);
            this.dataGridViewThongTinXe.Name = "dataGridViewThongTinXe";
            this.dataGridViewThongTinXe.RowHeadersWidth = 51;
            this.dataGridViewThongTinXe.RowTemplate.Height = 24;
            this.dataGridViewThongTinXe.Size = new System.Drawing.Size(460, 310);
            this.dataGridViewThongTinXe.TabIndex = 4;
            this.dataGridViewThongTinXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTinXe_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thông tin thợ";
            // 
            // buttonXeDap
            // 
            this.buttonXeDap.Location = new System.Drawing.Point(897, 24);
            this.buttonXeDap.Name = "buttonXeDap";
            this.buttonXeDap.Size = new System.Drawing.Size(116, 32);
            this.buttonXeDap.TabIndex = 6;
            this.buttonXeDap.Text = "Xe đạp";
            this.buttonXeDap.UseVisualStyleBackColor = true;
            this.buttonXeDap.Click += new System.EventHandler(this.buttonXeDap_Click);
            // 
            // buttonXeMay
            // 
            this.buttonXeMay.Location = new System.Drawing.Point(1074, 24);
            this.buttonXeMay.Name = "buttonXeMay";
            this.buttonXeMay.Size = new System.Drawing.Size(116, 32);
            this.buttonXeMay.TabIndex = 6;
            this.buttonXeMay.Text = "Xe máy";
            this.buttonXeMay.UseVisualStyleBackColor = true;
            this.buttonXeMay.Click += new System.EventHandler(this.buttonXeMay_Click);
            // 
            // buttonXeHoi
            // 
            this.buttonXeHoi.Location = new System.Drawing.Point(1240, 23);
            this.buttonXeHoi.Name = "buttonXeHoi";
            this.buttonXeHoi.Size = new System.Drawing.Size(116, 33);
            this.buttonXeHoi.TabIndex = 6;
            this.buttonXeHoi.Text = "Xe Hơi";
            this.buttonXeHoi.UseVisualStyleBackColor = true;
            this.buttonXeHoi.Click += new System.EventHandler(this.buttonXeHoi_Click);
            // 
            // ThemCVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1372, 392);
            this.Controls.Add(this.buttonXeHoi);
            this.Controls.Add(this.buttonXeMay);
            this.Controls.Add(this.buttonXeDap);
            this.Controls.Add(this.dataGridViewThongTinXe);
            this.Controls.Add(this.dataGridViewTho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "ThemCVForm";
            this.Text = "ThemCVForm";
            this.Load += new System.EventHandler(this.ThemCVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        public System.Windows.Forms.TextBox textBoxMaTho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxLoaiCongViec;
        private System.Windows.Forms.DataGridView dataGridViewTho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewThongTinXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonXeDap;
        private System.Windows.Forms.Button buttonXeMay;
        private System.Windows.Forms.Button buttonXeHoi;
    }
}