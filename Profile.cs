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
    public partial class Profile : Form
    {
        public Profile(string username, string name, string password)
        {
            InitializeComponent();
            lblUsername.Text = username;
            lblName.Text = name;
            lblPassword.Text = password;
        }
    }
}
