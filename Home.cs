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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Dashboard? dashboard = this.ParentForm as Dashboard;
            if (dashboard != null)
            {
                dashboard.ShowFoodPage();
            }
        }
    }
}
