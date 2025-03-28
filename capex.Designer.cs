namespace Primewater
{
    partial class capex
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
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewCapexStock = new DataGridView();
            btnStockReset = new Button();
            btnStockSearch = new Button();
            panel13 = new Panel();
            searchStockTextBox = new TextBox();
            label13 = new Label();
            groupBox2 = new GroupBox();
            jobOrderTypeComboBox = new ComboBox();
            issuanceDatePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addItemToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            remarksTextBox = new TextBox();
            btnClearCapexIssuance = new Button();
            button6 = new Button();
            label12 = new Label();
            panel12 = new Panel();
            label7 = new Label();
            meterNumberTextBox = new TextBox();
            IssuedByTextBox = new TextBox();
            requestedByTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            groupBox1 = new GroupBox();
            receivingItemCodeComboBox = new ComboBox();
            receivingDatePicker = new DateTimePicker();
            receivingQuantityTextBox = new TextBox();
            receivingItemDescriptionTextBox = new TextBox();
            grnumberTextBox = new TextBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            receivingClearBtn = new Button();
            receivingSaveBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            modifyToolStripMenuItem1 = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCapexStock).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
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
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewCapexStock);
            groupBox3.Controls.Add(btnStockReset);
            groupBox3.Controls.Add(btnStockSearch);
            groupBox3.Controls.Add(panel13);
            groupBox3.Controls.Add(searchStockTextBox);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox3.Location = new Point(12, 778);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(806, 335);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stock";
            // 
            // dataGridViewCapexStock
            // 
            dataGridViewCapexStock.AllowUserToResizeRows = false;
            dataGridViewCapexStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCapexStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCapexStock.ContextMenuStrip = contextMenuStrip2;
            dataGridViewCapexStock.Location = new Point(19, 32);
            dataGridViewCapexStock.Name = "dataGridViewCapexStock";
            dataGridViewCapexStock.RowHeadersVisible = false;
            dataGridViewCapexStock.Size = new Size(541, 291);
            dataGridViewCapexStock.TabIndex = 8;
            // 
            // btnStockReset
            // 
            btnStockReset.BackColor = Color.FromArgb(49, 77, 140);
            btnStockReset.FlatAppearance.BorderSize = 0;
            btnStockReset.FlatStyle = FlatStyle.Flat;
            btnStockReset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockReset.ForeColor = Color.White;
            btnStockReset.Location = new Point(716, 91);
            btnStockReset.Name = "btnStockReset";
            btnStockReset.Size = new Size(72, 28);
            btnStockReset.TabIndex = 6;
            btnStockReset.Text = "Reset";
            btnStockReset.UseVisualStyleBackColor = false;
            btnStockReset.Click += btnStockReset_Click_1;
            // 
            // btnStockSearch
            // 
            btnStockSearch.BackColor = Color.FromArgb(4, 171, 237);
            btnStockSearch.FlatAppearance.BorderSize = 0;
            btnStockSearch.FlatStyle = FlatStyle.Flat;
            btnStockSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockSearch.ForeColor = Color.White;
            btnStockSearch.Location = new Point(588, 91);
            btnStockSearch.Name = "btnStockSearch";
            btnStockSearch.Size = new Size(72, 28);
            btnStockSearch.TabIndex = 7;
            btnStockSearch.Text = "Search";
            btnStockSearch.UseVisualStyleBackColor = false;
            btnStockSearch.Click += btnStockSearch_Click_1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(4, 171, 237);
            panel13.Location = new Point(588, 75);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 1);
            panel13.TabIndex = 9;
            // 
            // searchStockTextBox
            // 
            searchStockTextBox.BorderStyle = BorderStyle.None;
            searchStockTextBox.Cursor = Cursors.IBeam;
            searchStockTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchStockTextBox.Location = new Point(588, 58);
            searchStockTextBox.Name = "searchStockTextBox";
            searchStockTextBox.Size = new Size(200, 15);
            searchStockTextBox.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(653, 29);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 5;
            label13.Text = "Search:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(jobOrderTypeComboBox);
            groupBox2.Controls.Add(issuanceDatePicker);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(remarksTextBox);
            groupBox2.Controls.Add(btnClearCapexIssuance);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(panel12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(meterNumberTextBox);
            groupBox2.Controls.Add(IssuedByTextBox);
            groupBox2.Controls.Add(requestedByTextBox);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(panel11);
            groupBox2.Controls.Add(panel10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(panel9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(panel8);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox2.Location = new Point(12, 420);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(806, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issuance";
            // 
            // jobOrderTypeComboBox
            // 
            jobOrderTypeComboBox.FormattingEnabled = true;
            jobOrderTypeComboBox.Location = new Point(154, 201);
            jobOrderTypeComboBox.Name = "jobOrderTypeComboBox";
            jobOrderTypeComboBox.Size = new Size(200, 33);
            jobOrderTypeComboBox.TabIndex = 24;
            jobOrderTypeComboBox.SelectedIndexChanged += receivingItemCodeComboBox_SelectedIndexChanged_1;
            // 
            // issuanceDatePicker
            // 
            issuanceDatePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issuanceDatePicker.Format = DateTimePickerFormat.Short;
            issuanceDatePicker.Location = new Point(154, 42);
            issuanceDatePicker.Name = "issuanceDatePicker";
            issuanceDatePicker.Size = new Size(206, 27);
            issuanceDatePicker.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(381, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(299, 188);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, removeToolStripMenuItem, modifyToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(124, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(123, 22);
            addItemToolStripMenuItem.Text = "Add item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(123, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(123, 22);
            modifyToolStripMenuItem.Text = "Modify";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // remarksTextBox
            // 
            remarksTextBox.BorderStyle = BorderStyle.FixedSingle;
            remarksTextBox.Cursor = Cursors.IBeam;
            remarksTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remarksTextBox.Location = new Point(403, 50);
            remarksTextBox.Multiline = true;
            remarksTextBox.Name = "remarksTextBox";
            remarksTextBox.Size = new Size(257, 60);
            remarksTextBox.TabIndex = 30;
            // 
            // btnClearCapexIssuance
            // 
            btnClearCapexIssuance.BackColor = Color.FromArgb(49, 77, 140);
            btnClearCapexIssuance.FlatAppearance.BorderSize = 0;
            btnClearCapexIssuance.FlatStyle = FlatStyle.Flat;
            btnClearCapexIssuance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCapexIssuance.ForeColor = Color.White;
            btnClearCapexIssuance.Location = new Point(707, 211);
            btnClearCapexIssuance.Name = "btnClearCapexIssuance";
            btnClearCapexIssuance.Size = new Size(72, 28);
            btnClearCapexIssuance.TabIndex = 27;
            btnClearCapexIssuance.Text = "Clear";
            btnClearCapexIssuance.UseVisualStyleBackColor = false;
            btnClearCapexIssuance.Click += btnClearCapexIssuance_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(4, 171, 237);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(707, 177);
            button6.Name = "button6";
            button6.Size = new Size(72, 28);
            button6.TabIndex = 28;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(493, 24);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 25;
            label12.Text = "Remarks";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(4, 171, 237);
            panel12.Location = new Point(404, 110);
            panel12.Name = "panel12";
            panel12.Size = new Size(256, 1);
            panel12.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 31);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Date:";
            // 
            // meterNumberTextBox
            // 
            meterNumberTextBox.BorderStyle = BorderStyle.None;
            meterNumberTextBox.Cursor = Cursors.IBeam;
            meterNumberTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meterNumberTextBox.Location = new Point(154, 266);
            meterNumberTextBox.Name = "meterNumberTextBox";
            meterNumberTextBox.Size = new Size(200, 15);
            meterNumberTextBox.TabIndex = 22;
            // 
            // IssuedByTextBox
            // 
            IssuedByTextBox.BorderStyle = BorderStyle.None;
            IssuedByTextBox.Cursor = Cursors.IBeam;
            IssuedByTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IssuedByTextBox.Location = new Point(154, 164);
            IssuedByTextBox.Name = "IssuedByTextBox";
            IssuedByTextBox.Size = new Size(200, 15);
            IssuedByTextBox.TabIndex = 20;
            // 
            // requestedByTextBox
            // 
            requestedByTextBox.BorderStyle = BorderStyle.None;
            requestedByTextBox.Cursor = Cursors.IBeam;
            requestedByTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestedByTextBox.Location = new Point(154, 105);
            requestedByTextBox.Name = "requestedByTextBox";
            requestedByTextBox.Size = new Size(200, 15);
            requestedByTextBox.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 264);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 10;
            label11.Text = "Meter Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 211);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 11;
            label10.Text = "J.O Type:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(4, 171, 237);
            panel11.Location = new Point(154, 283);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 1);
            panel11.TabIndex = 18;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(4, 171, 237);
            panel10.Location = new Point(154, 234);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 1);
            panel10.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 158);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 7;
            label9.Text = "Issued By:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(4, 171, 237);
            panel9.Location = new Point(154, 181);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 1);
            panel9.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 99);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 9;
            label8.Text = "Requested By:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(4, 171, 237);
            panel8.Location = new Point(154, 122);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 1);
            panel8.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(receivingItemCodeComboBox);
            groupBox1.Controls.Add(receivingDatePicker);
            groupBox1.Controls.Add(receivingQuantityTextBox);
            groupBox1.Controls.Add(receivingItemDescriptionTextBox);
            groupBox1.Controls.Add(grnumberTextBox);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(receivingClearBtn);
            groupBox1.Controls.Add(receivingSaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 335);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receiving";
            // 
            // receivingItemCodeComboBox
            // 
            receivingItemCodeComboBox.FormattingEnabled = true;
            receivingItemCodeComboBox.Location = new Point(160, 150);
            receivingItemCodeComboBox.Name = "receivingItemCodeComboBox";
            receivingItemCodeComboBox.Size = new Size(200, 33);
            receivingItemCodeComboBox.TabIndex = 24;
            receivingItemCodeComboBox.SelectedIndexChanged += receivingItemCodeComboBox_SelectedIndexChanged_1;
            // 
            // receivingDatePicker
            // 
            receivingDatePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receivingDatePicker.Format = DateTimePickerFormat.Short;
            receivingDatePicker.Location = new Point(160, 41);
            receivingDatePicker.Name = "receivingDatePicker";
            receivingDatePicker.Size = new Size(200, 27);
            receivingDatePicker.TabIndex = 23;
            // 
            // receivingQuantityTextBox
            // 
            receivingQuantityTextBox.BorderStyle = BorderStyle.None;
            receivingQuantityTextBox.Cursor = Cursors.IBeam;
            receivingQuantityTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receivingQuantityTextBox.Location = new Point(160, 275);
            receivingQuantityTextBox.Name = "receivingQuantityTextBox";
            receivingQuantityTextBox.Size = new Size(200, 15);
            receivingQuantityTextBox.TabIndex = 22;
            // 
            // receivingItemDescriptionTextBox
            // 
            receivingItemDescriptionTextBox.BorderStyle = BorderStyle.None;
            receivingItemDescriptionTextBox.Cursor = Cursors.IBeam;
            receivingItemDescriptionTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receivingItemDescriptionTextBox.Location = new Point(160, 221);
            receivingItemDescriptionTextBox.Name = "receivingItemDescriptionTextBox";
            receivingItemDescriptionTextBox.Size = new Size(200, 15);
            receivingItemDescriptionTextBox.TabIndex = 21;
            // 
            // grnumberTextBox
            // 
            grnumberTextBox.BorderStyle = BorderStyle.None;
            grnumberTextBox.Cursor = Cursors.IBeam;
            grnumberTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnumberTextBox.Location = new Point(160, 118);
            grnumberTextBox.Name = "grnumberTextBox";
            grnumberTextBox.Size = new Size(200, 15);
            grnumberTextBox.TabIndex = 19;
            grnumberTextBox.TextChanged += grnumberTextBox_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(4, 171, 237);
            panel6.Location = new Point(160, 292);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 1);
            panel6.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(4, 171, 237);
            panel5.Location = new Point(160, 238);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 1);
            panel5.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(4, 171, 237);
            panel4.Location = new Point(160, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 171, 237);
            panel3.Location = new Point(160, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 14;
            // 
            // receivingClearBtn
            // 
            receivingClearBtn.BackColor = Color.FromArgb(49, 77, 140);
            receivingClearBtn.FlatAppearance.BorderSize = 0;
            receivingClearBtn.FlatStyle = FlatStyle.Flat;
            receivingClearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receivingClearBtn.ForeColor = Color.White;
            receivingClearBtn.Location = new Point(673, 135);
            receivingClearBtn.Name = "receivingClearBtn";
            receivingClearBtn.Size = new Size(72, 28);
            receivingClearBtn.TabIndex = 12;
            receivingClearBtn.Text = "Clear";
            receivingClearBtn.UseVisualStyleBackColor = false;
            receivingClearBtn.Click += receivingClearBtn_Click;
            // 
            // receivingSaveBtn
            // 
            receivingSaveBtn.BackColor = Color.FromArgb(4, 171, 237);
            receivingSaveBtn.FlatAppearance.BorderSize = 0;
            receivingSaveBtn.FlatStyle = FlatStyle.Flat;
            receivingSaveBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            receivingSaveBtn.ForeColor = Color.White;
            receivingSaveBtn.Location = new Point(488, 135);
            receivingSaveBtn.Name = "receivingSaveBtn";
            receivingSaveBtn.Size = new Size(72, 28);
            receivingSaveBtn.TabIndex = 11;
            receivingSaveBtn.Text = "Save";
            receivingSaveBtn.UseVisualStyleBackColor = false;
            receivingSaveBtn.Click += receivingSaveBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 273);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 8;
            label6.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 219);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 7;
            label5.Text = "Item Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 164);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Item Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 112);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 9;
            label3.Text = "G.R Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 41);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 0;
            label1.Text = "Capex";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { modifyToolStripMenuItem1, removeToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 70);
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // modifyToolStripMenuItem1
            // 
            modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            modifyToolStripMenuItem1.Size = new Size(180, 22);
            modifyToolStripMenuItem1.Text = "Modify";
            modifyToolStripMenuItem1.Click += modifyToolStripMenuItem1_Click;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(180, 22);
            removeToolStripMenuItem1.Text = "Remove";
            removeToolStripMenuItem1.Click += removeToolStripMenuItem1_Click;
            // 
            // capex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 642);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "capex";
            Text = "capex";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCapexStock).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox receivingQuantityTextBox;
        private TextBox receivingItemDescriptionTextBox;
        private TextBox grnumberTextBox;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button receivingClearBtn;
        private Button receivingSaveBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox IssuedByTextBox;
        private TextBox requestedByTextBox;
        private Label label11;
        private Label label10;
        private Panel panel10;
        private Label label9;
        private Panel panel9;
        private Label label8;
        private Panel panel8;
        private DataGridView dataGridViewCapexStock;
        private Button btnStockReset;
        private Button btnStockSearch;
        private Panel panel13;
        private TextBox searchStockTextBox;
        private Label label13;
        private TextBox meterNumberTextBox;
        private Panel panel11;
        private DataGridView dataGridView1;
        private TextBox remarksTextBox;
        private Button btnClearCapexIssuance;
        private Button button6;
        private Label label12;
        private Panel panel12;
        private DateTimePicker receivingDatePicker;
        private DateTimePicker issuanceDatePicker;
        private ComboBox receivingItemCodeComboBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ComboBox jobOrderTypeComboBox;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem modifyToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
    }
}