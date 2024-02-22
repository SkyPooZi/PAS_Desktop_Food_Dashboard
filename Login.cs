using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS_Desktop_Food_Dashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = "Moch Siril Wafa Zidane Feliano";
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
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
                DialogResult dialogResult = MessageBox.Show("Username dan Password Salah!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register baru = new Register();
            baru.Show();
            this.Hide();
        }
    }
}
