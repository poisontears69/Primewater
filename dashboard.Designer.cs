namespace Primewater
{
    partial class dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            btnDashboard = new Button();
            btnWarehouse = new Button();
            btnInventory = new Button();
            btnCapex = new Button();
            menuContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            btnHistory = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(38, 69, 141);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(205, 60);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "     Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.FromArgb(38, 69, 141);
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Image = (Image)resources.GetObject("btnWarehouse.Image");
            btnWarehouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnWarehouse.Location = new Point(0, 0);
            btnWarehouse.Margin = new Padding(0);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(205, 60);
            btnWarehouse.TabIndex = 2;
            btnWarehouse.Text = "     Warehouse";
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(120, 163, 201);
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 0);
            btnInventory.Margin = new Padding(0);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(205, 60);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "      Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnCapex
            // 
            btnCapex.BackColor = Color.FromArgb(120, 163, 201);
            btnCapex.FlatAppearance.BorderSize = 0;
            btnCapex.FlatStyle = FlatStyle.Flat;
            btnCapex.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCapex.ForeColor = Color.White;
            btnCapex.Image = (Image)resources.GetObject("btnCapex.Image");
            btnCapex.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapex.Location = new Point(0, 0);
            btnCapex.Margin = new Padding(0);
            btnCapex.Name = "btnCapex";
            btnCapex.Size = new Size(205, 60);
            btnCapex.TabIndex = 2;
            btnCapex.Text = "     Capex";
            btnCapex.UseVisualStyleBackColor = false;
            btnCapex.Click += btnCapex_Click;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel5);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(3, 64);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(205, 60);
            menuContainer.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnWarehouse);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 61);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnInventory);
            panel6.Location = new Point(0, 61);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(205, 61);
            panel6.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCapex);
            panel7.Location = new Point(0, 122);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(205, 61);
            panel7.TabIndex = 11;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(38, 69, 141);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 0);
            btnHistory.Margin = new Padding(0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(205, 60);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "     History";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(38, 69, 141);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Margin = new Padding(0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(205, 60);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "     Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(38, 69, 141);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "     Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(38, 69, 141);
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(menuContainer);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(205, 681);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 61);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHistory);
            panel2.Location = new Point(0, 127);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 61);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSettings);
            panel3.Location = new Point(0, 188);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 61);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogout);
            panel4.Location = new Point(0, 249);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 61);
            panel4.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dashboard";
            Text = "Primewater";
            menuContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Button btnWarehouse;
        private Button btnInventory;
        private Button btnCapex;
        private FlowLayoutPanel menuContainer;
        private Button btnHistory;
        private Button btnSettings;
        private Button btnLogout;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private System.Windows.Forms.Timer timer1;
    }
}