namespace CanadaSalesManagement1.PL
{
    partial class FrmAllOrders
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
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.dgvAllOrdersList = new System.Windows.Forms.DataGridView();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintDetailsOfSelectedOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrdersList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Location = new System.Drawing.Point(324, 28);
            this.txtSearchOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(342, 20);
            this.txtSearchOrder.TabIndex = 8;
            this.txtSearchOrder.TextChanged += new System.EventHandler(this.txtSearchOrder_TextChanged);
            // 
            // dgvAllOrdersList
            // 
            this.dgvAllOrdersList.AllowUserToAddRows = false;
            this.dgvAllOrdersList.AllowUserToDeleteRows = false;
            this.dgvAllOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllOrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrdersList.Location = new System.Drawing.Point(7, 20);
            this.dgvAllOrdersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllOrdersList.MultiSelect = false;
            this.dgvAllOrdersList.Name = "dgvAllOrdersList";
            this.dgvAllOrdersList.ReadOnly = true;
            this.dgvAllOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllOrdersList.Size = new System.Drawing.Size(940, 304);
            this.dgvAllOrdersList.TabIndex = 0;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.Navy;
            this.btnEditOrder.Location = new System.Drawing.Point(252, 403);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(260, 37);
            this.btnEditOrder.TabIndex = 12;
            this.btnEditOrder.Text = "Edit Selected Order Details";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewOrder.ForeColor = System.Drawing.Color.Navy;
            this.btnAddNewOrder.Location = new System.Drawing.Point(61, 403);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(188, 37);
            this.btnAddNewOrder.TabIndex = 11;
            this.btnAddNewOrder.Text = "Add New Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(808, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintDetailsOfSelectedOrder
            // 
            this.btnPrintDetailsOfSelectedOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDetailsOfSelectedOrder.ForeColor = System.Drawing.Color.Navy;
            this.btnPrintDetailsOfSelectedOrder.Location = new System.Drawing.Point(518, 403);
            this.btnPrintDetailsOfSelectedOrder.Name = "btnPrintDetailsOfSelectedOrder";
            this.btnPrintDetailsOfSelectedOrder.Size = new System.Drawing.Size(284, 37);
            this.btnPrintDetailsOfSelectedOrder.TabIndex = 9;
            this.btnPrintDetailsOfSelectedOrder.Text = "Report Of Selected Order Details";
            this.btnPrintDetailsOfSelectedOrder.UseVisualStyleBackColor = true;
            this.btnPrintDetailsOfSelectedOrder.Click += new System.EventHandler(this.btnPrintDetailsOfSelectedOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAllOrdersList);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(25, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(953, 331);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Orders List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(248, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // FrmAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintDetailsOfSelectedOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAllOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAllOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrdersList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.DataGridView dgvAllOrdersList;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintDetailsOfSelectedOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}