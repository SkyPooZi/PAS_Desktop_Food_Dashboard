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
    public partial class Snack : Form
    {
        public static List<Product> cart = new List<Product>();

        public Snack()
        {
            InitializeComponent();
        }

        private void btnBengBeng_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Beng Beng"))
            {
                    Product bengBeng = new Product
                {
                    ProductImage = Properties.Resources.beng_beng,
                    Name = "Beng Beng",
                    Price = 3000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(bengBeng);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPiatos_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Piatos"))
            {
                Product piatos = new Product
                {
                    ProductImage = Properties.Resources.piatos,
                    Name = "Piatos",
                    Price = 12000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(piatos);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaro_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Taro"))
            {
                Product taro = new Product
                {
                    ProductImage = Properties.Resources.taro,
                    Name = "Taro",
                    Price = 5000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(taro);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPotabee_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Potabee"))
            {
                Product potabee = new Product
                {
                    ProductImage = Properties.Resources.potabee,
                    Name = "Potabee",
                    Price = 9000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(potabee);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSukro_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Sukro"))
            {
                Product sukro = new Product
                {
                    ProductImage = Properties.Resources.sukro,
                    Name = "Sukro",
                    Price = 6000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(sukro);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTicTac_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Tic Tac"))
            {
                Product ticTac = new Product
                {
                    ProductImage = Properties.Resources.tic_tac,
                    Name = "Tic Tac",
                    Price = 7000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(ticTac);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPocky_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Pocky"))
            {
                Product pocky = new Product
                {
                    ProductImage = Properties.Resources.pocky,
                    Name = "Pocky",
                    Price = 8000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(pocky);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHappyTos_Click(object sender, EventArgs e)
        {
            if (!cart.Any(item => item.Name == "Happy Tos"))
            {
                Product happyTos = new Product
                {
                    ProductImage = Properties.Resources.happy_tos,
                    Name = "Happy Tos",
                    Price = 10000,
                };

                MessageBox.Show("Add To Cart Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cart.Add(happyTos);
            }
            else
            {
                MessageBox.Show("Item already in cart!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
