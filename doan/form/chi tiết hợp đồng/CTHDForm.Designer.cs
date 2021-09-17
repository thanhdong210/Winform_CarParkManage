
namespace doan
{
    partial class CTHDForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonBienSoXe = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.radioButtonBienSoXe);
            this.panel1.Controls.Add(this.radioButtonNgay);
            this.panel1.Location = new System.Drawing.Point(128, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 2;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(740, 50);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(104, 30);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 1;
            // 
            // radioButtonBienSoXe
            // 
            this.radioButtonBienSoXe.AutoSize = true;
            this.radioButtonBienSoXe.Location = new System.Drawing.Point(497, 19);
            this.radioButtonBienSoXe.Name = "radioButtonBienSoXe";
            this.radioButtonBienSoXe.Size = new System.Drawing.Size(94, 21);
            this.radioButtonBienSoXe.TabIndex = 0;
            this.radioButtonBienSoXe.TabStop = true;
            this.radioButtonBienSoXe.Text = "Biển số xe";
            this.radioButtonBienSoXe.UseVisualStyleBackColor = true;
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Location = new System.Drawing.Point(350, 19);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(62, 21);
            this.radioButtonNgay.TabIndex = 0;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(1244, 460);
            this.dataGridViewCTHD.TabIndex = 1;
            // 
            // CTHDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1268, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Name = "CTHDForm";
            this.Text = "CTHDForm";
            this.Load += new System.EventHandler(this.CTHDForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton radioButtonBienSoXe;
        public System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
    }
}