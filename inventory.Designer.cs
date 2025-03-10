namespace Primewater
{
    partial class inventory
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 642);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receiving";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox2.Location = new Point(12, 428);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(806, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issuance";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox3.Location = new Point(12, 786);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(806, 335);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stock";
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 642);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventory";
            Text = "inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
    }
}