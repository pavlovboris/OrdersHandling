
namespace OrdersHandling
{
    partial class frmOrderEdit
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderRealNumber = new System.Windows.Forms.Label();
            this.lblForeignID = new System.Windows.Forms.Label();
            this.grpColorPowder = new System.Windows.Forms.GroupBox();
            this.cmbPowder = new System.Windows.Forms.ComboBox();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPowder = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblColor = new System.Windows.Forms.Label();
            this.grpSaveCancel = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.chkboxOffer = new System.Windows.Forms.CheckBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.chkBoxCompleated = new System.Windows.Forms.CheckBox();
            this.chkBoxReady = new System.Windows.Forms.CheckBox();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.dateTimeExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedMatDate = new System.Windows.Forms.Label();
            this.dateTimeReqDate = new System.Windows.Forms.DateTimePicker();
            this.lblReqDate = new System.Windows.Forms.Label();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CodeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surfaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remainingQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isForCoatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sqmCorrectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thermoFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protectiveFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thermoFilmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protectionFilmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditLines = new System.Windows.Forms.Button();
            this.cmbPartnerName = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.grpColorPowder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            this.grpSaveCancel.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(131, 9);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(13, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "?";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(113, 13);
            this.lblCurrentOrder.TabIndex = 1;
            this.lblCurrentOrder.Text = "Current Order Number:";
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "Orddate", true));
            this.dateTimeDate.Location = new System.Drawing.Point(12, 53);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(155, 20);
            this.dateTimeDate.TabIndex = 2;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(OrdersHandling.Orders);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(9, 37);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderRealNumber
            // 
            this.lblOrderRealNumber.AutoSize = true;
            this.lblOrderRealNumber.Location = new System.Drawing.Point(12, 80);
            this.lblOrderRealNumber.Name = "lblOrderRealNumber";
            this.lblOrderRealNumber.Size = new System.Drawing.Size(142, 13);
            this.lblOrderRealNumber.TabIndex = 4;
            this.lblOrderRealNumber.Text = "Apello System Order Number";
            // 
            // lblForeignID
            // 
            this.lblForeignID.AutoSize = true;
            this.lblForeignID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ForeignID", true));
            this.lblForeignID.Location = new System.Drawing.Point(12, 97);
            this.lblForeignID.Name = "lblForeignID";
            this.lblForeignID.Size = new System.Drawing.Size(13, 13);
            this.lblForeignID.TabIndex = 5;
            this.lblForeignID.Text = "?";
            // 
            // grpColorPowder
            // 
            this.grpColorPowder.Controls.Add(this.cmbPowder);
            this.grpColorPowder.Controls.Add(this.lblPowder);
            this.grpColorPowder.Controls.Add(this.cmbColor);
            this.grpColorPowder.Controls.Add(this.lblColor);
            this.grpColorPowder.Location = new System.Drawing.Point(214, 13);
            this.grpColorPowder.Name = "grpColorPowder";
            this.grpColorPowder.Size = new System.Drawing.Size(295, 80);
            this.grpColorPowder.TabIndex = 6;
            this.grpColorPowder.TabStop = false;
            this.grpColorPowder.Text = "Color-Powder";
            // 
            // cmbPowder
            // 
            this.cmbPowder.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Powder_Code", true));
            this.cmbPowder.DataSource = this.codesBindingSource;
            this.cmbPowder.DisplayMember = "Code";
            this.cmbPowder.FormattingEnabled = true;
            this.cmbPowder.Location = new System.Drawing.Point(154, 39);
            this.cmbPowder.Name = "cmbPowder";
            this.cmbPowder.Size = new System.Drawing.Size(131, 21);
            this.cmbPowder.TabIndex = 4;
            this.cmbPowder.ValueMember = "ID";
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataSource = typeof(OrdersHandling.Codes);
            // 
            // lblPowder
            // 
            this.lblPowder.AutoSize = true;
            this.lblPowder.Location = new System.Drawing.Point(151, 23);
            this.lblPowder.Name = "lblPowder";
            this.lblPowder.Size = new System.Drawing.Size(71, 13);
            this.lblPowder.TabIndex = 3;
            this.lblPowder.Text = "Powder Code";
            // 
            // cmbColor
            // 
            this.cmbColor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "RALID", true));
            this.cmbColor.DataSource = this.colorsBindingSource;
            this.cmbColor.DisplayMember = "ColorName";
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(6, 40);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(139, 21);
            this.cmbColor.TabIndex = 2;
            this.cmbColor.ValueMember = "ID";
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataSource = typeof(OrdersHandling.Colors);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 23);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // grpSaveCancel
            // 
            this.grpSaveCancel.Controls.Add(this.btnSave);
            this.grpSaveCancel.Location = new System.Drawing.Point(548, 13);
            this.grpSaveCancel.Name = "grpSaveCancel";
            this.grpSaveCancel.Size = new System.Drawing.Size(240, 80);
            this.grpSaveCancel.TabIndex = 7;
            this.grpSaveCancel.TabStop = false;
            this.grpSaveCancel.Text = "Save-Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Запази";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 171);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Comment", true));
            this.txtComment.Location = new System.Drawing.Point(12, 188);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(460, 63);
            this.txtComment.TabIndex = 9;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(479, 171);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(71, 13);
            this.lblProject.TabIndex = 10;
            this.lblProject.Text = "Project Name";
            // 
            // txtProject
            // 
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Project", true));
            this.txtProject.Location = new System.Drawing.Point(482, 188);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(306, 20);
            this.txtProject.TabIndex = 11;
            // 
            // chkboxOffer
            // 
            this.chkboxOffer.AutoSize = true;
            this.chkboxOffer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxOffer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ordersBindingSource, "IsOffer", true));
            this.chkboxOffer.Location = new System.Drawing.Point(12, 113);
            this.chkboxOffer.Name = "chkboxOffer";
            this.chkboxOffer.Size = new System.Drawing.Size(55, 17);
            this.chkboxOffer.TabIndex = 13;
            this.chkboxOffer.Text = "Offer :";
            this.chkboxOffer.UseVisualStyleBackColor = true;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.chkBoxCompleated);
            this.grpStatus.Controls.Add(this.chkBoxReady);
            this.grpStatus.Location = new System.Drawing.Point(548, 99);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(240, 63);
            this.grpStatus.TabIndex = 14;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Order Status";
            // 
            // chkBoxCompleated
            // 
            this.chkBoxCompleated.AutoSize = true;
            this.chkBoxCompleated.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxCompleated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ordersBindingSource, "Compleated", true));
            this.chkBoxCompleated.Location = new System.Drawing.Point(69, 29);
            this.chkBoxCompleated.Name = "chkBoxCompleated";
            this.chkBoxCompleated.Size = new System.Drawing.Size(76, 17);
            this.chkBoxCompleated.TabIndex = 1;
            this.chkBoxCompleated.Text = "Completed";
            this.chkBoxCompleated.UseVisualStyleBackColor = true;
            // 
            // chkBoxReady
            // 
            this.chkBoxReady.AutoSize = true;
            this.chkBoxReady.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxReady.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ordersBindingSource, "IsReady", true));
            this.chkBoxReady.Location = new System.Drawing.Point(6, 29);
            this.chkBoxReady.Name = "chkBoxReady";
            this.chkBoxReady.Size = new System.Drawing.Size(57, 17);
            this.chkBoxReady.TabIndex = 0;
            this.chkBoxReady.Text = "Ready";
            this.chkBoxReady.UseVisualStyleBackColor = true;
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dateTimeExpectedDate);
            this.grpDates.Controls.Add(this.lblExpectedMatDate);
            this.grpDates.Controls.Add(this.dateTimeReqDate);
            this.grpDates.Controls.Add(this.lblReqDate);
            this.grpDates.Location = new System.Drawing.Point(214, 99);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(295, 63);
            this.grpDates.TabIndex = 15;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "Dates";
            // 
            // dateTimeExpectedDate
            // 
            this.dateTimeExpectedDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ExpectedMatDate", true));
            this.dateTimeExpectedDate.Location = new System.Drawing.Point(155, 30);
            this.dateTimeExpectedDate.Name = "dateTimeExpectedDate";
            this.dateTimeExpectedDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimeExpectedDate.TabIndex = 3;
            this.dateTimeExpectedDate.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // lblExpectedMatDate
            // 
            this.lblExpectedMatDate.AutoSize = true;
            this.lblExpectedMatDate.Location = new System.Drawing.Point(152, 14);
            this.lblExpectedMatDate.Name = "lblExpectedMatDate";
            this.lblExpectedMatDate.Size = new System.Drawing.Size(133, 13);
            this.lblExpectedMatDate.TabIndex = 2;
            this.lblExpectedMatDate.Text = "Expected Material Delivery";
            // 
            // dateTimeReqDate
            // 
            this.dateTimeReqDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "Req_date", true));
            this.dateTimeReqDate.Location = new System.Drawing.Point(10, 31);
            this.dateTimeReqDate.Name = "dateTimeReqDate";
            this.dateTimeReqDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimeReqDate.TabIndex = 1;
            this.dateTimeReqDate.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // lblReqDate
            // 
            this.lblReqDate.AutoSize = true;
            this.lblReqDate.Location = new System.Drawing.Point(7, 14);
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(76, 13);
            this.lblReqDate.TabIndex = 0;
            this.lblReqDate.Text = "Required Date";
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AllowUserToAddRows = false;
            this.dgvOrderLines.AutoGenerateColumns = false;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.codeIDDataGridViewTextBoxColumn,
            this.CodeID,
            this.surfaceIDDataGridViewTextBoxColumn,
            this.pcsDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.MU,
            this.remainingQTYDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.isForCoatingDataGridViewTextBoxColumn,
            this.sqmCorrectionsDataGridViewTextBoxColumn,
            this.thermoFilmDataGridViewTextBoxColumn,
            this.protectiveFilmDataGridViewTextBoxColumn,
            this.thermoFilmPriceDataGridViewTextBoxColumn,
            this.protectionFilmPriceDataGridViewTextBoxColumn,
            this.perimeterDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn});
            this.dgvOrderLines.DataSource = this.orderLinesBindingSource;
            this.dgvOrderLines.Location = new System.Drawing.Point(12, 297);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.Size = new System.Drawing.Size(1322, 364);
            this.dgvOrderLines.TabIndex = 16;
            this.dgvOrderLines.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderLines_CellMouseClick);
            this.dgvOrderLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderLines_CellValueChanged);
            this.dgvOrderLines.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderLines_RowEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeIDDataGridViewTextBoxColumn
            // 
            this.codeIDDataGridViewTextBoxColumn.DataPropertyName = "CodeID";
            this.codeIDDataGridViewTextBoxColumn.DataSource = this.codesBindingSource1;
            this.codeIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.codeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeIDDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeIDDataGridViewTextBoxColumn.Name = "codeIDDataGridViewTextBoxColumn";
            this.codeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // codesBindingSource1
            // 
            this.codesBindingSource1.DataSource = typeof(OrdersHandling.Codes);
            // 
            // CodeID
            // 
            this.CodeID.DataPropertyName = "CodeID";
            this.CodeID.DataSource = this.codesBindingSource1;
            this.CodeID.DisplayMember = "Description";
            this.CodeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CodeID.HeaderText = "Description";
            this.CodeID.Name = "CodeID";
            this.CodeID.ValueMember = "ID";
            // 
            // surfaceIDDataGridViewTextBoxColumn
            // 
            this.surfaceIDDataGridViewTextBoxColumn.DataPropertyName = "SurfaceID";
            this.surfaceIDDataGridViewTextBoxColumn.DataSource = this.surfaceBindingSource;
            this.surfaceIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.surfaceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.surfaceIDDataGridViewTextBoxColumn.HeaderText = "Surface";
            this.surfaceIDDataGridViewTextBoxColumn.Name = "surfaceIDDataGridViewTextBoxColumn";
            this.surfaceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataSource = typeof(OrdersHandling.Surface);
            // 
            // pcsDataGridViewTextBoxColumn
            // 
            this.pcsDataGridViewTextBoxColumn.DataPropertyName = "Pcs";
            this.pcsDataGridViewTextBoxColumn.HeaderText = "Pcs";
            this.pcsDataGridViewTextBoxColumn.Name = "pcsDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            // 
            // MU
            // 
            this.MU.DataPropertyName = "MU";
            this.MU.DataSource = this.mUBindingSource;
            this.MU.DisplayMember = "MuName";
            this.MU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MU.HeaderText = "MU";
            this.MU.Name = "MU";
            this.MU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MU.ValueMember = "MuID";
            // 
            // mUBindingSource
            // 
            this.mUBindingSource.DataSource = typeof(OrdersHandling.MU);
            // 
            // remainingQTYDataGridViewTextBoxColumn
            // 
            this.remainingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.HeaderText = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.Name = "remainingQTYDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // isForCoatingDataGridViewTextBoxColumn
            // 
            this.isForCoatingDataGridViewTextBoxColumn.DataPropertyName = "IsForCoating";
            this.isForCoatingDataGridViewTextBoxColumn.FalseValue = "0";
            this.isForCoatingDataGridViewTextBoxColumn.HeaderText = "Coating";
            this.isForCoatingDataGridViewTextBoxColumn.Name = "isForCoatingDataGridViewTextBoxColumn";
            this.isForCoatingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isForCoatingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isForCoatingDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // sqmCorrectionsDataGridViewTextBoxColumn
            // 
            this.sqmCorrectionsDataGridViewTextBoxColumn.DataPropertyName = "SqmCorrections";
            this.sqmCorrectionsDataGridViewTextBoxColumn.HeaderText = "Corrections";
            this.sqmCorrectionsDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.sqmCorrectionsDataGridViewTextBoxColumn.Name = "sqmCorrectionsDataGridViewTextBoxColumn";
            // 
            // thermoFilmDataGridViewTextBoxColumn
            // 
            this.thermoFilmDataGridViewTextBoxColumn.DataPropertyName = "ThermoFilm";
            this.thermoFilmDataGridViewTextBoxColumn.HeaderText = "ThermoFilm";
            this.thermoFilmDataGridViewTextBoxColumn.Name = "thermoFilmDataGridViewTextBoxColumn";
            // 
            // protectiveFilmDataGridViewTextBoxColumn
            // 
            this.protectiveFilmDataGridViewTextBoxColumn.DataPropertyName = "ProtectiveFilm";
            this.protectiveFilmDataGridViewTextBoxColumn.HeaderText = "ProtectiveFilm";
            this.protectiveFilmDataGridViewTextBoxColumn.Name = "protectiveFilmDataGridViewTextBoxColumn";
            // 
            // thermoFilmPriceDataGridViewTextBoxColumn
            // 
            this.thermoFilmPriceDataGridViewTextBoxColumn.DataPropertyName = "ThermoFilmPrice";
            this.thermoFilmPriceDataGridViewTextBoxColumn.HeaderText = "ThermoFilmPrice";
            this.thermoFilmPriceDataGridViewTextBoxColumn.Name = "thermoFilmPriceDataGridViewTextBoxColumn";
            // 
            // protectionFilmPriceDataGridViewTextBoxColumn
            // 
            this.protectionFilmPriceDataGridViewTextBoxColumn.DataPropertyName = "ProtectionFilmPrice";
            this.protectionFilmPriceDataGridViewTextBoxColumn.HeaderText = "ProtectionFilmPrice";
            this.protectionFilmPriceDataGridViewTextBoxColumn.Name = "protectionFilmPriceDataGridViewTextBoxColumn";
            // 
            // perimeterDataGridViewTextBoxColumn
            // 
            this.perimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.HeaderText = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.Name = "perimeterDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderLinesBindingSource
            // 
            this.orderLinesBindingSource.DataSource = typeof(OrdersHandling.OrderLines);
            // 
            // btnEditLines
            // 
            this.btnEditLines.Location = new System.Drawing.Point(13, 268);
            this.btnEditLines.Name = "btnEditLines";
            this.btnEditLines.Size = new System.Drawing.Size(75, 23);
            this.btnEditLines.TabIndex = 17;
            this.btnEditLines.Text = "Edit Lines";
            this.btnEditLines.UseVisualStyleBackColor = true;
            this.btnEditLines.Click += new System.EventHandler(this.btnEditLines_Click);
            // 
            // cmbPartnerName
            // 
            this.cmbPartnerName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Customer_ID", true));
            this.cmbPartnerName.DataSource = this.partnersBindingSource;
            this.cmbPartnerName.DisplayMember = "Partner_name";
            this.cmbPartnerName.FormattingEnabled = true;
            this.cmbPartnerName.Location = new System.Drawing.Point(1057, 13);
            this.cmbPartnerName.Name = "cmbPartnerName";
            this.cmbPartnerName.Size = new System.Drawing.Size(277, 21);
            this.cmbPartnerName.TabIndex = 18;
            this.cmbPartnerName.ValueMember = "ID";
            this.cmbPartnerName.Visible = false;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(OrdersHandling.Partners);
            // 
            // frmOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 673);
            this.Controls.Add(this.cmbPartnerName);
            this.Controls.Add(this.btnEditLines);
            this.Controls.Add(this.dgvOrderLines);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.chkboxOffer);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.grpSaveCancel);
            this.Controls.Add(this.grpColorPowder);
            this.Controls.Add(this.lblForeignID);
            this.Controls.Add(this.lblOrderRealNumber);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.dateTimeDate);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.lblOrderNumber);
            this.Name = "frmOrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.frmOrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.grpColorPowder.ResumeLayout(false);
            this.grpColorPowder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            this.grpSaveCancel.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderRealNumber;
        private System.Windows.Forms.Label lblForeignID;
        private System.Windows.Forms.GroupBox grpColorPowder;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox grpSaveCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbPowder;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private System.Windows.Forms.Label lblPowder;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.CheckBox chkboxOffer;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.CheckBox chkBoxCompleated;
        private System.Windows.Forms.CheckBox chkBoxReady;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.DateTimePicker dateTimeExpectedDate;
        private System.Windows.Forms.Label lblExpectedMatDate;
        private System.Windows.Forms.DateTimePicker dateTimeReqDate;
        private System.Windows.Forms.Label lblReqDate;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        private System.Windows.Forms.BindingSource orderLinesBindingSource;
        private System.Windows.Forms.BindingSource codesBindingSource1;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        private System.Windows.Forms.Button btnEditLines;
        private System.Windows.Forms.BindingSource mUBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CodeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MU;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isForCoatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqmCorrectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thermoFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protectiveFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thermoFilmPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protectionFilmPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbPartnerName;
        private System.Windows.Forms.BindingSource partnersBindingSource;
    }
}