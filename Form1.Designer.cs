namespace PAS_Desktop_Food_Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnLogout = new Button();
            sidePanel = new Panel();
            btnProfile = new Button();
            btnDrink = new Button();
            btnHome = new Button();
            btnCart = new Button();
            btnFood = new Button();
            btnSnack = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pnlDashboard = new Panel();
            lblPage = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnDrink);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnCart);
            panel1.Controls.Add(btnFood);
            panel1.Controls.Add(btnSnack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 850);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.Group_1;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 780);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(30, 0, 0, 0);
            btnLogout.Size = new Size(250, 70);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Close";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(244, 138, 7);
            sidePanel.Location = new Point(0, 130);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 68);
            sidePanel.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = Properties.Resources.Group;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 710);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(30, 0, 0, 0);
            btnProfile.Size = new Size(250, 70);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDrink
            // 
            btnDrink.FlatAppearance.BorderSize = 0;
            btnDrink.FlatStyle = FlatStyle.Flat;
            btnDrink.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrink.ForeColor = Color.White;
            btnDrink.Image = Properties.Resources.Vector_1;
            btnDrink.ImageAlign = ContentAlignment.MiddleLeft;
            btnDrink.Location = new Point(0, 270);
            btnDrink.Name = "btnDrink";
            btnDrink.Padding = new Padding(30, 0, 0, 0);
            btnDrink.Size = new Size(250, 68);
            btnDrink.TabIndex = 2;
            btnDrink.Text = "Drink";
            btnDrink.UseVisualStyleBackColor = true;
            btnDrink.Click += btnDrink_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 130);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(250, 68);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnCart
            // 
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCart.ForeColor = Color.White;
            btnCart.Image = Properties.Resources.cart;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(0, 410);
            btnCart.Name = "btnCart";
            btnCart.Padding = new Padding(30, 0, 0, 0);
            btnCart.Size = new Size(250, 68);
            btnCart.TabIndex = 4;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnFood
            // 
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFood.ForeColor = Color.White;
            btnFood.Image = Properties.Resources.Vector_2;
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(0, 200);
            btnFood.Name = "btnFood";
            btnFood.Padding = new Padding(30, 0, 0, 0);
            btnFood.Size = new Size(250, 68);
            btnFood.TabIndex = 1;
            btnFood.Text = "Food";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnSnack
            // 
            btnSnack.FlatAppearance.BorderSize = 0;
            btnSnack.FlatStyle = FlatStyle.Flat;
            btnSnack.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnack.ForeColor = Color.White;
            btnSnack.Image = Properties.Resources.Vector;
            btnSnack.ImageAlign = ContentAlignment.MiddleLeft;
            btnSnack.Location = new Point(0, 340);
            btnSnack.Name = "btnSnack";
            btnSnack.Padding = new Padding(30, 0, 0, 0);
            btnSnack.Size = new Size(250, 68);
            btnSnack.TabIndex = 3;
            btnSnack.Text = "Snack";
            btnSnack.UseVisualStyleBackColor = true;
            btnSnack.Click += btnSnack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 138, 7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 138, 7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 150);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 115);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Restourents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 90);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 4;
            label2.Text = "Fast Foods";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(436, 23);
            label4.Name = "label4";
            label4.Size = new Size(465, 23);
            label4.TabIndex = 4;
            label4.Text = "PAS Dekstop by Moch Siril Wafa ZIdane Feliano";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Location = new Point(250, 200);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(950, 650);
            pnlDashboard.TabIndex = 5;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPage.Location = new Point(650, 150);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(157, 34);
            lblPage.TabIndex = 6;
            lblPage.Text = "JudulPage";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 850);
            Controls.Add(lblPage);
            Controls.Add(pnlDashboard);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Dashboard";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btnHome;
        private Button btnCart;
        private Button btnSnack;
        private Button btnDrink;
        private Button btnFood;
        private Button btnProfile;
        private Panel sidePanel;
        private Label label4;
        private Button btnLogout;
        private Panel pnlDashboard;
        private Label lblPage;
    }
}