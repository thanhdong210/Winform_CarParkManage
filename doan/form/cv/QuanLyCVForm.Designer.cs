
namespace doan
{
    partial class QuanLyCVForm
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
            this.dataGridViewQuanLyCV = new System.Windows.Forms.DataGridView();
            this.textBoxMaTho = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxLoaiCV = new System.Windows.Forms.TextBox();
            this.textBoxChuSoHuu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyCV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyCV
            // 
            this.dataGridViewQuanLyCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyCV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQuanLyCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyCV.Location = new System.Drawing.Point(407, 25);
            this.dataGridViewQuanLyCV.Name = "dataGridViewQuanLyCV";
            this.dataGridViewQuanLyCV.RowHeadersWidth = 51;
            this.dataGridViewQuanLyCV.RowTemplate.Height = 24;
            this.dataGridViewQuanLyCV.Size = new System.Drawing.Size(530, 371);
            this.dataGridViewQuanLyCV.TabIndex = 25;
            this.dataGridViewQuanLyCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyCV_CellClick);
            // 
            // textBoxMaTho
            // 
            this.textBoxMaTho.Location = new System.Drawing.Point(186, 273);
            this.textBoxMaTho.Name = "textBoxMaTho";
            this.textBoxMaTho.Size = new System.Drawing.Size(74, 22);
            this.textBoxMaTho.TabIndex = 21;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(407, 402);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 35);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxLoaiCV
            // 
            this.textBoxLoaiCV.Location = new System.Drawing.Point(186, 208);
            this.textBoxLoaiCV.Name = "textBoxLoaiCV";
            this.textBoxLoaiCV.Size = new System.Drawing.Size(166, 22);
            this.textBoxLoaiCV.TabIndex = 22;
            // 
            // textBoxChuSoHuu
            // 
            this.textBoxChuSoHuu.Location = new System.Drawing.Point(186, 138);
            this.textBoxChuSoHuu.Name = "textBoxChuSoHuu";
            this.textBoxChuSoHuu.Size = new System.Drawing.Size(166, 22);
            this.textBoxChuSoHuu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(105, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã thợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(57, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(76, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chủ sở hữu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 412);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông tin công việc";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(177, 301);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 35);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 356);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 35);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(51, 356);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(96, 35);
            this.buttonXoa.TabIndex = 14;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(51, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 35);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(140, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(74, 22);
            this.textBoxID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã ID xe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Location = new System.Drawing.Point(761, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 42);
            this.panel3.TabIndex = 28;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(15, 13);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(109, 17);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Tổng công việc:";
            // 
            // QuanLyCVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(947, 457);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewQuanLyCV);
            this.Controls.Add(this.textBoxMaTho);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxLoaiCV);
            this.Controls.Add(this.textBoxChuSoHuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyCVForm";
            this.Text = "QuanLyCVForm";
            this.Load += new System.EventHandler(this.QuanLyCVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyCV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyCV;
        public System.Windows.Forms.TextBox textBoxMaTho;
        public System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.TextBox textBoxLoaiCV;
        public System.Windows.Forms.TextBox textBoxChuSoHuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTotal;
    }
}