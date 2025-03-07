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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            RselectDate = new Button();
            saveReceiving = new Button();
            clearReceiving = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            receivingDateTB = new TextBox();
            grnumberTxtBox = new TextBox();
            itemCodeTxtBox = new TextBox();
            RitemDescTxtBox = new TextBox();
            RquantityTxtBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            issuanceDateTB = new TextBox();
            IselectDate = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            gINumberTxtBox = new TextBox();
            flowLayoutPanel8 = new FlowLayoutPanel();
            jONumberTxtBox = new TextBox();
            flowLayoutPanel9 = new FlowLayoutPanel();
            jOTypeTxtBox = new TextBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            meterNumberTxtBox = new TextBox();
            textBox1 = new TextBox();
            saveIssuance = new Button();
            clearIssuance = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RquantityTxtBox);
            groupBox1.Controls.Add(RitemDescTxtBox);
            groupBox1.Controls.Add(itemCodeTxtBox);
            groupBox1.Controls.Add(grnumberTxtBox);
            groupBox1.Controls.Add(receivingDateTB);
            groupBox1.Controls.Add(flowLayoutPanel5);
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(clearReceiving);
            groupBox1.Controls.Add(saveReceiving);
            groupBox1.Controls.Add(RselectDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox1.Location = new Point(6, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 576);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "RECEIVING";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(meterNumberTxtBox);
            groupBox2.Controls.Add(jOTypeTxtBox);
            groupBox2.Controls.Add(jONumberTxtBox);
            groupBox2.Controls.Add(gINumberTxtBox);
            groupBox2.Controls.Add(issuanceDateTB);
            groupBox2.Controls.Add(clearIssuance);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(saveIssuance);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(flowLayoutPanel10);
            groupBox2.Controls.Add(flowLayoutPanel9);
            groupBox2.Controls.Add(flowLayoutPanel8);
            groupBox2.Controls.Add(flowLayoutPanel7);
            groupBox2.Controls.Add(flowLayoutPanel6);
            groupBox2.Controls.Add(IselectDate);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox2.Location = new Point(288, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 576);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ISSUANCE";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox3.Location = new Point(569, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 576);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "STOCK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 116);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "GR number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 171);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Item Code:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 228);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 0;
            label5.Text = "Item Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 286);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 0;
            label6.Text = "Quantity:";
            // 
            // RselectDate
            // 
            RselectDate.BackColor = Color.FromArgb(4, 171, 237);
            RselectDate.FlatStyle = FlatStyle.Flat;
            RselectDate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RselectDate.ForeColor = Color.White;
            RselectDate.Location = new Point(79, 86);
            RselectDate.Name = "RselectDate";
            RselectDate.Size = new Size(95, 27);
            RselectDate.TabIndex = 1;
            RselectDate.Text = "Select Date";
            RselectDate.UseVisualStyleBackColor = false;
            // 
            // saveReceiving
            // 
            saveReceiving.BackColor = Color.FromArgb(4, 171, 237);
            saveReceiving.FlatStyle = FlatStyle.Flat;
            saveReceiving.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveReceiving.ForeColor = Color.White;
            saveReceiving.Location = new Point(85, 446);
            saveReceiving.Name = "saveReceiving";
            saveReceiving.Size = new Size(89, 36);
            saveReceiving.TabIndex = 2;
            saveReceiving.Text = "Save";
            saveReceiving.UseVisualStyleBackColor = false;
            // 
            // clearReceiving
            // 
            clearReceiving.FlatAppearance.BorderSize = 0;
            clearReceiving.FlatStyle = FlatStyle.Flat;
            clearReceiving.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearReceiving.Location = new Point(180, 425);
            clearReceiving.Name = "clearReceiving";
            clearReceiving.Size = new Size(75, 23);
            clearReceiving.TabIndex = 3;
            clearReceiving.Text = "Clear";
            clearReceiving.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel1.Location = new Point(32, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(203, 1);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel2.Location = new Point(32, 167);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(203, 1);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel3.Location = new Point(32, 220);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(203, 1);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel4.Location = new Point(32, 281);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(203, 1);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel5.Location = new Point(32, 338);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(203, 1);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // receivingDateTB
            // 
            receivingDateTB.BorderStyle = BorderStyle.None;
            receivingDateTB.Cursor = Cursors.IBeam;
            receivingDateTB.Location = new Point(32, 51);
            receivingDateTB.Name = "receivingDateTB";
            receivingDateTB.Size = new Size(203, 28);
            receivingDateTB.TabIndex = 4;
            // 
            // grnumberTxtBox
            // 
            grnumberTxtBox.BorderStyle = BorderStyle.None;
            grnumberTxtBox.Cursor = Cursors.IBeam;
            grnumberTxtBox.Location = new Point(32, 139);
            grnumberTxtBox.Name = "grnumberTxtBox";
            grnumberTxtBox.Size = new Size(203, 28);
            grnumberTxtBox.TabIndex = 4;
            // 
            // itemCodeTxtBox
            // 
            itemCodeTxtBox.BorderStyle = BorderStyle.None;
            itemCodeTxtBox.Cursor = Cursors.IBeam;
            itemCodeTxtBox.Location = new Point(32, 192);
            itemCodeTxtBox.Name = "itemCodeTxtBox";
            itemCodeTxtBox.Size = new Size(203, 28);
            itemCodeTxtBox.TabIndex = 4;
            // 
            // RitemDescTxtBox
            // 
            RitemDescTxtBox.BorderStyle = BorderStyle.None;
            RitemDescTxtBox.Cursor = Cursors.IBeam;
            RitemDescTxtBox.Location = new Point(32, 251);
            RitemDescTxtBox.Name = "RitemDescTxtBox";
            RitemDescTxtBox.Size = new Size(203, 28);
            RitemDescTxtBox.TabIndex = 4;
            // 
            // RquantityTxtBox
            // 
            RquantityTxtBox.BorderStyle = BorderStyle.None;
            RquantityTxtBox.Cursor = Cursors.IBeam;
            RquantityTxtBox.Location = new Point(32, 308);
            RquantityTxtBox.Name = "RquantityTxtBox";
            RquantityTxtBox.Size = new Size(203, 28);
            RquantityTxtBox.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 31);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 116);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 0;
            label8.Text = "G.I Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 171);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 0;
            label9.Text = "J.O Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 228);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 0;
            label10.Text = "J.O Type:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 286);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 0;
            label11.Text = "Meter Number:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 339);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 0;
            label12.Text = "Remarks:";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel6.Location = new Point(42, 79);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(203, 1);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // issuanceDateTB
            // 
            issuanceDateTB.BorderStyle = BorderStyle.None;
            issuanceDateTB.Cursor = Cursors.IBeam;
            issuanceDateTB.Location = new Point(42, 51);
            issuanceDateTB.Name = "issuanceDateTB";
            issuanceDateTB.Size = new Size(203, 28);
            issuanceDateTB.TabIndex = 4;
            // 
            // IselectDate
            // 
            IselectDate.BackColor = Color.FromArgb(4, 171, 237);
            IselectDate.FlatStyle = FlatStyle.Flat;
            IselectDate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IselectDate.ForeColor = Color.White;
            IselectDate.Location = new Point(90, 86);
            IselectDate.Name = "IselectDate";
            IselectDate.Size = new Size(95, 27);
            IselectDate.TabIndex = 1;
            IselectDate.Text = "Select Date";
            IselectDate.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel7.Location = new Point(42, 166);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(203, 1);
            flowLayoutPanel7.TabIndex = 0;
            // 
            // gINumberTxtBox
            // 
            gINumberTxtBox.BorderStyle = BorderStyle.None;
            gINumberTxtBox.Cursor = Cursors.IBeam;
            gINumberTxtBox.Location = new Point(42, 138);
            gINumberTxtBox.Name = "gINumberTxtBox";
            gINumberTxtBox.Size = new Size(203, 28);
            gINumberTxtBox.TabIndex = 4;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel8.Location = new Point(42, 219);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(203, 1);
            flowLayoutPanel8.TabIndex = 0;
            // 
            // jONumberTxtBox
            // 
            jONumberTxtBox.BorderStyle = BorderStyle.None;
            jONumberTxtBox.Cursor = Cursors.IBeam;
            jONumberTxtBox.Location = new Point(42, 191);
            jONumberTxtBox.Name = "jONumberTxtBox";
            jONumberTxtBox.Size = new Size(203, 28);
            jONumberTxtBox.TabIndex = 4;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel9.Location = new Point(42, 278);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(203, 1);
            flowLayoutPanel9.TabIndex = 0;
            // 
            // jOTypeTxtBox
            // 
            jOTypeTxtBox.BorderStyle = BorderStyle.None;
            jOTypeTxtBox.Cursor = Cursors.IBeam;
            jOTypeTxtBox.Location = new Point(42, 250);
            jOTypeTxtBox.Name = "jOTypeTxtBox";
            jOTypeTxtBox.Size = new Size(203, 28);
            jOTypeTxtBox.TabIndex = 4;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BackColor = Color.FromArgb(4, 171, 237);
            flowLayoutPanel10.Location = new Point(42, 335);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(203, 1);
            flowLayoutPanel10.TabIndex = 0;
            // 
            // meterNumberTxtBox
            // 
            meterNumberTxtBox.BorderStyle = BorderStyle.None;
            meterNumberTxtBox.Cursor = Cursors.IBeam;
            meterNumberTxtBox.Location = new Point(42, 307);
            meterNumberTxtBox.Name = "meterNumberTxtBox";
            meterNumberTxtBox.Size = new Size(203, 28);
            meterNumberTxtBox.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(20, 364);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 50);
            textBox1.TabIndex = 5;
            // 
            // saveIssuance
            // 
            saveIssuance.BackColor = Color.FromArgb(4, 171, 237);
            saveIssuance.FlatStyle = FlatStyle.Flat;
            saveIssuance.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveIssuance.ForeColor = Color.White;
            saveIssuance.Location = new Point(74, 534);
            saveIssuance.Name = "saveIssuance";
            saveIssuance.Size = new Size(89, 36);
            saveIssuance.TabIndex = 2;
            saveIssuance.Text = "Save";
            saveIssuance.UseVisualStyleBackColor = false;
            // 
            // clearIssuance
            // 
            clearIssuance.FlatAppearance.BorderSize = 0;
            clearIssuance.FlatStyle = FlatStyle.Flat;
            clearIssuance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearIssuance.Location = new Point(169, 513);
            clearIssuance.Name = "clearIssuance";
            clearIssuance.Size = new Size(75, 23);
            clearIssuance.TabIndex = 3;
            clearIssuance.Text = "Clear";
            clearIssuance.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(6, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(250, 536);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.DividerWidth = 1;
            Column1.HeaderText = "item code";
            Column1.Name = "Column1";
            Column1.Width = 136;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "item description";
            Column2.Name = "Column2";
            Column2.Width = 198;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "quantity";
            Column3.Name = "Column3";
            Column3.Width = 121;
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 642);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventory";
            Text = "inventory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button RselectDate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button clearReceiving;
        private Button saveReceiving;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox receivingDateTB;
        private TextBox RquantityTxtBox;
        private TextBox RitemDescTxtBox;
        private TextBox itemCodeTxtBox;
        private TextBox grnumberTxtBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox issuanceDateTB;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button IselectDate;
        private TextBox textBox1;
        private TextBox meterNumberTxtBox;
        private TextBox jOTypeTxtBox;
        private TextBox jONumberTxtBox;
        private TextBox gINumberTxtBox;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button clearIssuance;
        private Button saveIssuance;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}