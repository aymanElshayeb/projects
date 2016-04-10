namespace POS3
{
    partial class OrderSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgOrderSearch = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelieveryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOrderNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(24, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث ب";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الطلب";
            // 
            // lbOrderNumber
            // 
            this.lbOrderNumber.Location = new System.Drawing.Point(413, 24);
            this.lbOrderNumber.Name = "lbOrderNumber";
            this.lbOrderNumber.Size = new System.Drawing.Size(125, 20);
            this.lbOrderNumber.TabIndex = 1;
            this.lbOrderNumber.TextChanged += new System.EventHandler(this.lbOrderNumber_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgOrderSearch);
            this.groupBox2.Location = new System.Drawing.Point(21, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 471);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الطلبات";
            // 
            // dgOrderSearch
            // 
            this.dgOrderSearch.AllowUserToAddRows = false;
            this.dgOrderSearch.AllowUserToDeleteRows = false;
            this.dgOrderSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Total,
            this.CustomerName,
            this.DelieveryName});
            this.dgOrderSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderSearch.Location = new System.Drawing.Point(3, 16);
            this.dgOrderSearch.Name = "dgOrderSearch";
            this.dgOrderSearch.ReadOnly = true;
            this.dgOrderSearch.Size = new System.Drawing.Size(585, 452);
            this.dgOrderSearch.TabIndex = 0;
            this.dgOrderSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderSearch_CellContentClick);
            
            // 
            // Number
            // 
            this.Number.HeaderText = "رقم الطلب";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "المجموع";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "العميل";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // DelieveryName
            // 
            this.DelieveryName.HeaderText = "الطيار";
            this.DelieveryName.Name = "DelieveryName";
            this.DelieveryName.ReadOnly = true;
            // 
            // OrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بحث عن طلب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lbOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgOrderSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelieveryName;
    }
}