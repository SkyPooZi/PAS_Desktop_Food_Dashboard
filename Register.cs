using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS_Desktop_Food_Dashboard
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = txtPassword.Text;
            string password = txtPassword.Text;

            if (username != "" && password != "")
            {
                Dashboard baru = new Dashboard(username, name, password);
                baru.Show();
                this.Hide();
            }
            else if (username == "" && password == "")
            {
                DialogResult dialogResult = MessageBox.Show("Silahakan Masukkan Username dan Password!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silahakan Masukkan Username dan Password!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login baru = new Login();
            baru.Show();
            this.Hide();
        }
    }
}
