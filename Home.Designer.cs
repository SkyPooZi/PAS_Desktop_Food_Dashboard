namespace PAS_Desktop_Food_Dashboard
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnOrder = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(244, 138, 7);
            label3.Location = new Point(30, 160);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 18;
            label3.Text = "Hanya";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 50);
            label4.Name = "label4";
            label4.Size = new Size(589, 93);
            label4.TabIndex = 19;
            label4.Text = "Ayam Geprek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 290);
            label5.Name = "label5";
            label5.Size = new Size(369, 21);
            label5.TabIndex = 20;
            label5.Text = "Dengan rasa pedas yang berbeda-beda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 350);
            label6.Name = "label6";
            label6.Size = new Size(327, 120);
            label6.TabIndex = 21;
            label6.Text = resources.GetString("label6.Text");
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(244, 138, 7);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(30, 510);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(325, 50);
            btnOrder.TabIndex = 22;
            btnOrder.Text = "Order Now";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(470, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(244, 138, 7);
            label2.Location = new Point(30, 190);
            label2.Name = "label2";
            label2.Size = new Size(368, 77);
            label2.TabIndex = 17;
            label2.Text = "Rp 10.000";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(pictureBox1);
            Controls.Add(btnOrder);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnOrder;
        private PictureBox pictureBox1;
        private Label label2;
    }
}