
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
            this.protectiveFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remainingQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isForCoatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thermoFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sqmCorrectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thermoFilmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protectionFilmPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtySqm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyKgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditLines = new System.Windows.Forms.Button();
            this.cmbPartnerName = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblValueSum = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblKgrSum = new System.Windows.Forms.Label();
            this.lblKgr = new System.Windows.Forms.Label();
            this.lblSqmSum = new System.Windows.Forms.Label();
            this.lblSQM = new System.Windows.Forms.Label();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadedFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpload = new System.Windows.Forms.Button();
            this.uploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpCurrentRowInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumSelectedKgr = new System.Windows.Forms.Label();
            this.lblSqmSelectedSum = new System.Windows.Forms.Label();
            this.lblKgrSelectedSum = new System.Windows.Forms.Label();
            this.lblCurrentRowKgrValue = new System.Windows.Forms.Label();
            this.lblCurrentRowKgrLabel = new System.Windows.Forms.Label();
            this.lblCurrentSqmValue = new System.Windows.Forms.Label();
            this.lblCurrentRowSqmLabel = new System.Windows.Forms.Label();
            this.btnAttachmentRemove = new System.Windows.Forms.Button();
            this.btnExportExel = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesBindingSource)).BeginInit();
            this.grpCurrentRowInfo.SuspendLayout();
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
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.grpColorPowder.Size = new System.Drawing.Size(328, 80);
            this.grpColorPowder.TabIndex = 6;
            this.grpColorPowder.TabStop = false;
            this.grpColorPowder.Text = "Color-Powder";
            // 
            // cmbPowder
            // 
            this.cmbPowder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPowder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPowder.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Powder_Code", true));
            this.cmbPowder.DataSource = this.codesBindingSource;
            this.cmbPowder.DisplayMember = "Code";
            this.cmbPowder.FormattingEnabled = true;
            this.cmbPowder.Location = new System.Drawing.Point(151, 39);
            this.cmbPowder.Name = "cmbPowder";
            this.cmbPowder.Size = new System.Drawing.Size(171, 21);
            this.cmbPowder.TabIndex = 4;
            this.cmbPowder.ValueMember = "ID";
            this.cmbPowder.SelectedIndexChanged += new System.EventHandler(this.cmbPowder_SelectedIndexChanged);
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataSource = typeof(OrdersHandling.Codes);
            // 
            // lblPowder
            // 
            this.lblPowder.AutoSize = true;
            this.lblPowder.Location = new System.Drawing.Point(151, 22);
            this.lblPowder.Name = "lblPowder";
            this.lblPowder.Size = new System.Drawing.Size(71, 13);
            this.lblPowder.TabIndex = 3;
            this.lblPowder.Text = "Powder Code";
            this.lblPowder.DoubleClick += new System.EventHandler(this.lblPowder_DoubleClick);
            // 
            // cmbColor
            // 
            this.cmbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbColor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "RALID", true));
            this.cmbColor.DataSource = this.colorsBindingSource;
            this.cmbColor.DisplayMember = "ColorName";
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(6, 39);
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
            this.lblColor.Location = new System.Drawing.Point(7, 23);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            this.lblColor.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
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
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.txtProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Project", true));
            this.txtProject.Location = new System.Drawing.Point(482, 188);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(306, 13);
            this.txtProject.TabIndex = 11;
            // 
            // chkboxOffer
            // 
            this.chkboxOffer.AutoSize = true;
            this.chkboxOffer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxOffer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ordersBindingSource, "IsOffer", true));
            this.chkboxOffer.Enabled = false;
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
            this.chkBoxCompleated.Enabled = false;
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
            this.chkBoxReady.Enabled = false;
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
            this.grpDates.Size = new System.Drawing.Size(328, 63);
            this.grpDates.TabIndex = 15;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "Dates";
            // 
            // dateTimeExpectedDate
            // 
            this.dateTimeExpectedDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ExpectedMatDate", true));
            this.dateTimeExpectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpectedDate.Location = new System.Drawing.Point(169, 30);
            this.dateTimeExpectedDate.Name = "dateTimeExpectedDate";
            this.dateTimeExpectedDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimeExpectedDate.TabIndex = 3;
            this.dateTimeExpectedDate.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimeExpectedDate.ValueChanged += new System.EventHandler(this.dateTimeExpectedDate_ValueChanged);
            // 
            // lblExpectedMatDate
            // 
            this.lblExpectedMatDate.AutoSize = true;
            this.lblExpectedMatDate.Location = new System.Drawing.Point(166, 14);
            this.lblExpectedMatDate.Name = "lblExpectedMatDate";
            this.lblExpectedMatDate.Size = new System.Drawing.Size(133, 13);
            this.lblExpectedMatDate.TabIndex = 2;
            this.lblExpectedMatDate.Text = "Expected Material Delivery";
            // 
            // dateTimeReqDate
            // 
            this.dateTimeReqDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "Req_date", true));
            this.dateTimeReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.dgvOrderLines.AllowUserToDeleteRows = false;
            this.dgvOrderLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderLines.AutoGenerateColumns = false;
            this.dgvOrderLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderLines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.protectiveFilmDataGridViewTextBoxColumn,
            this.remainingQTYDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.isForCoatingDataGridViewTextBoxColumn,
            this.thermoFilmDataGridViewTextBoxColumn,
            this.sqmCorrectionsDataGridViewTextBoxColumn,
            this.thermoFilmPriceDataGridViewTextBoxColumn,
            this.protectionFilmPriceDataGridViewTextBoxColumn,
            this.perimeterDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.QtySqm,
            this.QtyKgr});
            this.dgvOrderLines.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrderLines.DataSource = this.orderLinesBindingSource;
            this.dgvOrderLines.Location = new System.Drawing.Point(12, 327);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.RowHeadersWidth = 20;
            this.dgvOrderLines.Size = new System.Drawing.Size(1322, 334);
            this.dgvOrderLines.TabIndex = 16;
            this.dgvOrderLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderLines_CellDoubleClick);
            this.dgvOrderLines.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderLines_CellMouseClick);
            this.dgvOrderLines.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderLines_CellMouseDown);
            this.dgvOrderLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderLines_CellValueChanged);
            this.dgvOrderLines.CurrentCellChanged += new System.EventHandler(this.dgvOrderLines_CurrentCellChanged);
            this.dgvOrderLines.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvOrderLines_PreviewKeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            this.orderIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // codeIDDataGridViewTextBoxColumn
            // 
            this.codeIDDataGridViewTextBoxColumn.DataPropertyName = "CodeID";
            this.codeIDDataGridViewTextBoxColumn.DataSource = this.codesBindingSource1;
            this.codeIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.codeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeIDDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.codeIDDataGridViewTextBoxColumn.Name = "codeIDDataGridViewTextBoxColumn";
            this.codeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.codeIDDataGridViewTextBoxColumn.Width = 200;
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
            this.CodeID.MinimumWidth = 10;
            this.CodeID.Name = "CodeID";
            this.CodeID.ValueMember = "ID";
            this.CodeID.Width = 200;
            // 
            // surfaceIDDataGridViewTextBoxColumn
            // 
            this.surfaceIDDataGridViewTextBoxColumn.DataPropertyName = "SurfaceID";
            this.surfaceIDDataGridViewTextBoxColumn.DataSource = this.surfaceBindingSource;
            this.surfaceIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.surfaceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.surfaceIDDataGridViewTextBoxColumn.HeaderText = "Surface";
            this.surfaceIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.surfaceIDDataGridViewTextBoxColumn.Name = "surfaceIDDataGridViewTextBoxColumn";
            this.surfaceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.surfaceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.surfaceIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.surfaceIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataSource = typeof(OrdersHandling.Surface);
            // 
            // pcsDataGridViewTextBoxColumn
            // 
            this.pcsDataGridViewTextBoxColumn.DataPropertyName = "Pcs";
            this.pcsDataGridViewTextBoxColumn.HeaderText = "Pcs";
            this.pcsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pcsDataGridViewTextBoxColumn.Name = "pcsDataGridViewTextBoxColumn";
            this.pcsDataGridViewTextBoxColumn.Width = 50;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Width = 50;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTYDataGridViewTextBoxColumn.Width = 50;
            // 
            // MU
            // 
            this.MU.DataPropertyName = "MU";
            this.MU.DataSource = this.mUBindingSource;
            this.MU.DisplayMember = "MuName";
            this.MU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MU.HeaderText = "MU";
            this.MU.MinimumWidth = 10;
            this.MU.Name = "MU";
            this.MU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MU.ValueMember = "MuID";
            this.MU.Width = 50;
            // 
            // mUBindingSource
            // 
            this.mUBindingSource.DataSource = typeof(OrdersHandling.MU);
            // 
            // protectiveFilmDataGridViewTextBoxColumn
            // 
            this.protectiveFilmDataGridViewTextBoxColumn.DataPropertyName = "ProtectiveFilm";
            this.protectiveFilmDataGridViewTextBoxColumn.FalseValue = "0";
            this.protectiveFilmDataGridViewTextBoxColumn.HeaderText = "Protective Film";
            this.protectiveFilmDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.protectiveFilmDataGridViewTextBoxColumn.Name = "protectiveFilmDataGridViewTextBoxColumn";
            this.protectiveFilmDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.protectiveFilmDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.protectiveFilmDataGridViewTextBoxColumn.TrueValue = "1";
            this.protectiveFilmDataGridViewTextBoxColumn.Width = 70;
            // 
            // remainingQTYDataGridViewTextBoxColumn
            // 
            this.remainingQTYDataGridViewTextBoxColumn.DataPropertyName = "RemainingQTY";
            this.remainingQTYDataGridViewTextBoxColumn.HeaderText = "Remaining QTY";
            this.remainingQTYDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.remainingQTYDataGridViewTextBoxColumn.Name = "remainingQTYDataGridViewTextBoxColumn";
            this.remainingQTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingQTYDataGridViewTextBoxColumn.Width = 70;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Width = 50;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // isForCoatingDataGridViewTextBoxColumn
            // 
            this.isForCoatingDataGridViewTextBoxColumn.DataPropertyName = "IsForCoating";
            this.isForCoatingDataGridViewTextBoxColumn.FalseValue = "0";
            this.isForCoatingDataGridViewTextBoxColumn.HeaderText = "Coating";
            this.isForCoatingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.isForCoatingDataGridViewTextBoxColumn.Name = "isForCoatingDataGridViewTextBoxColumn";
            this.isForCoatingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isForCoatingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isForCoatingDataGridViewTextBoxColumn.TrueValue = "1";
            this.isForCoatingDataGridViewTextBoxColumn.Width = 50;
            // 
            // thermoFilmDataGridViewTextBoxColumn
            // 
            this.thermoFilmDataGridViewTextBoxColumn.DataPropertyName = "ThermoFilm";
            this.thermoFilmDataGridViewTextBoxColumn.FalseValue = "0";
            this.thermoFilmDataGridViewTextBoxColumn.HeaderText = "Thermo Film";
            this.thermoFilmDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.thermoFilmDataGridViewTextBoxColumn.Name = "thermoFilmDataGridViewTextBoxColumn";
            this.thermoFilmDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thermoFilmDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thermoFilmDataGridViewTextBoxColumn.TrueValue = "1";
            this.thermoFilmDataGridViewTextBoxColumn.Width = 50;
            // 
            // sqmCorrectionsDataGridViewTextBoxColumn
            // 
            this.sqmCorrectionsDataGridViewTextBoxColumn.DataPropertyName = "SqmCorrections";
            this.sqmCorrectionsDataGridViewTextBoxColumn.HeaderText = "Corrections";
            this.sqmCorrectionsDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.sqmCorrectionsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sqmCorrectionsDataGridViewTextBoxColumn.Name = "sqmCorrectionsDataGridViewTextBoxColumn";
            this.sqmCorrectionsDataGridViewTextBoxColumn.Width = 70;
            // 
            // thermoFilmPriceDataGridViewTextBoxColumn
            // 
            this.thermoFilmPriceDataGridViewTextBoxColumn.DataPropertyName = "ThermoFilmPrice";
            this.thermoFilmPriceDataGridViewTextBoxColumn.HeaderText = "Thermo Film Price";
            this.thermoFilmPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.thermoFilmPriceDataGridViewTextBoxColumn.Name = "thermoFilmPriceDataGridViewTextBoxColumn";
            this.thermoFilmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.thermoFilmPriceDataGridViewTextBoxColumn.Width = 50;
            // 
            // protectionFilmPriceDataGridViewTextBoxColumn
            // 
            this.protectionFilmPriceDataGridViewTextBoxColumn.DataPropertyName = "ProtectionFilmPrice";
            this.protectionFilmPriceDataGridViewTextBoxColumn.HeaderText = "Protection Film Price";
            this.protectionFilmPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.protectionFilmPriceDataGridViewTextBoxColumn.Name = "protectionFilmPriceDataGridViewTextBoxColumn";
            this.protectionFilmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.protectionFilmPriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // perimeterDataGridViewTextBoxColumn
            // 
            this.perimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.HeaderText = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.perimeterDataGridViewTextBoxColumn.Name = "perimeterDataGridViewTextBoxColumn";
            this.perimeterDataGridViewTextBoxColumn.ReadOnly = true;
            this.perimeterDataGridViewTextBoxColumn.Width = 70;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 70;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // QtySqm
            // 
            this.QtySqm.DataPropertyName = "QtySqm";
            this.QtySqm.HeaderText = "QtySqm";
            this.QtySqm.MinimumWidth = 10;
            this.QtySqm.Name = "QtySqm";
            this.QtySqm.Width = 200;
            // 
            // QtyKgr
            // 
            this.QtyKgr.DataPropertyName = "QtyKgr";
            this.QtyKgr.HeaderText = "QtyKgr";
            this.QtyKgr.MinimumWidth = 10;
            this.QtyKgr.Name = "QtyKgr";
            this.QtyKgr.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvContextMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Paste";
            // 
            // orderLinesBindingSource
            // 
            this.orderLinesBindingSource.DataSource = typeof(OrdersHandling.OrderLines);
            // 
            // btnEditLines
            // 
            this.btnEditLines.Location = new System.Drawing.Point(12, 298);
            this.btnEditLines.Name = "btnEditLines";
            this.btnEditLines.Size = new System.Drawing.Size(75, 23);
            this.btnEditLines.TabIndex = 17;
            this.btnEditLines.Text = "Edit Lines";
            this.btnEditLines.UseVisualStyleBackColor = true;
            this.btnEditLines.Click += new System.EventHandler(this.btnEditLines_Click);
            // 
            // cmbPartnerName
            // 
            this.cmbPartnerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPartnerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPartnerName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Customer_ID", true));
            this.cmbPartnerName.DataSource = this.partnersBindingSource;
            this.cmbPartnerName.DisplayMember = "Partner_name";
            this.cmbPartnerName.Enabled = false;
            this.cmbPartnerName.FormattingEnabled = true;
            this.cmbPartnerName.Location = new System.Drawing.Point(1057, 13);
            this.cmbPartnerName.Name = "cmbPartnerName";
            this.cmbPartnerName.Size = new System.Drawing.Size(277, 21);
            this.cmbPartnerName.TabIndex = 18;
            this.cmbPartnerName.ValueMember = "ID";
            this.cmbPartnerName.SelectedIndexChanged += new System.EventHandler(this.cmbPartnerName_SelectedIndexChanged);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(OrdersHandling.Partners);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblValueSum);
            this.grpInfo.Controls.Add(this.lblValue);
            this.grpInfo.Controls.Add(this.lblKgrSum);
            this.grpInfo.Controls.Add(this.lblKgr);
            this.grpInfo.Controls.Add(this.lblSqmSum);
            this.grpInfo.Controls.Add(this.lblSQM);
            this.grpInfo.Location = new System.Drawing.Point(794, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(257, 97);
            this.grpInfo.TabIndex = 19;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information Panel";
            // 
            // lblValueSum
            // 
            this.lblValueSum.AutoSize = true;
            this.lblValueSum.Location = new System.Drawing.Point(95, 67);
            this.lblValueSum.Name = "lblValueSum";
            this.lblValueSum.Size = new System.Drawing.Size(13, 13);
            this.lblValueSum.TabIndex = 5;
            this.lblValueSum.Text = "?";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(49, 67);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 13);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value :";
            // 
            // lblKgrSum
            // 
            this.lblKgrSum.AutoSize = true;
            this.lblKgrSum.Location = new System.Drawing.Point(95, 44);
            this.lblKgrSum.Name = "lblKgrSum";
            this.lblKgrSum.Size = new System.Drawing.Size(13, 13);
            this.lblKgrSum.TabIndex = 3;
            this.lblKgrSum.Text = "?";
            // 
            // lblKgr
            // 
            this.lblKgr.AutoSize = true;
            this.lblKgr.Location = new System.Drawing.Point(31, 43);
            this.lblKgr.Name = "lblKgr";
            this.lblKgr.Size = new System.Drawing.Size(58, 13);
            this.lblKgr.TabIndex = 2;
            this.lblKgr.Text = "Kilograms :";
            // 
            // lblSqmSum
            // 
            this.lblSqmSum.AutoSize = true;
            this.lblSqmSum.Location = new System.Drawing.Point(95, 23);
            this.lblSqmSum.Name = "lblSqmSum";
            this.lblSqmSum.Size = new System.Drawing.Size(13, 13);
            this.lblSqmSum.TabIndex = 1;
            this.lblSqmSum.Text = "?";
            // 
            // lblSQM
            // 
            this.lblSQM.AutoSize = true;
            this.lblSQM.Location = new System.Drawing.Point(7, 23);
            this.lblSQM.Name = "lblSQM";
            this.lblSQM.Size = new System.Drawing.Size(82, 13);
            this.lblSQM.TabIndex = 0;
            this.lblSQM.Text = "Square Meters :";
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttachments.AutoGenerateColumns = false;
            this.dgvAttachments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttachments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn});
            this.dgvAttachments.DataSource = this.uploadedFilesBindingSource;
            this.dgvAttachments.Location = new System.Drawing.Point(1057, 57);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.ReadOnly = true;
            this.dgvAttachments.RowHeadersWidth = 20;
            this.dgvAttachments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttachments.Size = new System.Drawing.Size(277, 194);
            this.dgvAttachments.TabIndex = 20;
            this.dgvAttachments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachments_CellDoubleClick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // uploadedFilesBindingSource
            // 
            this.uploadedFilesBindingSource.DataSource = typeof(OrdersHandling.UploadedFiles);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(1057, 257);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // uploadFileDialog
            // 
            this.uploadFileDialog.FileName = "openFileDialog1";
            this.uploadFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.uploadFileDialog_FileOk);
            // 
            // grpCurrentRowInfo
            // 
            this.grpCurrentRowInfo.Controls.Add(this.label1);
            this.grpCurrentRowInfo.Controls.Add(this.lblSumSelectedKgr);
            this.grpCurrentRowInfo.Controls.Add(this.lblSqmSelectedSum);
            this.grpCurrentRowInfo.Controls.Add(this.lblKgrSelectedSum);
            this.grpCurrentRowInfo.Controls.Add(this.lblCurrentRowKgrValue);
            this.grpCurrentRowInfo.Controls.Add(this.lblCurrentRowKgrLabel);
            this.grpCurrentRowInfo.Controls.Add(this.lblCurrentSqmValue);
            this.grpCurrentRowInfo.Controls.Add(this.lblCurrentRowSqmLabel);
            this.grpCurrentRowInfo.Location = new System.Drawing.Point(93, 258);
            this.grpCurrentRowInfo.Name = "grpCurrentRowInfo";
            this.grpCurrentRowInfo.Size = new System.Drawing.Size(379, 63);
            this.grpCurrentRowInfo.TabIndex = 22;
            this.grpCurrentRowInfo.TabStop = false;
            this.grpCurrentRowInfo.Text = "Current Row Information Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sum of Square meters :";
            // 
            // lblSumSelectedKgr
            // 
            this.lblSumSelectedKgr.AutoSize = true;
            this.lblSumSelectedKgr.Location = new System.Drawing.Point(199, 40);
            this.lblSumSelectedKgr.Name = "lblSumSelectedKgr";
            this.lblSumSelectedKgr.Size = new System.Drawing.Size(94, 13);
            this.lblSumSelectedKgr.TabIndex = 6;
            this.lblSumSelectedKgr.Text = "Sum of Kilograms :";
            // 
            // lblSqmSelectedSum
            // 
            this.lblSqmSelectedSum.AutoSize = true;
            this.lblSqmSelectedSum.Location = new System.Drawing.Point(126, 40);
            this.lblSqmSelectedSum.Name = "lblSqmSelectedSum";
            this.lblSqmSelectedSum.Size = new System.Drawing.Size(13, 13);
            this.lblSqmSelectedSum.TabIndex = 5;
            this.lblSqmSelectedSum.Text = "?";
            // 
            // lblKgrSelectedSum
            // 
            this.lblKgrSelectedSum.AutoSize = true;
            this.lblKgrSelectedSum.Location = new System.Drawing.Point(295, 41);
            this.lblKgrSelectedSum.Name = "lblKgrSelectedSum";
            this.lblKgrSelectedSum.Size = new System.Drawing.Size(13, 13);
            this.lblKgrSelectedSum.TabIndex = 4;
            this.lblKgrSelectedSum.Text = "?";
            // 
            // lblCurrentRowKgrValue
            // 
            this.lblCurrentRowKgrValue.AutoSize = true;
            this.lblCurrentRowKgrValue.Location = new System.Drawing.Point(295, 21);
            this.lblCurrentRowKgrValue.Name = "lblCurrentRowKgrValue";
            this.lblCurrentRowKgrValue.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentRowKgrValue.TabIndex = 3;
            this.lblCurrentRowKgrValue.Text = "?";
            // 
            // lblCurrentRowKgrLabel
            // 
            this.lblCurrentRowKgrLabel.AutoSize = true;
            this.lblCurrentRowKgrLabel.Location = new System.Drawing.Point(235, 20);
            this.lblCurrentRowKgrLabel.Name = "lblCurrentRowKgrLabel";
            this.lblCurrentRowKgrLabel.Size = new System.Drawing.Size(61, 13);
            this.lblCurrentRowKgrLabel.TabIndex = 2;
            this.lblCurrentRowKgrLabel.Text = "Kilograms : ";
            // 
            // lblCurrentSqmValue
            // 
            this.lblCurrentSqmValue.AutoSize = true;
            this.lblCurrentSqmValue.Location = new System.Drawing.Point(126, 22);
            this.lblCurrentSqmValue.Name = "lblCurrentSqmValue";
            this.lblCurrentSqmValue.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentSqmValue.TabIndex = 1;
            this.lblCurrentSqmValue.Text = "?";
            // 
            // lblCurrentRowSqmLabel
            // 
            this.lblCurrentRowSqmLabel.AutoSize = true;
            this.lblCurrentRowSqmLabel.Location = new System.Drawing.Point(43, 20);
            this.lblCurrentRowSqmLabel.Name = "lblCurrentRowSqmLabel";
            this.lblCurrentRowSqmLabel.Size = new System.Drawing.Size(84, 13);
            this.lblCurrentRowSqmLabel.TabIndex = 0;
            this.lblCurrentRowSqmLabel.Text = "Square meters : ";
            // 
            // btnAttachmentRemove
            // 
            this.btnAttachmentRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachmentRemove.Location = new System.Drawing.Point(1259, 258);
            this.btnAttachmentRemove.Name = "btnAttachmentRemove";
            this.btnAttachmentRemove.Size = new System.Drawing.Size(75, 23);
            this.btnAttachmentRemove.TabIndex = 23;
            this.btnAttachmentRemove.Text = "Remove";
            this.btnAttachmentRemove.UseVisualStyleBackColor = true;
            this.btnAttachmentRemove.Click += new System.EventHandler(this.btnAttachmentRemove_Click);
            // 
            // btnExportExel
            // 
            this.btnExportExel.Location = new System.Drawing.Point(478, 298);
            this.btnExportExel.Name = "btnExportExel";
            this.btnExportExel.Size = new System.Drawing.Size(83, 23);
            this.btnExportExel.TabIndex = 24;
            this.btnExportExel.Text = "Export to Exel";
            this.btnExportExel.UseVisualStyleBackColor = true;
            this.btnExportExel.Click += new System.EventHandler(this.btnExportExel_Click);
            // 
            // frmOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 676);
            this.Controls.Add(this.btnExportExel);
            this.Controls.Add(this.btnAttachmentRemove);
            this.Controls.Add(this.grpCurrentRowInfo);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgvAttachments);
            this.Controls.Add(this.grpInfo);
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesBindingSource)).EndInit();
            this.grpCurrentRowInfo.ResumeLayout(false);
            this.grpCurrentRowInfo.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbPartnerName;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblSqmSum;
        private System.Windows.Forms.Label lblSQM;
        private System.Windows.Forms.Label lblKgrSum;
        private System.Windows.Forms.Label lblKgr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.BindingSource uploadedFilesBindingSource;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog uploadFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grpCurrentRowInfo;
        private System.Windows.Forms.Label lblCurrentRowKgrValue;
        private System.Windows.Forms.Label lblCurrentRowKgrLabel;
        private System.Windows.Forms.Label lblCurrentSqmValue;
        private System.Windows.Forms.Label lblCurrentRowSqmLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CodeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn surfaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MU;
        private System.Windows.Forms.DataGridViewCheckBoxColumn protectiveFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isForCoatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thermoFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqmCorrectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thermoFilmPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protectionFilmPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtySqm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyKgr;
        private System.Windows.Forms.Label lblSqmSelectedSum;
        private System.Windows.Forms.Label lblKgrSelectedSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSumSelectedKgr;
        private System.Windows.Forms.Button btnAttachmentRemove;
        private System.Windows.Forms.Button btnExportExel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblValueSum;
        private System.Windows.Forms.Label lblValue;
    }
}