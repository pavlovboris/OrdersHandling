
namespace OrdersHandling
{
    partial class frmOrdersList
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
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.powderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compleatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSQMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderkgrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isOfferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matDate2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedMatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lstFilterCompleted = new System.Windows.Forms.ListBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersList.AutoGenerateColumns = false;
            this.dgvOrdersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvOrdersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ForeignID,
            this.customerIDDataGridViewTextBoxColumn,
            this.orddateDataGridViewTextBoxColumn,
            this.deldateDataGridViewTextBoxColumn,
            this.rALIDDataGridViewTextBoxColumn,
            this.powderCodeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.compleatedDataGridViewTextBoxColumn,
            this.orderValueDataGridViewTextBoxColumn,
            this.orderSQMDataGridViewTextBoxColumn,
            this.orderkgrDataGridViewTextBoxColumn,
            this.orderPcsDataGridViewTextBoxColumn,
            this.isConfirmedDataGridViewTextBoxColumn,
            this.isOfferDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.reqdateDataGridViewTextBoxColumn,
            this.matdateDataGridViewTextBoxColumn,
            this.isReadyDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.matDate2DataGridViewTextBoxColumn,
            this.expectedMatDateDataGridViewTextBoxColumn});
            this.dgvOrdersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrdersList.DataSource = this.ordersBindingSource;
            this.dgvOrdersList.Location = new System.Drawing.Point(12, 62);
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.ReadOnly = true;
            this.dgvOrdersList.RowHeadersWidth = 20;
            this.dgvOrdersList.Size = new System.Drawing.Size(1275, 460);
            this.dgvOrdersList.TabIndex = 0;
            this.dgvOrdersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellDoubleClick);
            this.dgvOrdersList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrdersList_CellMouseDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // ForeignID
            // 
            this.ForeignID.DataPropertyName = "ForeignID";
            this.ForeignID.HeaderText = "Order Number";
            this.ForeignID.Name = "ForeignID";
            this.ForeignID.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource1;
            this.customerIDDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.customerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // partnersBindingSource1
            // 
            this.partnersBindingSource1.DataSource = typeof(OrdersHandling.Partners);
            // 
            // orddateDataGridViewTextBoxColumn
            // 
            this.orddateDataGridViewTextBoxColumn.DataPropertyName = "Orddate";
            this.orddateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.orddateDataGridViewTextBoxColumn.Name = "orddateDataGridViewTextBoxColumn";
            this.orddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deldateDataGridViewTextBoxColumn
            // 
            this.deldateDataGridViewTextBoxColumn.DataPropertyName = "Deldate";
            this.deldateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.deldateDataGridViewTextBoxColumn.Name = "deldateDataGridViewTextBoxColumn";
            this.deldateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rALIDDataGridViewTextBoxColumn
            // 
            this.rALIDDataGridViewTextBoxColumn.DataPropertyName = "RALID";
            this.rALIDDataGridViewTextBoxColumn.DataSource = this.colorsBindingSource;
            this.rALIDDataGridViewTextBoxColumn.DisplayMember = "ColorName";
            this.rALIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rALIDDataGridViewTextBoxColumn.HeaderText = "Color";
            this.rALIDDataGridViewTextBoxColumn.Name = "rALIDDataGridViewTextBoxColumn";
            this.rALIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rALIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rALIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rALIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataSource = typeof(OrdersHandling.Colors);
            // 
            // powderCodeDataGridViewTextBoxColumn
            // 
            this.powderCodeDataGridViewTextBoxColumn.DataPropertyName = "Powder_Code";
            this.powderCodeDataGridViewTextBoxColumn.DataSource = this.codesBindingSource;
            this.powderCodeDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.powderCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.powderCodeDataGridViewTextBoxColumn.HeaderText = "Powder Code";
            this.powderCodeDataGridViewTextBoxColumn.Name = "powderCodeDataGridViewTextBoxColumn";
            this.powderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.powderCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.powderCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.powderCodeDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataSource = typeof(OrdersHandling.Codes);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compleatedDataGridViewTextBoxColumn
            // 
            this.compleatedDataGridViewTextBoxColumn.DataPropertyName = "Compleated";
            this.compleatedDataGridViewTextBoxColumn.FalseValue = "0";
            this.compleatedDataGridViewTextBoxColumn.HeaderText = "Compleated";
            this.compleatedDataGridViewTextBoxColumn.Name = "compleatedDataGridViewTextBoxColumn";
            this.compleatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.compleatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.compleatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.compleatedDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // orderValueDataGridViewTextBoxColumn
            // 
            this.orderValueDataGridViewTextBoxColumn.DataPropertyName = "OrderValue";
            this.orderValueDataGridViewTextBoxColumn.HeaderText = "Order Value";
            this.orderValueDataGridViewTextBoxColumn.Name = "orderValueDataGridViewTextBoxColumn";
            this.orderValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderSQMDataGridViewTextBoxColumn
            // 
            this.orderSQMDataGridViewTextBoxColumn.DataPropertyName = "OrderSQM";
            this.orderSQMDataGridViewTextBoxColumn.HeaderText = "Order SQM";
            this.orderSQMDataGridViewTextBoxColumn.Name = "orderSQMDataGridViewTextBoxColumn";
            this.orderSQMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderkgrDataGridViewTextBoxColumn
            // 
            this.orderkgrDataGridViewTextBoxColumn.DataPropertyName = "Orderkgr";
            this.orderkgrDataGridViewTextBoxColumn.HeaderText = "Order KGR";
            this.orderkgrDataGridViewTextBoxColumn.Name = "orderkgrDataGridViewTextBoxColumn";
            this.orderkgrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderPcsDataGridViewTextBoxColumn
            // 
            this.orderPcsDataGridViewTextBoxColumn.DataPropertyName = "OrderPcs";
            this.orderPcsDataGridViewTextBoxColumn.HeaderText = "Order Pcs";
            this.orderPcsDataGridViewTextBoxColumn.Name = "orderPcsDataGridViewTextBoxColumn";
            this.orderPcsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isConfirmedDataGridViewTextBoxColumn
            // 
            this.isConfirmedDataGridViewTextBoxColumn.DataPropertyName = "IsConfirmed";
            this.isConfirmedDataGridViewTextBoxColumn.FalseValue = "0";
            this.isConfirmedDataGridViewTextBoxColumn.HeaderText = "IsConfirmed";
            this.isConfirmedDataGridViewTextBoxColumn.Name = "isConfirmedDataGridViewTextBoxColumn";
            this.isConfirmedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isConfirmedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isConfirmedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isConfirmedDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // isOfferDataGridViewTextBoxColumn
            // 
            this.isOfferDataGridViewTextBoxColumn.DataPropertyName = "IsOffer";
            this.isOfferDataGridViewTextBoxColumn.FalseValue = "0";
            this.isOfferDataGridViewTextBoxColumn.HeaderText = "IsOffer";
            this.isOfferDataGridViewTextBoxColumn.Name = "isOfferDataGridViewTextBoxColumn";
            this.isOfferDataGridViewTextBoxColumn.ReadOnly = true;
            this.isOfferDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isOfferDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isOfferDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reqdateDataGridViewTextBoxColumn
            // 
            this.reqdateDataGridViewTextBoxColumn.DataPropertyName = "Req_date";
            this.reqdateDataGridViewTextBoxColumn.HeaderText = "Required Date";
            this.reqdateDataGridViewTextBoxColumn.Name = "reqdateDataGridViewTextBoxColumn";
            this.reqdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matdateDataGridViewTextBoxColumn
            // 
            this.matdateDataGridViewTextBoxColumn.DataPropertyName = "Mat_date";
            this.matdateDataGridViewTextBoxColumn.HeaderText = "Material Date";
            this.matdateDataGridViewTextBoxColumn.Name = "matdateDataGridViewTextBoxColumn";
            this.matdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isReadyDataGridViewTextBoxColumn
            // 
            this.isReadyDataGridViewTextBoxColumn.DataPropertyName = "IsReady";
            this.isReadyDataGridViewTextBoxColumn.FalseValue = "0";
            this.isReadyDataGridViewTextBoxColumn.HeaderText = "IsReady";
            this.isReadyDataGridViewTextBoxColumn.Name = "isReadyDataGridViewTextBoxColumn";
            this.isReadyDataGridViewTextBoxColumn.ReadOnly = true;
            this.isReadyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isReadyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isReadyDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "Delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "Production Date";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matDate2DataGridViewTextBoxColumn
            // 
            this.matDate2DataGridViewTextBoxColumn.DataPropertyName = "MatDate2";
            this.matDate2DataGridViewTextBoxColumn.HeaderText = "Material Date2";
            this.matDate2DataGridViewTextBoxColumn.Name = "matDate2DataGridViewTextBoxColumn";
            this.matDate2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expectedMatDateDataGridViewTextBoxColumn
            // 
            this.expectedMatDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedMatDate";
            this.expectedMatDateDataGridViewTextBoxColumn.HeaderText = "Expected Mat Date";
            this.expectedMatDateDataGridViewTextBoxColumn.Name = "expectedMatDateDataGridViewTextBoxColumn";
            this.expectedMatDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(107, 22);
            this.contextMenuDelete.Text = "Delete";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(OrdersHandling.Orders);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.DataSource = this.partnersBindingSource1;
            this.cmbCustomer.DisplayMember = "Partner_name";
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(12, 13);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(238, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.ValueMember = "ID";
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(OrdersHandling.Partners);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(464, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lstFilterCompleted
            // 
            this.lstFilterCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFilterCompleted.FormattingEnabled = true;
            this.lstFilterCompleted.Items.AddRange(new object[] {
            "Completed",
            "Not Completed",
            "All"});
            this.lstFilterCompleted.Location = new System.Drawing.Point(1167, 12);
            this.lstFilterCompleted.Name = "lstFilterCompleted";
            this.lstFilterCompleted.Size = new System.Drawing.Size(120, 39);
            this.lstFilterCompleted.TabIndex = 3;
            this.lstFilterCompleted.SelectedIndexChanged += new System.EventHandler(this.lblFilterCompleted_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(423, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter :";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Orders",
            "Offers"});
            this.cmbFilter.Location = new System.Drawing.Point(256, 13);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // frmOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 564);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lstFilterCompleted);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.dgvOrdersList);
            this.Name = "frmOrdersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders List";
            this.Load += new System.EventHandler(this.frmOrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdersList;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.BindingSource partnersBindingSource1;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignID;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn powderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compleatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSQMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderkgrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOfferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDate2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedMatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lstFilterCompleted;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDelete;
    }
}