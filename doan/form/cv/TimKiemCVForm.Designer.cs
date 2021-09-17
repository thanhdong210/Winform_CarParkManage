
namespace doan
{
    partial class TimKiemCVForm
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.radioButtonMaXe = new System.Windows.Forms.RadioButton();
            this.radioButtonTenCV = new System.Windows.Forms.RadioButton();
            this.dataGridViewTimCV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimCV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.textBoxTimKiem);
            this.panel1.Controls.Add(this.radioButtonMaXe);
            this.panel1.Controls.Add(this.radioButtonTenCV);
            this.panel1.Location = new System.Drawing.Point(128, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(355, 43);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(104, 33);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Tìm Kiếm";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(140, 53);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(178, 22);
            this.textBoxTimKiem.TabIndex = 2;
            // 
            // radioButtonMaXe
            // 
            this.radioButtonMaXe.AutoSize = true;
            this.radioButtonMaXe.Location = new System.Drawing.Point(273, 16);
            this.radioButtonMaXe.Name = "radioButtonMaXe";
            this.radioButtonMaXe.Size = new System.Drawing.Size(66, 21);
            this.radioButtonMaXe.TabIndex = 0;
            this.radioButtonMaXe.TabStop = true;
            this.radioButtonMaXe.Text = "Mã xe";
            this.radioButtonMaXe.UseVisualStyleBackColor = true;
            // 
            // radioButtonTenCV
            // 
            this.radioButtonTenCV.AutoSize = true;
            this.radioButtonTenCV.Location = new System.Drawing.Point(117, 16);
            this.radioButtonTenCV.Name = "radioButtonTenCV";
            this.radioButtonTenCV.Size = new System.Drawing.Size(118, 21);
            this.radioButtonTenCV.TabIndex = 0;
            this.radioButtonTenCV.TabStop = true;
            this.radioButtonTenCV.Text = "Tên công việc";
            this.radioButtonTenCV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimCV
            // 
            this.dataGridViewTimCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimCV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTimCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimCV.Location = new System.Drawing.Point(7, 121);
            this.dataGridViewTimCV.Name = "dataGridViewTimCV";
            this.dataGridViewTimCV.RowHeadersWidth = 51;
            this.dataGridViewTimCV.RowTemplate.Height = 24;
            this.dataGridViewTimCV.Size = new System.Drawing.Size(785, 320);
            this.dataGridViewTimCV.TabIndex = 1;
            // 
            // TimKiemCVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTimCV);
            this.Controls.Add(this.panel1);
            this.Name = "TimKiemCVForm";
            this.Text = "TimKiemCVForm";
            this.Load += new System.EventHandler(this.TimKiemCVForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTimCV;
        public System.Windows.Forms.RadioButton radioButtonMaXe;
        public System.Windows.Forms.RadioButton radioButtonTenCV;
        public System.Windows.Forms.Button buttonCheck;
        public System.Windows.Forms.TextBox textBoxTimKiem;
    }
}