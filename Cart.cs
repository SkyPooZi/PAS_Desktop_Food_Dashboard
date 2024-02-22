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
    public partial class Cart : Form
    {
        private int quantity = 1;
        private const int minQuantity = 1;
        private const int maxQuantity = 100;
        private int quantity1 = 1;
        private const int minQuantity1 = 1;
        private const int maxQuantity1 = 100;
        private int quantity2 = 1;
        private const int minQuantity2 = 1;
        private const int maxQuantity2 = 100;
        private decimal productPrice = 0;
        private decimal productPrice1 = 0;
        private decimal productPrice2 = 0;

        public Cart()
        {
            InitializeComponent();
            DisplayCartContents();
        }

        private void DisplayCartContents()
        {
            List<Product> cartContents = Food.cart;
            List<Product> cartContents1 = Drink.cart;
            List<Product> cartContents2 = Snack.cart;

            foreach (var product in cartContents)
            {
                panel1.Visible = true;
                lblName.Text = product.Name;
                productPrice = product.Price ?? 0;
                lblPrice.Text = "Rp " + productPrice.ToString();
                pbImage.Image = product.ProductImage;

                UpdateQuantityAndPrice();
                UpdateSubtotalAndTotal();
            }

            foreach (var product in cartContents1)
            {
                panel2.Visible = true;
                lblName1.Text = product.Name;
                productPrice1 = product.Price ?? 0;
                lblPrice1.Text = "Rp " + productPrice1.ToString();
                pbImage1.Image = product.ProductImage;

                UpdateQuantityAndPrice1();
                UpdateSubtotalAndTotal();
            }

            foreach (var product in cartContents2)
            {
                panel3.Visible = true;
                lblName2.Text = product.Name;
                productPrice2 = product.Price ?? 0;
                lblPrice2.Text = "Rp " + productPrice2.ToString();
                pbImage2.Image = product.ProductImage;

                UpdateQuantityAndPrice1();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            if (quantity > minQuantity)
            {
                quantity -= 1;
                UpdateQuantityAndPrice();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (quantity < maxQuantity)
            {
                quantity += 1;
                UpdateQuantityAndPrice();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnMines1_Click(object sender, EventArgs e)
        {
            if (quantity1 > minQuantity1)
            {
                quantity1 -= 1;
                UpdateQuantityAndPrice1();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            if (quantity1 < maxQuantity1)
            {
                quantity1 += 1;
                UpdateQuantityAndPrice1();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnMines2_Click(object sender, EventArgs e)
        {
            if (quantity2 > minQuantity2)
            {
                quantity2 -= 1;
                UpdateQuantityAndPrice2();
                UpdateSubtotalAndTotal();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            if (quantity2 < maxQuantity2)
            {
                quantity2 += 1;
                UpdateQuantityAndPrice2();
                UpdateSubtotalAndTotal();
            }
        }

        private void UpdateQuantityAndPrice()
        {
            lblQuantity.Text = quantity.ToString();
            lblPrice.Text = "Rp " + (quantity * productPrice).ToString();
        }

        private void UpdateQuantityAndPrice1()
        {
            lblQuantity1.Text = quantity1.ToString();
            lblPrice1.Text = "Rp " + (quantity1 * productPrice1).ToString();
        }

        private void UpdateQuantityAndPrice2()
        {
            lblQuantity2.Text = quantity2.ToString();
            lblPrice2.Text = "Rp " + (quantity2 * productPrice2).ToString();
        }

        private void UpdateSubtotalAndTotal()
        {
            int subTotalFood = (int)(quantity * productPrice);
            int subTotalDrink = (int)(quantity1 * productPrice1);
            int subTotalSnack = (int)(quantity2 * productPrice2);

            int subTotal = subTotalFood + subTotalDrink + subTotalSnack;
            lblSubTotal.Text = "Rp " + subTotal.ToString();

            int discount = (int)(subTotal * 0.1m);
            lblDiscount.Text = "Rp " + discount.ToString();

            int total = subTotal - discount;
            lblTotal.Text = "Rp " + total.ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogCart = MessageBox.Show("Payment Success", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogCart == DialogResult.OK)
            {
                Food.cart.Clear();
                Drink.cart.Clear();
                Snack.cart.Clear();
                lblSubTotal.Text = "Rp 0";
                lblDiscount.Text = "Rp 0";
                lblTotal.Text = "Rp 0";
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }
    }
}