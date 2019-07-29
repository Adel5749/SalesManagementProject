namespace CanadaSalesManagement1.PL
{
    partial class FrmOrders
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالصفالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفجميعالصفوفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrdNetAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProdDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtProdAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnBrowsProducts = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.txtOrderDesc = new System.Windows.Forms.TextBox();
            this.OrderInformation = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerInformation = new System.Windows.Forms.GroupBox();
            this.btnBrowseCustomers = new System.Windows.Forms.Button();
            this.picCust = new System.Windows.Forms.PictureBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCustFamilyName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.OrderInformation.SuspendLayout();
            this.CustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCust)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustName
            // 
            this.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustName.Location = new System.Drawing.Point(133, 54);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(163, 24);
            this.txtCustName.TabIndex = 3;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.Navy;
            this.btnNewOrder.Location = new System.Drawing.Point(146, 516);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(114, 35);
            this.btnNewOrder.TabIndex = 18;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Enabled = false;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.Navy;
            this.btnSaveInvoice.Location = new System.Drawing.Point(300, 516);
            this.btnSaveInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(114, 35);
            this.btnSaveInvoice.TabIndex = 19;
            this.btnSaveInvoice.Text = "Save Order";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Family Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer ID:";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(20, 22);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(2);
            this.label18.Size = new System.Drawing.Size(88, 26);
            this.label18.TabIndex = 25;
            this.label18.Text = "Select Product";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.Navy;
            this.btnPrintInvoice.Location = new System.Drawing.Point(454, 516);
            this.btnPrintInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(182, 35);
            this.btnPrintInvoice.TabIndex = 20;
            this.btnPrintInvoice.Text = "Last Order Report";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالصفالحاليToolStripMenuItem,
            this.حذفجميعالصفوفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 76);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // حذفالصفالحاليToolStripMenuItem
            // 
            this.حذفالصفالحاليToolStripMenuItem.Name = "حذفالصفالحاليToolStripMenuItem";
            this.حذفالصفالحاليToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.حذفالصفالحاليToolStripMenuItem.Text = "حذف الصف الحالي";
            this.حذفالصفالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالصفالحاليToolStripMenuItem_Click);
            // 
            // حذفجميعالصفوفToolStripMenuItem
            // 
            this.حذفجميعالصفوفToolStripMenuItem.Name = "حذفجميعالصفوفToolStripMenuItem";
            this.حذفجميعالصفوفToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.حذفجميعالصفوفToolStripMenuItem.Text = "حذف جميع الصفوف";
            this.حذفجميعالصفوفToolStripMenuItem.Click += new System.EventHandler(this.حذفجميعالصفوفToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtPrdNetAmount);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtProdDiscount);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtProdAmount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtProdQty);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtProdPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtProdName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtProdID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnDeleteRow);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Controls.Add(this.btnBrowsProducts);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(15, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(887, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // txtPrdNetAmount
            // 
            this.txtPrdNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrdNetAmount.Location = new System.Drawing.Point(744, 48);
            this.txtPrdNetAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrdNetAmount.Name = "txtPrdNetAmount";
            this.txtPrdNetAmount.ReadOnly = true;
            this.txtPrdNetAmount.Size = new System.Drawing.Size(137, 24);
            this.txtPrdNetAmount.TabIndex = 24;
            this.txtPrdNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(744, 22);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(2);
            this.label17.Size = new System.Drawing.Size(137, 26);
            this.label17.TabIndex = 23;
            this.label17.Text = "Net Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdDiscount
            // 
            this.txtProdDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdDiscount.Location = new System.Drawing.Point(639, 48);
            this.txtProdDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdDiscount.MaxLength = 3;
            this.txtProdDiscount.Name = "txtProdDiscount";
            this.txtProdDiscount.Size = new System.Drawing.Size(105, 24);
            this.txtProdDiscount.TabIndex = 22;
            this.txtProdDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdDiscount_KeyDown);
            this.txtProdDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdDiscount_KeyPress);
            this.txtProdDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdDiscount_KeyUp);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(639, 22);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(2);
            this.label16.Size = new System.Drawing.Size(105, 26);
            this.label16.TabIndex = 21;
            this.label16.Text = "Discount (%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdAmount
            // 
            this.txtProdAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdAmount.Location = new System.Drawing.Point(537, 48);
            this.txtProdAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdAmount.Name = "txtProdAmount";
            this.txtProdAmount.ReadOnly = true;
            this.txtProdAmount.Size = new System.Drawing.Size(102, 24);
            this.txtProdAmount.TabIndex = 20;
            this.txtProdAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(537, 22);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(2);
            this.label15.Size = new System.Drawing.Size(102, 26);
            this.label15.TabIndex = 19;
            this.label15.Text = "Amount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdQty
            // 
            this.txtProdQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdQty.Location = new System.Drawing.Point(435, 48);
            this.txtProdQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdQty.MaxLength = 8;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(102, 24);
            this.txtProdQty.TabIndex = 18;
            this.txtProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdQty_KeyDown);
            this.txtProdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdQty_KeyPress);
            this.txtProdQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdQty_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(435, 22);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(2);
            this.label14.Size = new System.Drawing.Size(102, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Quantity";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdPrice.Location = new System.Drawing.Point(329, 48);
            this.txtProdPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdPrice.MaxLength = 8;
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(106, 24);
            this.txtProdPrice.TabIndex = 16;
            this.txtProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdPrice_KeyDown);
            this.txtProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdPrice_KeyPress);
            this.txtProdPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdPrice_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(329, 22);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(2);
            this.label13.Size = new System.Drawing.Size(106, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Price";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdName
            // 
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.Location = new System.Drawing.Point(189, 48);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(140, 24);
            this.txtProdName.TabIndex = 14;
            this.txtProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(189, 22);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(2);
            this.label12.Size = new System.Drawing.Size(140, 26);
            this.label12.TabIndex = 13;
            this.label12.Text = "Product Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdID
            // 
            this.txtProdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdID.Location = new System.Drawing.Point(108, 48);
            this.txtProdID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(81, 24);
            this.txtProdID.TabIndex = 12;
            this.txtProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(108, 22);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(81, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Product ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(744, 235);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 24);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(692, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Enabled = false;
            this.btnDeleteRow.Location = new System.Drawing.Point(19, 235);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(162, 26);
            this.btnDeleteRow.TabIndex = 1;
            this.btnDeleteRow.Text = "Delete Selected Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(19, 76);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 88;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(862, 151);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProducts_RowsAdded);
            this.dgvProducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProducts_RowsRemoved);
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // btnBrowsProducts
            // 
            this.btnBrowsProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowsProducts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBrowsProducts.FlatAppearance.BorderSize = 2;
            this.btnBrowsProducts.Location = new System.Drawing.Point(19, 46);
            this.btnBrowsProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowsProducts.Name = "btnBrowsProducts";
            this.btnBrowsProducts.Padding = new System.Windows.Forms.Padding(1);
            this.btnBrowsProducts.Size = new System.Drawing.Size(90, 27);
            this.btnBrowsProducts.TabIndex = 26;
            this.btnBrowsProducts.Text = ". . .";
            this.btnBrowsProducts.UseVisualStyleBackColor = false;
            this.btnBrowsProducts.Click += new System.EventHandler(this.btnBrowsProducts_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustID.Location = new System.Drawing.Point(133, 22);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(106, 24);
            this.txtCustID.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(676, 516);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(154, 17);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(240, 24);
            this.txtOrderID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales Man:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(154, 115);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.RightToLeftLayout = true;
            this.dtpOrderDate.Size = new System.Drawing.Size(240, 24);
            this.dtpOrderDate.TabIndex = 1;
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesMan.Location = new System.Drawing.Point(154, 143);
            this.txtSalesMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(240, 24);
            this.txtSalesMan.TabIndex = 6;
            // 
            // txtOrderDesc
            // 
            this.txtOrderDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderDesc.Location = new System.Drawing.Point(154, 52);
            this.txtOrderDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderDesc.Multiline = true;
            this.txtOrderDesc.Name = "txtOrderDesc";
            this.txtOrderDesc.Size = new System.Drawing.Size(240, 59);
            this.txtOrderDesc.TabIndex = 0;
            // 
            // OrderInformation
            // 
            this.OrderInformation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrderInformation.Controls.Add(this.dtpOrderDate);
            this.OrderInformation.Controls.Add(this.txtSalesMan);
            this.OrderInformation.Controls.Add(this.txtOrderDesc);
            this.OrderInformation.Controls.Add(this.txtOrderID);
            this.OrderInformation.Controls.Add(this.label4);
            this.OrderInformation.Controls.Add(this.label3);
            this.OrderInformation.Controls.Add(this.label2);
            this.OrderInformation.Controls.Add(this.label1);
            this.OrderInformation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OrderInformation.ForeColor = System.Drawing.Color.Navy;
            this.OrderInformation.Location = new System.Drawing.Point(15, 39);
            this.OrderInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderInformation.Name = "OrderInformation";
            this.OrderInformation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderInformation.Size = new System.Drawing.Size(409, 186);
            this.OrderInformation.TabIndex = 0;
            this.OrderInformation.TabStop = false;
            this.OrderInformation.Text = "Order Information:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Description:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerInformation
            // 
            this.CustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerInformation.Controls.Add(this.btnBrowseCustomers);
            this.CustomerInformation.Controls.Add(this.picCust);
            this.CustomerInformation.Controls.Add(this.txtCustPhone);
            this.CustomerInformation.Controls.Add(this.label9);
            this.CustomerInformation.Controls.Add(this.txtEmail);
            this.CustomerInformation.Controls.Add(this.txtCustFamilyName);
            this.CustomerInformation.Controls.Add(this.txtCustName);
            this.CustomerInformation.Controls.Add(this.txtCustID);
            this.CustomerInformation.Controls.Add(this.label8);
            this.CustomerInformation.Controls.Add(this.label7);
            this.CustomerInformation.Controls.Add(this.label6);
            this.CustomerInformation.Controls.Add(this.label5);
            this.CustomerInformation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CustomerInformation.ForeColor = System.Drawing.Color.Navy;
            this.CustomerInformation.Location = new System.Drawing.Point(454, 39);
            this.CustomerInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerInformation.Name = "CustomerInformation";
            this.CustomerInformation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerInformation.Size = new System.Drawing.Size(448, 186);
            this.CustomerInformation.TabIndex = 1;
            this.CustomerInformation.TabStop = false;
            this.CustomerInformation.Text = "Customer Information:";
            // 
            // btnBrowseCustomers
            // 
            this.btnBrowseCustomers.AutoSize = true;
            this.btnBrowseCustomers.Location = new System.Drawing.Point(245, 21);
            this.btnBrowseCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseCustomers.Name = "btnBrowseCustomers";
            this.btnBrowseCustomers.Size = new System.Drawing.Size(51, 27);
            this.btnBrowseCustomers.TabIndex = 2;
            this.btnBrowseCustomers.Text = ". . .";
            this.btnBrowseCustomers.UseVisualStyleBackColor = true;
            this.btnBrowseCustomers.Click += new System.EventHandler(this.btnBrowseCustomers_Click);
            // 
            // picCust
            // 
            this.picCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCust.Location = new System.Drawing.Point(302, 17);
            this.picCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCust.Name = "picCust";
            this.picCust.Size = new System.Drawing.Size(137, 150);
            this.picCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCust.TabIndex = 2;
            this.picCust.TabStop = false;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustPhone.Location = new System.Drawing.Point(133, 115);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ReadOnly = true;
            this.txtCustPhone.Size = new System.Drawing.Size(163, 24);
            this.txtCustPhone.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(133, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(163, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCustFamilyName
            // 
            this.txtCustFamilyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustFamilyName.Location = new System.Drawing.Point(133, 85);
            this.txtCustFamilyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustFamilyName.Name = "txtCustFamilyName";
            this.txtCustFamilyName.ReadOnly = true;
            this.txtCustFamilyName.Size = new System.Drawing.Size(163, 24);
            this.txtCustFamilyName.TabIndex = 6;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(932, 581);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.OrderInformation);
            this.Controls.Add(this.CustomerInformation);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Orders Form";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.OrderInformation.ResumeLayout(false);
            this.OrderInformation.PerformLayout();
            this.CustomerInformation.ResumeLayout(false);
            this.CustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtCustName;
        public System.Windows.Forms.Button btnNewOrder;
        public System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالصفالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفجميعالصفوفToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrdNetAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtProdDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProdAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteRow;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnBrowsProducts;
        public System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpOrderDate;
        public System.Windows.Forms.TextBox txtSalesMan;
        public System.Windows.Forms.TextBox txtOrderDesc;
        private System.Windows.Forms.GroupBox OrderInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CustomerInformation;
        private System.Windows.Forms.Button btnBrowseCustomers;
        public System.Windows.Forms.PictureBox picCust;
        public System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCustFamilyName;
    }
}