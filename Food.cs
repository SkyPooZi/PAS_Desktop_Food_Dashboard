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
    public partial class Food : Form
    {
        public static List<Product> cart = new List<Product>();

        public Food()
        {
            InitializeComponent();
        }

        private void btnNasiGoreng_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Nasi Goreng"))
            {
                    Product nasiGoreng = new Product
                {
                    ProductImage = Properties.Resources.nasi_goreng,
                    Name = "Nasi Goreng",
                    Price = 11000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(nasiGoreng);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMieGoreng_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Mie Goreng"))
            {
                    Product mieGoreng = new Product
                {
                    ProductImage = Properties.Resources.indomie_goreng,
                    Name = "Mie Goreng",
                    Price = 5000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(mieGoreng);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAyamGoreng_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Ayam Goreng"))
            {
                Product ayamGoreng = new Product
                {
                    ProductImage = Properties.Resources.ayam_goreng,
                    Name = "Ayam Goreng",
                    Price = 8000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(ayamGoreng);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAyamGeprek_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Ayam Geprek"))
            {
                Product ayamGeprek = new Product
                {
                    ProductImage = Properties.Resources.ayam_geprek,
                    Name = "Ayam Geprek",
                    Price = 10000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(ayamGeprek);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSateAyam_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Sate Ayam"))
            {
                Product sateAyam = new Product
                {
                    ProductImage = Properties.Resources.sate_ayam,
                    Name = "Sate Ayam",
                    Price = 12000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(sateAyam);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRendang_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Rendang"))
            {
                Product rendang = new Product
                {
                    ProductImage = Properties.Resources.rendang,
                    Name = "Rendang",
                    Price = 15000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(rendang);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOporAyam_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Opor Ayam"))
            {
                Product oporAyam = new Product
                {
                    ProductImage = Properties.Resources.opor_ayam,
                    Name = "Opor Ayam",
                    Price = 18000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(oporAyam);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMieAyam_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Mie Ayam"))
            {
                Product mieAyam = new Product
                {
                    ProductImage = Properties.Resources.mie_ayam,
                    Name = "Mie Ayam",
                    Price = 7000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(mieAyam);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
