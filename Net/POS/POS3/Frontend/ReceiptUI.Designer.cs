namespace POS3
{
    partial class ReceiptUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.vId = new System.Windows.Forms.TextBox();
            this.vSupplierId = new System.Windows.Forms.TextBox();
            this.vSupplierName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vIsDiscount = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vList = new System.Windows.Forms.DataGridView();
            this.cReciptItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvoiceCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vInvoiceId = new System.Windows.Forms.TextBox();
            this.vInvoiceType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vInvoiceTotalSellPrice = new System.Windows.Forms.TextBox();
            this.vInvoiceCreationDate = new System.Windows.Forms.TextBox();
            this.vInvoiceRemain = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vRemainAfterDiscount = new System.Windows.Forms.TextBox();
            this.vPaid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.vTotalPaid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل السند";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.vCreationDate, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.vId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.vSupplierId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.vSupplierName, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(666, 100);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "تاريخ السند";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم المورد";
            // 
            // vCreationDate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.vCreationDate, 2);
            this.vCreationDate.CustomFormat = "dd-MMM-yyyy";
            this.vCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vCreationDate.Location = new System.Drawing.Point(224, 36);
            this.vCreationDate.MaximumSize = new System.Drawing.Size(204, 20);
            this.vCreationDate.Name = "vCreationDate";
            this.vCreationDate.Size = new System.Drawing.Size(87, 20);
            this.vCreationDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "أسم المورد";
            // 
            // vId
            // 
            this.vId.Location = new System.Drawing.Point(493, 3);
            this.vId.Name = "vId";
            this.vId.Size = new System.Drawing.Size(82, 20);
            this.vId.TabIndex = 4;
            // 
            // vSupplierId
            // 
            this.vSupplierId.Location = new System.Drawing.Point(493, 36);
            this.vSupplierId.Name = "vSupplierId";
            this.vSupplierId.Size = new System.Drawing.Size(82, 20);
            this.vSupplierId.TabIndex = 5;
            // 
            // vSupplierName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.vSupplierName, 3);
            this.vSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vSupplierName.Location = new System.Drawing.Point(317, 69);
            this.vSupplierName.Name = "vSupplierName";
            this.vSupplierName.ReadOnly = true;
            this.vSupplierName.Size = new System.Drawing.Size(258, 20);
            this.vSupplierName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "خصم";
            // 
            // vIsDiscount
            // 
            this.vIsDiscount.AutoSize = true;
            this.vIsDiscount.Location = new System.Drawing.Point(514, 67);
            this.vIsDiscount.Name = "vIsDiscount";
            this.vIsDiscount.Size = new System.Drawing.Size(41, 17);
            this.vIsDiscount.TabIndex = 9;
            this.vIsDiscount.Text = "نعم";
            this.vIsDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vList);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فواتير مسددة";
            // 
            // vList
            // 
            this.vList.AllowUserToAddRows = false;
            this.vList.AllowUserToDeleteRows = false;
            this.vList.AllowUserToResizeColumns = false;
            this.vList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cReciptItemId,
            this.cInvoiceId,
            this.cProductName,
            this.cInvoiceCreationDate,
            this.cType,
            this.cIsDiscount,
            this.cDiscount,
            this.cPaid});
            this.vList.Location = new System.Drawing.Point(0, 154);
            this.vList.Name = "vList";
            this.vList.Size = new System.Drawing.Size(666, 191);
            this.vList.TabIndex = 1;
            // 
            // cReciptItemId
            // 
            this.cReciptItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cReciptItemId.HeaderText = "Column1";
            this.cReciptItemId.Name = "cReciptItemId";
            this.cReciptItemId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cReciptItemId.Visible = false;
            // 
            // cInvoiceId
            // 
            this.cInvoiceId.HeaderText = "رقم الفاتورة";
            this.cInvoiceId.Name = "cInvoiceId";
            // 
            // cProductName
            // 
            this.cProductName.HeaderText = "قيمة الفاتورة";
            this.cProductName.Name = "cProductName";
            // 
            // cInvoiceCreationDate
            // 
            this.cInvoiceCreationDate.HeaderText = "تاريخ الفاتورة";
            this.cInvoiceCreationDate.Name = "cInvoiceCreationDate";
            // 
            // cType
            // 
            this.cType.HeaderText = "نوع الفاتورة";
            this.cType.Name = "cType";
            // 
            // cIsDiscount
            // 
            this.cIsDiscount.HeaderText = "خصم";
            this.cIsDiscount.Name = "cIsDiscount";
            // 
            // cDiscount
            // 
            this.cDiscount.HeaderText = "قيمة الخصم";
            this.cDiscount.Name = "cDiscount";
            // 
            // cPaid
            // 
            this.cPaid.HeaderText = "المسدد";
            this.cPaid.Name = "cPaid";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.395802F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.48576F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.vInvoiceId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.vInvoiceType, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.vIsDiscount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.vInvoiceTotalSellPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vInvoiceCreationDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.vInvoiceRemain, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vDiscount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.vRemainAfterDiscount, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.vPaid, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.78295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.60465F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 129);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "رقم الفاتورة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "تاريخ الفاتورة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "نوع الفاتورة";
            // 
            // vInvoiceId
            // 
            this.vInvoiceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vInvoiceId.Location = new System.Drawing.Point(452, 3);
            this.vInvoiceId.Name = "vInvoiceId";
            this.vInvoiceId.ReadOnly = true;
            this.vInvoiceId.Size = new System.Drawing.Size(103, 20);
            this.vInvoiceId.TabIndex = 10;
            // 
            // vInvoiceType
            // 
            this.vInvoiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vInvoiceType.Location = new System.Drawing.Point(3, 3);
            this.vInvoiceType.Name = "vInvoiceType";
            this.vInvoiceType.ReadOnly = true;
            this.vInvoiceType.Size = new System.Drawing.Size(185, 20);
            this.vInvoiceType.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "قيمة الفاتورة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "المتبقي";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // vInvoiceTotalSellPrice
            // 
            this.vInvoiceTotalSellPrice.Location = new System.Drawing.Point(455, 35);
            this.vInvoiceTotalSellPrice.Name = "vInvoiceTotalSellPrice";
            this.vInvoiceTotalSellPrice.ReadOnly = true;
            this.vInvoiceTotalSellPrice.Size = new System.Drawing.Size(100, 20);
            this.vInvoiceTotalSellPrice.TabIndex = 23;
            // 
            // vInvoiceCreationDate
            // 
            this.vInvoiceCreationDate.Location = new System.Drawing.Point(268, 3);
            this.vInvoiceCreationDate.Name = "vInvoiceCreationDate";
            this.vInvoiceCreationDate.ReadOnly = true;
            this.vInvoiceCreationDate.Size = new System.Drawing.Size(100, 20);
            this.vInvoiceCreationDate.TabIndex = 26;
            // 
            // vInvoiceRemain
            // 
            this.vInvoiceRemain.Location = new System.Drawing.Point(268, 35);
            this.vInvoiceRemain.Name = "vInvoiceRemain";
            this.vInvoiceRemain.ReadOnly = true;
            this.vInvoiceRemain.Size = new System.Drawing.Size(100, 20);
            this.vInvoiceRemain.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "قيمة الخصم";
            // 
            // vDiscount
            // 
            this.vDiscount.Location = new System.Drawing.Point(455, 107);
            this.vDiscount.Name = "vDiscount";
            this.vDiscount.Size = new System.Drawing.Size(100, 20);
            this.vDiscount.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "المتبقي بعد الخصم";
            // 
            // vRemainAfterDiscount
            // 
            this.vRemainAfterDiscount.Location = new System.Drawing.Point(268, 67);
            this.vRemainAfterDiscount.Name = "vRemainAfterDiscount";
            this.vRemainAfterDiscount.ReadOnly = true;
            this.vRemainAfterDiscount.Size = new System.Drawing.Size(100, 20);
            this.vRemainAfterDiscount.TabIndex = 25;
            // 
            // vPaid
            // 
            this.vPaid.Location = new System.Drawing.Point(88, 67);
            this.vPaid.Name = "vPaid";
            this.vPaid.Size = new System.Drawing.Size(100, 20);
            this.vPaid.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "المسدد";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(259, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "جديد";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox2);
            this.groupBox5.Location = new System.Drawing.Point(14, 513);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 68);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "تعليمات";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(655, 49);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel4);
            this.groupBox6.Location = new System.Drawing.Point(14, 587);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(663, 51);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "عمليات";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(650, 32);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "جديد";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "طباعة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59524F));
            this.tableLayoutPanel3.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.vTotalPaid, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 488);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(667, 29);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 22);
            this.button6.TabIndex = 3;
            this.button6.Text = "حفظ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(369, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "حذف";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(479, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "تعديل";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(184, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "إجمالي";
            // 
            // vTotalPaid
            // 
            this.vTotalPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTotalPaid.Location = new System.Drawing.Point(3, 3);
            this.vTotalPaid.Name = "vTotalPaid";
            this.vTotalPaid.ReadOnly = true;
            this.vTotalPaid.Size = new System.Drawing.Size(166, 20);
            this.vTotalPaid.TabIndex = 10;
            // 
            // ReceiptUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 650);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سند صرف لمورد";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker vCreationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView vList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox vInvoiceId;
        private System.Windows.Forms.TextBox vInvoiceType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox vId;
        private System.Windows.Forms.TextBox vSupplierId;
        private System.Windows.Forms.TextBox vSupplierName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox vIsDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vInvoiceTotalSellPrice;
        private System.Windows.Forms.TextBox vDiscount;
        private System.Windows.Forms.TextBox vRemainAfterDiscount;
        private System.Windows.Forms.TextBox vTotalPaid;
        private System.Windows.Forms.TextBox vInvoiceRemain;
        private System.Windows.Forms.TextBox vInvoiceCreationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox vPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReciptItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvoiceCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIsDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaid;
    }
}