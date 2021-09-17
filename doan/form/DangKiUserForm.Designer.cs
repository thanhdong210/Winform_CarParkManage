
namespace doan
{
    partial class DangKiUserForm
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
            this.TextboxRePassword = new System.Windows.Forms.TextBox();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.TextboxUsername = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Adduser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextboxRePassword
            // 
            this.TextboxRePassword.Location = new System.Drawing.Point(151, 165);
            this.TextboxRePassword.Name = "TextboxRePassword";
            this.TextboxRePassword.PasswordChar = '*';
            this.TextboxRePassword.Size = new System.Drawing.Size(129, 22);
            this.TextboxRePassword.TabIndex = 9;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Location = new System.Drawing.Point(151, 109);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.PasswordChar = '*';
            this.TextboxPassword.Size = new System.Drawing.Size(129, 22);
            this.TextboxPassword.TabIndex = 10;
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Location = new System.Drawing.Point(151, 55);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(129, 22);
            this.TextboxUsername.TabIndex = 11;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(205, 254);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(96, 36);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Adduser
            // 
            this.bt_Adduser.Location = new System.Drawing.Point(49, 254);
            this.bt_Adduser.Name = "bt_Adduser";
            this.bt_Adduser.Size = new System.Drawing.Size(94, 36);
            this.bt_Adduser.TabIndex = 8;
            this.bt_Adduser.Text = "Add";
            this.bt_Adduser.UseVisualStyleBackColor = true;
            this.bt_Adduser.Click += new System.EventHandler(this.bt_Adduser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Re-Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // DangKiUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.TextboxRePassword);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUsername);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Adduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DangKiUserForm";
            this.Text = "DangKiUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextboxRePassword;
        public System.Windows.Forms.TextBox TextboxPassword;
        public System.Windows.Forms.TextBox TextboxUsername;
        public System.Windows.Forms.Button bt_Cancel;
        public System.Windows.Forms.Button bt_Adduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}