using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class DangKiUserForm : Form
    {
        public DangKiUserForm()
        {
            InitializeComponent();
        }

        private void bt_Adduser_Click(object sender, EventArgs e)
        {
            USER user = new USER();

            string username = TextboxUsername.Text;
            string password = TextboxPassword.Text;
            string repassword = TextboxRePassword.Text;
            if (verif() == true)
            {

                if (user.insertUser(username, password))
                {
                    MessageBox.Show("Da them thanh cong", "Them User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", "them User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {

            if ((TextboxUsername.Text.Trim() == "") || (TextboxPassword.Text.Trim() == "") || (TextboxRePassword.Text.Trim() == ""))
            {
                return false;
            }
            if (string.Compare(TextboxPassword.Text.ToString(), TextboxRePassword.Text.ToString(), false) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
