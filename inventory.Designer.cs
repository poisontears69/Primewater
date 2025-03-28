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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridViewStock = new DataGridView();
            btnResetStock = new Button();
            btnSearchStock = new Button();
            panel13 = new Panel();
            searchTextBox = new TextBox();
            label13 = new Label();
            groupBox2 = new GroupBox();
            joTypeComboBox = new ComboBox();
            IssuanceDateTimePicker = new DateTimePicker();
            dataGridViewIssuance = new DataGridView();
            contextMenuStripIssuance = new ContextMenuStrip(components);
            addItemToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            remarksTextBox = new TextBox();
            issuanceBtnClear = new Button();
            issuanceBtnSave = new Button();
            label12 = new Label();
            panel12 = new Panel();
            label7 = new Label();
            meterNumber = new TextBox();
            textBox9 = new TextBox();
            joNumber = new TextBox();
            giNumber = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            groupBox1 = new GroupBox();
            inventoryItemCode = new ComboBox();
            inventoryDateTimePicker = new DateTimePicker();
            quantityTextBox = new TextBox();
            itemDescriptionTextBox = new TextBox();
            grNumberTextBox = new TextBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            clearBtnReceiving = new Button();
            saveBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuance).BeginInit();
            contextMenuStripIssuance.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 603);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 171, 237);
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 33;
            label1.Text = "Inventory";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewStock);
            groupBox3.Controls.Add(btnResetStock);
            groupBox3.Controls.Add(btnSearchStock);
            groupBox3.Controls.Add(panel13);
            groupBox3.Controls.Add(searchTextBox);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox3.Location = new Point(9, 736);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(806, 335);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stock";
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(19, 32);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.RowHeadersVisible = false;
            dataGridViewStock.Size = new Size(541, 291);
            dataGridViewStock.TabIndex = 8;
            // 
            // btnResetStock
            // 
            btnResetStock.BackColor = Color.FromArgb(49, 77, 140);
            btnResetStock.FlatAppearance.BorderSize = 0;
            btnResetStock.FlatStyle = FlatStyle.Flat;
            btnResetStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetStock.ForeColor = Color.White;
            btnResetStock.Location = new Point(716, 91);
            btnResetStock.Name = "btnResetStock";
            btnResetStock.Size = new Size(72, 28);
            btnResetStock.TabIndex = 6;
            btnResetStock.Text = "Reset";
            btnResetStock.UseVisualStyleBackColor = false;
            btnResetStock.Click += btnResetStock_Click;
            // 
            // btnSearchStock
            // 
            btnSearchStock.BackColor = Color.FromArgb(4, 171, 237);
            btnSearchStock.FlatAppearance.BorderSize = 0;
            btnSearchStock.FlatStyle = FlatStyle.Flat;
            btnSearchStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStock.ForeColor = Color.White;
            btnSearchStock.Location = new Point(588, 91);
            btnSearchStock.Name = "btnSearchStock";
            btnSearchStock.Size = new Size(72, 28);
            btnSearchStock.TabIndex = 7;
            btnSearchStock.Text = "Search";
            btnSearchStock.UseVisualStyleBackColor = false;
            btnSearchStock.Click += btnSearchStock_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(4, 171, 237);
            panel13.Location = new Point(588, 75);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 1);
            panel13.TabIndex = 9;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Cursor = Cursors.IBeam;
            searchTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(588, 58);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(200, 15);
            searchTextBox.TabIndex = 10;
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
            groupBox2.Controls.Add(joTypeComboBox);
            groupBox2.Controls.Add(IssuanceDateTimePicker);
            groupBox2.Controls.Add(dataGridViewIssuance);
            groupBox2.Controls.Add(remarksTextBox);
            groupBox2.Controls.Add(issuanceBtnClear);
            groupBox2.Controls.Add(issuanceBtnSave);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(panel12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(meterNumber);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(joNumber);
            groupBox2.Controls.Add(giNumber);
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
            groupBox2.Location = new Point(8, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(806, 335);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issuance";
            // 
            // joTypeComboBox
            // 
            joTypeComboBox.FormattingEnabled = true;
            joTypeComboBox.Location = new Point(154, 201);
            joTypeComboBox.Name = "joTypeComboBox";
            joTypeComboBox.Size = new Size(200, 33);
            joTypeComboBox.TabIndex = 25;
            // 
            // IssuanceDateTimePicker
            // 
            IssuanceDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IssuanceDateTimePicker.Format = DateTimePickerFormat.Short;
            IssuanceDateTimePicker.Location = new Point(154, 42);
            IssuanceDateTimePicker.Name = "IssuanceDateTimePicker";
            IssuanceDateTimePicker.Size = new Size(207, 27);
            IssuanceDateTimePicker.TabIndex = 23;
            // 
            // dataGridViewIssuance
            // 
            dataGridViewIssuance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIssuance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIssuance.ContextMenuStrip = contextMenuStripIssuance;
            dataGridViewIssuance.Location = new Point(381, 121);
            dataGridViewIssuance.Name = "dataGridViewIssuance";
            dataGridViewIssuance.RowHeadersVisible = false;
            dataGridViewIssuance.Size = new Size(299, 188);
            dataGridViewIssuance.TabIndex = 31;
            dataGridViewIssuance.CellContentClick += dataGridViewIssuance_CellContentClick;
            // 
            // contextMenuStripIssuance
            // 
            contextMenuStripIssuance.Items.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, modifyToolStripMenuItem, removeToolStripMenuItem });
            contextMenuStripIssuance.Name = "contextMenuStripIssuance";
            contextMenuStripIssuance.Size = new Size(124, 70);
            contextMenuStripIssuance.Opening += contextMenuStripIssuance_Opening;
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(123, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(123, 22);
            modifyToolStripMenuItem.Text = "Modify";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(123, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
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
            // issuanceBtnClear
            // 
            issuanceBtnClear.BackColor = Color.FromArgb(49, 77, 140);
            issuanceBtnClear.FlatAppearance.BorderSize = 0;
            issuanceBtnClear.FlatStyle = FlatStyle.Flat;
            issuanceBtnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issuanceBtnClear.ForeColor = Color.White;
            issuanceBtnClear.Location = new Point(707, 211);
            issuanceBtnClear.Name = "issuanceBtnClear";
            issuanceBtnClear.Size = new Size(72, 28);
            issuanceBtnClear.TabIndex = 27;
            issuanceBtnClear.Text = "Clear";
            issuanceBtnClear.UseVisualStyleBackColor = false;
            issuanceBtnClear.Click += issuanceBtnClear_Click;
            // 
            // issuanceBtnSave
            // 
            issuanceBtnSave.BackColor = Color.FromArgb(4, 171, 237);
            issuanceBtnSave.FlatAppearance.BorderSize = 0;
            issuanceBtnSave.FlatStyle = FlatStyle.Flat;
            issuanceBtnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issuanceBtnSave.ForeColor = Color.White;
            issuanceBtnSave.Location = new Point(707, 177);
            issuanceBtnSave.Name = "issuanceBtnSave";
            issuanceBtnSave.Size = new Size(72, 28);
            issuanceBtnSave.TabIndex = 28;
            issuanceBtnSave.Text = "Save";
            issuanceBtnSave.UseVisualStyleBackColor = false;
            issuanceBtnSave.Click += issuanceBtnSave_Click;
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
            // meterNumber
            // 
            meterNumber.BorderStyle = BorderStyle.None;
            meterNumber.Cursor = Cursors.IBeam;
            meterNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meterNumber.Location = new Point(154, 266);
            meterNumber.Name = "meterNumber";
            meterNumber.Size = new Size(200, 15);
            meterNumber.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Cursor = Cursors.IBeam;
            textBox9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(154, 217);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 15);
            textBox9.TabIndex = 22;
            // 
            // joNumber
            // 
            joNumber.BorderStyle = BorderStyle.None;
            joNumber.Cursor = Cursors.IBeam;
            joNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            joNumber.Location = new Point(154, 164);
            joNumber.Name = "joNumber";
            joNumber.Size = new Size(200, 15);
            joNumber.TabIndex = 20;
            // 
            // giNumber
            // 
            giNumber.BorderStyle = BorderStyle.None;
            giNumber.Cursor = Cursors.IBeam;
            giNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            giNumber.Location = new Point(154, 105);
            giNumber.Name = "giNumber";
            giNumber.Size = new Size(200, 15);
            giNumber.TabIndex = 19;
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
            label9.Size = new Size(94, 20);
            label9.TabIndex = 7;
            label9.Text = "JO Number:";
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
            label8.Size = new Size(92, 20);
            label8.TabIndex = 9;
            label8.Text = "GI Number:";
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
            groupBox1.Controls.Add(inventoryItemCode);
            groupBox1.Controls.Add(inventoryDateTimePicker);
            groupBox1.Controls.Add(quantityTextBox);
            groupBox1.Controls.Add(itemDescriptionTextBox);
            groupBox1.Controls.Add(grNumberTextBox);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(clearBtnReceiving);
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(4, 171, 237);
            groupBox1.Location = new Point(9, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 335);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receiving";
            // 
            // inventoryItemCode
            // 
            inventoryItemCode.FormattingEnabled = true;
            inventoryItemCode.Location = new Point(160, 150);
            inventoryItemCode.Name = "inventoryItemCode";
            inventoryItemCode.Size = new Size(200, 33);
            inventoryItemCode.TabIndex = 25;
            // 
            // inventoryDateTimePicker
            // 
            inventoryDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryDateTimePicker.Format = DateTimePickerFormat.Short;
            inventoryDateTimePicker.Location = new Point(160, 41);
            inventoryDateTimePicker.Name = "inventoryDateTimePicker";
            inventoryDateTimePicker.Size = new Size(200, 27);
            inventoryDateTimePicker.TabIndex = 23;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BorderStyle = BorderStyle.None;
            quantityTextBox.Cursor = Cursors.IBeam;
            quantityTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityTextBox.Location = new Point(160, 275);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(200, 15);
            quantityTextBox.TabIndex = 22;
            // 
            // itemDescriptionTextBox
            // 
            itemDescriptionTextBox.BorderStyle = BorderStyle.None;
            itemDescriptionTextBox.Cursor = Cursors.IBeam;
            itemDescriptionTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDescriptionTextBox.Location = new Point(160, 221);
            itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            itemDescriptionTextBox.Size = new Size(200, 15);
            itemDescriptionTextBox.TabIndex = 21;
            // 
            // grNumberTextBox
            // 
            grNumberTextBox.BorderStyle = BorderStyle.None;
            grNumberTextBox.Cursor = Cursors.IBeam;
            grNumberTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grNumberTextBox.Location = new Point(160, 118);
            grNumberTextBox.Name = "grNumberTextBox";
            grNumberTextBox.Size = new Size(200, 15);
            grNumberTextBox.TabIndex = 19;
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
            // clearBtnReceiving
            // 
            clearBtnReceiving.BackColor = Color.FromArgb(49, 77, 140);
            clearBtnReceiving.FlatAppearance.BorderSize = 0;
            clearBtnReceiving.FlatStyle = FlatStyle.Flat;
            clearBtnReceiving.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtnReceiving.ForeColor = Color.White;
            clearBtnReceiving.Location = new Point(673, 135);
            clearBtnReceiving.Name = "clearBtnReceiving";
            clearBtnReceiving.Size = new Size(72, 28);
            clearBtnReceiving.TabIndex = 12;
            clearBtnReceiving.Text = "Clear";
            clearBtnReceiving.UseVisualStyleBackColor = false;
            clearBtnReceiving.Click += clearBtnReceiving_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(4, 171, 237);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(488, 135);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(72, 28);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += button2_Click;
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
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 603);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventory";
            Text = "inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuance).EndInit();
            contextMenuStripIssuance.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker inventoryDateTimePicker;
        private TextBox quantityTextBox;
        private TextBox itemDescriptionTextBox;
        private TextBox grNumberTextBox;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button clearBtnReceiving;
        private Button saveBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DateTimePicker IssuanceDateTimePicker;
        private DataGridView dataGridViewIssuance;
        private TextBox remarksTextBox;
        private Button issuanceBtnClear;
        private Button issuanceBtnSave;
        private Label label12;
        private Panel panel12;
        private Label label7;
        private TextBox meterNumber;
        private TextBox textBox9;
        private TextBox joNumber;
        private TextBox giNumber;
        private Label label11;
        private Label label10;
        private Panel panel11;
        private Panel panel10;
        private Label label9;
        private Panel panel9;
        private Label label8;
        private Panel panel8;
        private GroupBox groupBox3;
        private DataGridView dataGridViewStock;
        private Button btnResetStock;
        private Button btnSearchStock;
        private Panel panel13;
        private TextBox searchTextBox;
        private Label label13;
        private Label label1;
        private ComboBox joTypeComboBox;
        private ComboBox inventoryItemCode;
        private ContextMenuStrip contextMenuStripIssuance;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}