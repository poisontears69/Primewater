namespace Primewater
{
    partial class settings
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
            panel10 = new Panel();
            panel11 = new Panel();
            panel1 = new Panel();
            radioInventory = new RadioButton();
            radioCapex = new RadioButton();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            modifyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dataGridView2 = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            modifyToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            panel13 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            itemDescTB = new TextBox();
            itemCodeTB = new TextBox();
            jobDescTB = new TextBox();
            jobCodeTB = new TextBox();
            panel2 = new Panel();
            btnSaveItem = new Button();
            panel12 = new Panel();
            btnSaveJobType = new Button();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(4, 171, 237);
            panel10.Location = new Point(342, 975);
            panel10.Name = "panel10";
            panel10.Size = new Size(196, 1);
            panel10.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(4, 171, 237);
            panel11.Location = new Point(342, 1255);
            panel11.Name = "panel11";
            panel11.Size = new Size(196, 1);
            panel11.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(radioInventory);
            panel1.Controls.Add(radioCapex);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(itemDescTB);
            panel1.Controls.Add(itemCodeTB);
            panel1.Controls.Add(jobDescTB);
            panel1.Controls.Add(jobCodeTB);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSaveItem);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(btnSaveJobType);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 642);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // radioInventory
            // 
            radioInventory.AutoSize = true;
            radioInventory.Location = new Point(301, 451);
            radioInventory.Name = "radioInventory";
            radioInventory.Size = new Size(75, 19);
            radioInventory.TabIndex = 50;
            radioInventory.TabStop = true;
            radioInventory.Text = "Inventory";
            radioInventory.UseVisualStyleBackColor = true;
            radioInventory.CheckedChanged += radioInventory_CheckedChanged;
            // 
            // radioCapex
            // 
            radioCapex.AutoSize = true;
            radioCapex.Location = new Point(212, 451);
            radioCapex.Name = "radioCapex";
            radioCapex.Size = new Size(57, 19);
            radioCapex.TabIndex = 49;
            radioCapex.TabStop = true;
            radioCapex.Text = "Capex";
            radioCapex.UseVisualStyleBackColor = true;
            radioCapex.CheckedChanged += radioCapex_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(447, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(326, 231);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { modifyToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(180, 22);
            modifyToolStripMenuItem.Text = "Modify";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
            dataGridView2.Location = new Point(447, 314);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(326, 231);
            dataGridView2.TabIndex = 47;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { modifyToolStripMenuItem1, deleteToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(113, 48);
            // 
            // modifyToolStripMenuItem1
            // 
            modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            modifyToolStripMenuItem1.Size = new Size(112, 22);
            modifyToolStripMenuItem1.Text = "Modify";
            modifyToolStripMenuItem1.Click += modifyToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(112, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click_1;
            // 
            // panel13
            // 
            panel13.Location = new Point(301, 626);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 100);
            panel13.TabIndex = 46;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(4, 171, 237);
            panel6.Location = new Point(212, 430);
            panel6.Name = "panel6";
            panel6.Size = new Size(196, 1);
            panel6.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(4, 171, 237);
            panel5.Location = new Point(212, 380);
            panel5.Name = "panel5";
            panel5.Size = new Size(196, 1);
            panel5.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(4, 171, 237);
            panel4.Location = new Point(219, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(196, 1);
            panel4.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 171, 237);
            panel3.Location = new Point(219, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 1);
            panel3.TabIndex = 38;
            // 
            // itemDescTB
            // 
            itemDescTB.BorderStyle = BorderStyle.None;
            itemDescTB.Location = new Point(214, 412);
            itemDescTB.Name = "itemDescTB";
            itemDescTB.Size = new Size(196, 16);
            itemDescTB.TabIndex = 34;
            itemDescTB.TextChanged += itemDescTB_TextChanged;
            // 
            // itemCodeTB
            // 
            itemCodeTB.BorderStyle = BorderStyle.None;
            itemCodeTB.Location = new Point(214, 362);
            itemCodeTB.Name = "itemCodeTB";
            itemCodeTB.Size = new Size(196, 16);
            itemCodeTB.TabIndex = 33;
            itemCodeTB.TextChanged += itemCodeTB_TextChanged;
            // 
            // jobDescTB
            // 
            jobDescTB.BorderStyle = BorderStyle.None;
            jobDescTB.Location = new Point(221, 152);
            jobDescTB.Name = "jobDescTB";
            jobDescTB.Size = new Size(196, 16);
            jobDescTB.TabIndex = 32;
            jobDescTB.TextChanged += jobDescTB_TextChanged;
            // 
            // jobCodeTB
            // 
            jobCodeTB.BorderStyle = BorderStyle.None;
            jobCodeTB.Location = new Point(219, 89);
            jobCodeTB.Name = "jobCodeTB";
            jobCodeTB.Size = new Size(196, 16);
            jobCodeTB.TabIndex = 44;
            jobCodeTB.TextChanged += jobCodeTB_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 171, 237);
            panel2.Location = new Point(87, 567);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 1);
            panel2.TabIndex = 31;
            // 
            // btnSaveItem
            // 
            btnSaveItem.BackColor = Color.FromArgb(4, 171, 237);
            btnSaveItem.FlatAppearance.BorderSize = 0;
            btnSaveItem.FlatStyle = FlatStyle.Flat;
            btnSaveItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveItem.ForeColor = Color.White;
            btnSaveItem.Location = new Point(270, 509);
            btnSaveItem.Name = "btnSaveItem";
            btnSaveItem.Size = new Size(86, 27);
            btnSaveItem.TabIndex = 28;
            btnSaveItem.Text = "Save";
            btnSaveItem.UseVisualStyleBackColor = false;
            btnSaveItem.Click += btnSaveItem_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(4, 171, 237);
            panel12.Location = new Point(87, 302);
            panel12.Name = "panel12";
            panel12.Size = new Size(676, 1);
            panel12.TabIndex = 30;
            // 
            // btnSaveJobType
            // 
            btnSaveJobType.BackColor = Color.FromArgb(4, 171, 237);
            btnSaveJobType.FlatAppearance.BorderSize = 0;
            btnSaveJobType.FlatStyle = FlatStyle.Flat;
            btnSaveJobType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveJobType.ForeColor = Color.White;
            btnSaveJobType.Location = new Point(271, 192);
            btnSaveJobType.Name = "btnSaveJobType";
            btnSaveJobType.Size = new Size(86, 27);
            btnSaveJobType.TabIndex = 27;
            btnSaveJobType.Text = "Save";
            btnSaveJobType.UseVisualStyleBackColor = false;
            btnSaveJobType.Click += btnSaveJobType_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 18F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(4, 171, 237);
            label11.Location = new Point(216, 314);
            label11.Name = "label11";
            label11.Size = new Size(170, 29);
            label11.TabIndex = 25;
            label11.Text = "Add new Item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 171, 237);
            label5.Location = new Point(61, 412);
            label5.Name = "label5";
            label5.Size = new Size(128, 18);
            label5.TabIndex = 21;
            label5.Text = "Item Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 171, 237);
            label4.Location = new Point(61, 358);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 20;
            label4.Text = "Item Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 171, 237);
            label3.Location = new Point(68, 152);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 19;
            label3.Text = "Job Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(4, 171, 237);
            label2.Location = new Point(68, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 18;
            label2.Text = "Job Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(212, 22);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 17;
            label1.Text = "Add new Job type";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 642);
            Controls.Add(panel1);
            Controls.Add(panel11);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "settings";
            Text = "         ";
            Load += settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel10;
        private Panel panel11;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private TextBox itemDescTB;
        private TextBox itemCodeTB;
        private TextBox jobDescTB;
        private TextBox jobCodeTB;
        private Panel panel2;
        private Button btnSaveItem;
        private Panel panel12;
        private Button btnSaveJobType;
        private Label label11;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel13;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem modifyToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private RadioButton radioCapex;
        private RadioButton radioInventory;
    }
}