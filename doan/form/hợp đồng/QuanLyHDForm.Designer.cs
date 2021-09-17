
namespace doan
{
    partial class QuanLyHDForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonRF = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.radioButtonLoai2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLoai1 = new System.Windows.Forms.RadioButton();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewQuanLyHD = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyHD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRF
            // 
            this.buttonRF.Location = new System.Drawing.Point(476, 333);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(107, 27);
            this.buttonRF.TabIndex = 24;
            this.buttonRF.Text = "Refresh";
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(51, 185);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 24);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // radioButtonLoai2
            // 
            this.radioButtonLoai2.AutoSize = true;
            this.radioButtonLoai2.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonLoai2.Location = new System.Drawing.Point(228, 115);
            this.radioButtonLoai2.Name = "radioButtonLoai2";
            this.radioButtonLoai2.Size = new System.Drawing.Size(68, 21);
            this.radioButtonLoai2.TabIndex = 22;
            this.radioButtonLoai2.TabStop = true;
            this.radioButtonLoai2.Text = "Loại 2";
            this.radioButtonLoai2.UseVisualStyleBackColor = false;
            // 
            // radioButtonLoai1
            // 
            this.radioButtonLoai1.AutoSize = true;
            this.radioButtonLoai1.BackColor = System.Drawing.Color.LightGray;
            this.radioButtonLoai1.Location = new System.Drawing.Point(150, 115);
            this.radioButtonLoai1.Name = "radioButtonLoai1";
            this.radioButtonLoai1.Size = new System.Drawing.Size(68, 21);
            this.radioButtonLoai1.TabIndex = 23;
            this.radioButtonLoai1.TabStop = true;
            this.radioButtonLoai1.Text = "Loại 1";
            this.radioButtonLoai1.UseVisualStyleBackColor = false;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(150, 67);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(72, 22);
            this.textBoxMaHD.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Loại hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin hợp đồng";
            // 
            // dataGridViewQuanLyHD
            // 
            this.dataGridViewQuanLyHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQuanLyHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyHD.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewQuanLyHD.Location = new System.Drawing.Point(345, 12);
            this.dataGridViewQuanLyHD.Name = "dataGridViewQuanLyHD";
            this.dataGridViewQuanLyHD.RowHeadersWidth = 51;
            this.dataGridViewQuanLyHD.RowTemplate.Height = 24;
            this.dataGridViewQuanLyHD.Size = new System.Drawing.Size(380, 315);
            this.dataGridViewQuanLyHD.TabIndex = 17;
            this.dataGridViewQuanLyHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaSuaHD_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 28);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 348);
            this.panel1.TabIndex = 26;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(168, 185);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 24);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(51, 147);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 24);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 224);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lưu ý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại 2: Khách kí gửi xe để công ty cho thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Loại 1: Khách thuê xe của công ty";
            // 
            // QuanLyHDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(742, 370);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.radioButtonLoai2);
            this.Controls.Add(this.radioButtonLoai1);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewQuanLyHD);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHDForm";
            this.Text = "QuanLyHDForm";
            this.Load += new System.EventHandler(this.QuanLyHDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyHD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonRF;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.RadioButton radioButtonLoai2;
        private System.Windows.Forms.RadioButton radioButtonLoai1;
        public System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyHD;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
    }
}