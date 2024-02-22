using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS_Desktop_Food_Dashboard
{
    public partial class Dashboard : Form
    {
        private string username;
        private string name;
        private string password;

        public Dashboard(string username, string name, string password)
        {
            InitializeComponent();
            this.username = username;
            this.name = name;
            this.password = password;
            ShowHomePage();
        }

        public void ShowHomePage()
        {
            lblPage.Text = "Home Page";
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            this.pnlDashboard.Controls.Clear();
            Home homePage = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(homePage);
            homePage.Show();
        }

        public void ShowFoodPage()
        {
            lblPage.Text = "Food Page";
            sidePanel.Height = btnFood.Height;
            sidePanel.Top = btnFood.Top;
            this.pnlDashboard.Controls.Clear();
            Food foodPage = new Food() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(foodPage);
            foodPage.Show();
        }

        public void ShowDrinkPage()
        {
            lblPage.Text = "Drink Page";
            sidePanel.Height = btnDrink.Height;
            sidePanel.Top = btnDrink.Top;
            this.pnlDashboard.Controls.Clear();
            Drink drinkPage = new Drink() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(drinkPage);
            drinkPage.Show();
        }

        public void ShowSnackPage()
        {
            lblPage.Text = "Snack Page";
            sidePanel.Height = btnSnack.Height;
            sidePanel.Top = btnSnack.Top;
            this.pnlDashboard.Controls.Clear();
            Snack snackPage = new Snack() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(snackPage);
            snackPage.Show();
        }

        public void ShowCartPage()
        {
            lblPage.Text = "Cart Page";
            sidePanel.Height = btnCart.Height;
            sidePanel.Top = btnCart.Top;
            this.pnlDashboard.Controls.Clear();
            Cart cartPage = new Cart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(cartPage);
            cartPage.Show();
        }

        public void ShowProfilePage()
        {
            lblPage.Text = "Profile Page";
            sidePanel.Height = btnProfile.Height;
            sidePanel.Top = btnProfile.Top;
            this.pnlDashboard.Controls.Clear();
            Profile profilePage = new Profile(username, name, password) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlDashboard.Controls.Add(profilePage);
            profilePage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ShowFoodPage();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            ShowDrinkPage();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            ShowSnackPage();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            ShowCartPage();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfilePage();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Yakin Ingin Keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}