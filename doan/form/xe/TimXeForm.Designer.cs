
namespace doan
{
    partial class TimXeForm
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
            this.dataGridViewTimXe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTimXe
            // 
            this.dataGridViewTimXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimXe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTimXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimXe.Location = new System.Drawing.Point(6, 121);
            this.dataGridViewTimXe.Name = "dataGridViewTimXe";
            this.dataGridViewTimXe.RowHeadersWidth = 51;
            this.dataGridViewTimXe.RowTemplate.Height = 24;
            this.dataGridViewTimXe.Size = new System.Drawing.Size(945, 482);
            this.dataGridViewTimXe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ID xe";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(168, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.Location = new System.Drawing.Point(310, 47);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(115, 31);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            this.buttonCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonCheck_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.radioButtonXeHoi);
            this.panel1.Controls.Add(this.radioButtonXeMay);
            this.panel1.Controls.Add(this.radioButtonXeDap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Location = new System.Drawing.Point(218, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 96);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Location = new System.Drawing.Point(291, 13);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(71, 21);
            this.radioButtonXeHoi.TabIndex = 4;
            this.radioButtonXeHoi.TabStop = true;
            this.radioButtonXeHoi.Text = "Xe Hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Location = new System.Drawing.Point(183, 13);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXeMay.TabIndex = 4;
            this.radioButtonXeMay.TabStop = true;
            this.radioButtonXeMay.Text = "Xe Máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Location = new System.Drawing.Point(77, 13);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXeDap.TabIndex = 4;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe Đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            // 
            // TimXeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(957, 609);
            this.Controls.Add(this.dataGridViewTimXe);
            this.Controls.Add(this.panel1);
            this.Name = "TimXeForm";
            this.Text = "TimXeForm";
            this.Load += new System.EventHandler(this.TimXeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radioButtonXeHoi;
        public System.Windows.Forms.RadioButton radioButtonXeMay;
        public System.Windows.Forms.RadioButton radioButtonXeDap;
    }
}