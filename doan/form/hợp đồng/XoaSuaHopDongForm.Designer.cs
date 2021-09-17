
namespace doan
{
    partial class XoaSuaHopDongForm
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
            this.dataGridViewXoaSuaHD = new System.Windows.Forms.DataGridView();
            this.radioButtonLoai2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLoai1 = new System.Windows.Forms.RadioButton();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewXoaSuaHD
            // 
            this.dataGridViewXoaSuaHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXoaSuaHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXoaSuaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSuaHD.Location = new System.Drawing.Point(345, 21);
            this.dataGridViewXoaSuaHD.Name = "dataGridViewXoaSuaHD";
            this.dataGridViewXoaSuaHD.RowHeadersWidth = 51;
            this.dataGridViewXoaSuaHD.RowTemplate.Height = 24;
            this.dataGridViewXoaSuaHD.Size = new System.Drawing.Size(380, 238);
            this.dataGridViewXoaSuaHD.TabIndex = 0;
            this.dataGridViewXoaSuaHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaHD_CellClick);
            this.dataGridViewXoaSuaHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaHD_CellContentClick);
            // 
            // radioButtonLoai2
            // 
            this.radioButtonLoai2.AutoSize = true;
            this.radioButtonLoai2.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonLoai2.Location = new System.Drawing.Point(228, 124);
            this.radioButtonLoai2.Name = "radioButtonLoai2";
            this.radioButtonLoai2.Size = new System.Drawing.Size(68, 21);
            this.radioButtonLoai2.TabIndex = 10;
            this.radioButtonLoai2.TabStop = true;
            this.radioButtonLoai2.Text = "Loại 2";
            this.radioButtonLoai2.UseVisualStyleBackColor = false;
            this.radioButtonLoai2.CheckedChanged += new System.EventHandler(this.radioButtonLoai2_CheckedChanged);
            // 
            // radioButtonLoai1
            // 
            this.radioButtonLoai1.AutoSize = true;
            this.radioButtonLoai1.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonLoai1.Location = new System.Drawing.Point(150, 124);
            this.radioButtonLoai1.Name = "radioButtonLoai1";
            this.radioButtonLoai1.Size = new System.Drawing.Size(68, 21);
            this.radioButtonLoai1.TabIndex = 11;
            this.radioButtonLoai1.TabStop = true;
            this.radioButtonLoai1.Text = "Loại 1";
            this.radioButtonLoai1.UseVisualStyleBackColor = false;
            this.radioButtonLoai1.CheckedChanged += new System.EventHandler(this.radioButtonLoai1_CheckedChanged);
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(150, 76);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(72, 22);
            this.textBoxMaHD.TabIndex = 9;
            this.textBoxMaHD.TextChanged += new System.EventHandler(this.textBoxMaHD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại hợp đồng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã hợp đồng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông tin hợp đồng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lưu ý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại 2: Khách kí gửi xe để công ty cho thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại 1: Khách thuê xe của công ty";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(61, 168);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 24);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(168, 147);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(80, 24);
            this.buttonXoa.TabIndex = 15;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 296);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRF
            // 
            this.buttonRF.Location = new System.Drawing.Point(479, 274);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(107, 27);
            this.buttonRF.TabIndex = 15;
            this.buttonRF.Text = "Refresh";
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // XoaSuaHopDongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(736, 329);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.radioButtonLoai2);
            this.Controls.Add(this.radioButtonLoai1);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewXoaSuaHD);
            this.Controls.Add(this.panel1);
            this.Name = "XoaSuaHopDongForm";
            this.Text = "XoaSuaHopDongForm";
            this.Load += new System.EventHandler(this.XoaSuaHopDongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSuaHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXoaSuaHD;
        public System.Windows.Forms.RadioButton radioButtonLoai2;
        private System.Windows.Forms.RadioButton radioButtonLoai1;
        public System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonRF;
        public System.Windows.Forms.Button buttonXoa;
    }
}