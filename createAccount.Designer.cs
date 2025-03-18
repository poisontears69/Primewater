namespace Primewater
{
    partial class createAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createAccount));
            pictureBox1 = new PictureBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            confirmPasswordTextBox = new TextBox();
            btnCreateAccount = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.FromArgb(4, 171, 237);
            passwordTextBox.Location = new Point(98, 340);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(245, 16);
            passwordTextBox.TabIndex = 11;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = Color.FromArgb(4, 171, 237);
            usernameTextBox.Location = new Point(98, 273);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(245, 16);
            usernameTextBox.TabIndex = 12;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 171, 237);
            panel2.Location = new Point(98, 358);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 1);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 171, 237);
            panel1.Location = new Point(98, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 1);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 171, 237);
            panel3.Location = new Point(98, 424);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 1);
            panel3.TabIndex = 9;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Cursor = Cursors.IBeam;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.ForeColor = Color.FromArgb(4, 171, 237);
            confirmPasswordTextBox.Location = new Point(98, 406);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(245, 16);
            confirmPasswordTextBox.TabIndex = 11;
            confirmPasswordTextBox.TextChanged += confirmPasswordTextBox_TextChanged;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(4, 171, 237);
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(122, 445);
            btnCreateAccount.Margin = new Padding(0);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(200, 40);
            btnCreateAccount.TabIndex = 13;
            btnCreateAccount.Text = "CREATE";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(4, 171, 237);
            btnExit.Location = new Point(184, 488);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 30);
            btnExit.TabIndex = 14;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(98, 250);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 15;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 171, 237);
            label2.Location = new Point(98, 317);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 15;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 171, 237);
            label3.Location = new Point(98, 383);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 15;
            label3.Text = "Confirm Password:";
            // 
            // createAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 680);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCreateAccount);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(panel3);
            Controls.Add(usernameTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "createAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "createAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TextBox confirmPasswordTextBox;
        private Button btnCreateAccount;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}