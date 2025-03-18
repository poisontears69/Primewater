namespace Primewater
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            btnExit = new Button();
            adminPassword = new TextBox();
            adminUsername = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(4, 171, 237);
            btnExit.Location = new Point(186, 481);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 30);
            btnExit.TabIndex = 19;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // adminPassword
            // 
            adminPassword.BorderStyle = BorderStyle.None;
            adminPassword.Cursor = Cursors.IBeam;
            adminPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminPassword.ForeColor = Color.FromArgb(4, 171, 237);
            adminPassword.Location = new Point(104, 345);
            adminPassword.Name = "adminPassword";
            adminPassword.PasswordChar = '*';
            adminPassword.Size = new Size(245, 16);
            adminPassword.TabIndex = 16;
            adminPassword.TextChanged += adminPassword_TextChanged;
            // 
            // adminUsername
            // 
            adminUsername.BorderStyle = BorderStyle.None;
            adminUsername.Cursor = Cursors.IBeam;
            adminUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminUsername.ForeColor = Color.FromArgb(4, 171, 237);
            adminUsername.Location = new Point(104, 278);
            adminUsername.Name = "adminUsername";
            adminUsername.Size = new Size(245, 16);
            adminUsername.TabIndex = 17;
            adminUsername.TextChanged += adminUsername_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 171, 237);
            panel2.Location = new Point(104, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 1);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 171, 237);
            panel1.Location = new Point(104, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 1);
            panel1.TabIndex = 15;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(4, 171, 237);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(128, 438);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(66, 332);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(128, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 200);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(169, 215);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 21;
            label1.Text = "ADMIN LOGIN";
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 680);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(btnExit);
            Controls.Add(adminPassword);
            Controls.Add(adminUsername);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox adminPassword;
        private TextBox adminUsername;
        private Panel panel2;
        private Panel panel1;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
    }
}