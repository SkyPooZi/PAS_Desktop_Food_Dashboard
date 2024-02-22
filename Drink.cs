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
    public partial class Drink : Form
    {
        public static List<Product> cart = new List<Product>();

        public Drink()
        {
            InitializeComponent();
        }

        private void btnEsTeh_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Es Teh"))
            {
                    Product esTeh = new Product
                {
                    ProductImage = Properties.Resources.es_teh,
                    Name = "Es Teh",
                    Price = 3000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(esTeh);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEsJeruk_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Es Jeruk"))
            {
                Product esJeruk = new Product
                {
                    ProductImage = Properties.Resources.es_jeruk,
                    Name = "Es Jeruk",
                    Price = 4000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(esJeruk);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKopi_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Kopi"))
            {
                Product kopi = new Product
                {
                    ProductImage = Properties.Resources.kopi,
                    Name = "Kopi",
                    Price = 5000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(kopi);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEsSusu_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Es Susu"))
            {
                Product esSusu = new Product
                {
                    ProductImage = Properties.Resources.susu,
                    Name = "Es Susu",
                    Price = 6000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(esSusu);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWedangJahe_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Wedang Jahe"))
            {
                Product wedangJahe = new Product
                {
                    ProductImage = Properties.Resources.wedang_jahe,
                    Name = "Wedang Jahe",
                    Price = 7000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(wedangJahe);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSTMJ_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "STMJ"))
            {
                Product stmj = new Product
                {
                    ProductImage = Properties.Resources.stmj,
                    Name = "STMJ",
                    Price = 12000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(stmj);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMujigae_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Mujigae"))
            {
                Product mujigae = new Product
                {
                    ProductImage = Properties.Resources.mujigae,
                    Name = "Mujigae",
                    Price = 10000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(mujigae);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLasegar_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Lasegar"))
            {
                Product lasegar = new Product
                {
                    ProductImage = Properties.Resources.lasegar,
                    Name = "Lasegar",
                    Price = 8000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(lasegar);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
