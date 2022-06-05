
namespace OrdersHandling
{
    partial class frmCodesList
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
            this.dgvCodesList = new System.Windows.Forms.DataGridView();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.btnClearTypeFilter = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.perimeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultSurface = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.defaultMUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.systemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PF = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TF = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coatingGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreignIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCodesList
            // 
            this.dgvCodesList.AllowUserToAddRows = false;
            this.dgvCodesList.AllowUserToDeleteRows = false;
            this.dgvCodesList.AutoGenerateColumns = false;
            this.dgvCodesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.perimeterDataGridViewTextBoxColumn,
            this.weigthDataGridViewTextBoxColumn,
            this.DefaultLength,
            this.DefaultSurface,
            this.subTypeDataGridViewTextBoxColumn,
            this.defaultMUDataGridViewTextBoxColumn,
            this.systemDataGridViewTextBoxColumn,
            this.PF,
            this.TF,
            this.secondCodeDataGridViewTextBoxColumn,
            this.defaultSupplierDataGridViewTextBoxColumn,
            this.coatingGroupDataGridViewTextBoxColumn,
            this.foreignIDDataGridViewTextBoxColumn});
            this.dgvCodesList.DataSource = this.codesBindingSource;
            this.dgvCodesList.Location = new System.Drawing.Point(13, 77);
            this.dgvCodesList.Name = "dgvCodesList";
            this.dgvCodesList.RowHeadersWidth = 20;
            this.dgvCodesList.Size = new System.Drawing.Size(1297, 346);
            this.dgvCodesList.TabIndex = 0;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataSource = typeof(OrdersHandling.Types);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(OrdersHandling.Category);
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataSource = typeof(OrdersHandling.Surface);
            // 
            // subTypesBindingSource
            // 
            this.subTypesBindingSource.DataSource = typeof(OrdersHandling.SubTypes);
            // 
            // mUBindingSource
            // 
            this.mUBindingSource.DataSource = typeof(OrdersHandling.MU);
            // 
            // systemsBindingSource
            // 
            this.systemsBindingSource.DataSource = typeof(OrdersHandling.Systems);
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataSource = typeof(OrdersHandling.Partners);
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataSource = typeof(OrdersHandling.Codes);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(13, 430);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 61);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Добави";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(85, 430);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 61);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Изтрий";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1246, 430);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Запази";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFilterType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFilterType.DataSource = this.typesBindingSource;
            this.cmbFilterType.DisplayMember = "TypeName";
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(233, 50);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(102, 21);
            this.cmbFilterType.TabIndex = 13;
            this.cmbFilterType.ValueMember = "TypeID";
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // btnClearTypeFilter
            // 
            this.btnClearTypeFilter.Location = new System.Drawing.Point(233, 21);
            this.btnClearTypeFilter.Name = "btnClearTypeFilter";
            this.btnClearTypeFilter.Size = new System.Drawing.Size(102, 23);
            this.btnClearTypeFilter.TabIndex = 14;
            this.btnClearTypeFilter.Text = "Clear Filter";
            this.btnClearTypeFilter.UseVisualStyleBackColor = true;
            this.btnClearTypeFilter.Click += new System.EventHandler(this.btnClearTypeFilter_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.typesBindingSource;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.typeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип на кода";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "TypeID";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.DataSource = this.categoryBindingSource;
            this.categoryDataGridViewTextBoxColumn.DisplayMember = "CatName";
            this.categoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryDataGridViewTextBoxColumn.ValueMember = "CatID";
            // 
            // perimeterDataGridViewTextBoxColumn
            // 
            this.perimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.HeaderText = "Периметър";
            this.perimeterDataGridViewTextBoxColumn.Name = "perimeterDataGridViewTextBoxColumn";
            // 
            // weigthDataGridViewTextBoxColumn
            // 
            this.weigthDataGridViewTextBoxColumn.DataPropertyName = "Weigth";
            this.weigthDataGridViewTextBoxColumn.HeaderText = "Тегло";
            this.weigthDataGridViewTextBoxColumn.Name = "weigthDataGridViewTextBoxColumn";
            // 
            // DefaultLength
            // 
            this.DefaultLength.DataPropertyName = "DefaultLength";
            this.DefaultLength.HeaderText = "Дължина";
            this.DefaultLength.MaxInputLength = 10;
            this.DefaultLength.Name = "DefaultLength";
            // 
            // DefaultSurface
            // 
            this.DefaultSurface.DataPropertyName = "DefaultSurface";
            this.DefaultSurface.DataSource = this.surfaceBindingSource;
            this.DefaultSurface.DisplayMember = "Name";
            this.DefaultSurface.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DefaultSurface.HeaderText = "Повърхност";
            this.DefaultSurface.Name = "DefaultSurface";
            this.DefaultSurface.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DefaultSurface.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DefaultSurface.ValueMember = "ID";
            // 
            // subTypeDataGridViewTextBoxColumn
            // 
            this.subTypeDataGridViewTextBoxColumn.DataPropertyName = "SubType";
            this.subTypeDataGridViewTextBoxColumn.DataSource = this.subTypesBindingSource;
            this.subTypeDataGridViewTextBoxColumn.DisplayMember = "SubTypeName";
            this.subTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.subTypeDataGridViewTextBoxColumn.HeaderText = "Под-тип";
            this.subTypeDataGridViewTextBoxColumn.Name = "subTypeDataGridViewTextBoxColumn";
            this.subTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subTypeDataGridViewTextBoxColumn.ValueMember = "SubTypeID";
            // 
            // defaultMUDataGridViewTextBoxColumn
            // 
            this.defaultMUDataGridViewTextBoxColumn.DataPropertyName = "DefaultMU";
            this.defaultMUDataGridViewTextBoxColumn.DataSource = this.mUBindingSource;
            this.defaultMUDataGridViewTextBoxColumn.DisplayMember = "MuName";
            this.defaultMUDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultMUDataGridViewTextBoxColumn.HeaderText = "МЕ";
            this.defaultMUDataGridViewTextBoxColumn.Name = "defaultMUDataGridViewTextBoxColumn";
            this.defaultMUDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultMUDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultMUDataGridViewTextBoxColumn.ValueMember = "MuID";
            // 
            // systemDataGridViewTextBoxColumn
            // 
            this.systemDataGridViewTextBoxColumn.DataPropertyName = "System";
            this.systemDataGridViewTextBoxColumn.DataSource = this.systemsBindingSource;
            this.systemDataGridViewTextBoxColumn.DisplayMember = "SystemName";
            this.systemDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.systemDataGridViewTextBoxColumn.HeaderText = "Система";
            this.systemDataGridViewTextBoxColumn.Name = "systemDataGridViewTextBoxColumn";
            this.systemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.systemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.systemDataGridViewTextBoxColumn.ValueMember = "SystemID";
            // 
            // PF
            // 
            this.PF.DataPropertyName = "PF";
            this.PF.FalseValue = "0";
            this.PF.HeaderText = "Protective Film";
            this.PF.Name = "PF";
            this.PF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PF.TrueValue = "1";
            // 
            // TF
            // 
            this.TF.DataPropertyName = "TF";
            this.TF.FalseValue = "0";
            this.TF.HeaderText = "Thermo Film";
            this.TF.Name = "TF";
            this.TF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TF.TrueValue = "1";
            // 
            // secondCodeDataGridViewTextBoxColumn
            // 
            this.secondCodeDataGridViewTextBoxColumn.DataPropertyName = "SecondCode";
            this.secondCodeDataGridViewTextBoxColumn.HeaderText = "Втори Код";
            this.secondCodeDataGridViewTextBoxColumn.Name = "secondCodeDataGridViewTextBoxColumn";
            // 
            // defaultSupplierDataGridViewTextBoxColumn
            // 
            this.defaultSupplierDataGridViewTextBoxColumn.DataPropertyName = "DefaultSupplier";
            this.defaultSupplierDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.defaultSupplierDataGridViewTextBoxColumn.DisplayMember = "Partner_name";
            this.defaultSupplierDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.defaultSupplierDataGridViewTextBoxColumn.HeaderText = "Доставчик";
            this.defaultSupplierDataGridViewTextBoxColumn.Name = "defaultSupplierDataGridViewTextBoxColumn";
            this.defaultSupplierDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultSupplierDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.defaultSupplierDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // coatingGroupDataGridViewTextBoxColumn
            // 
            this.coatingGroupDataGridViewTextBoxColumn.DataPropertyName = "CoatingGroup";
            this.coatingGroupDataGridViewTextBoxColumn.HeaderText = "Група Боядисване";
            this.coatingGroupDataGridViewTextBoxColumn.Name = "coatingGroupDataGridViewTextBoxColumn";
            // 
            // foreignIDDataGridViewTextBoxColumn
            // 
            this.foreignIDDataGridViewTextBoxColumn.DataPropertyName = "ForeignID";
            this.foreignIDDataGridViewTextBoxColumn.HeaderText = "ForeignID";
            this.foreignIDDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.foreignIDDataGridViewTextBoxColumn.Name = "foreignIDDataGridViewTextBoxColumn";
            this.foreignIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // frmCodesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 494);
            this.Controls.Add(this.btnClearTypeFilter);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCodesList);
            this.Name = "frmCodesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codes List";
            this.Load += new System.EventHandler(this.frmCodesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCodesList;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource systemsBindingSource;
        private System.Windows.Forms.BindingSource subTypesBindingSource;
        private System.Windows.Forms.BindingSource mUBindingSource;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Button btnClearTypeFilter;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weigthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultLength;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultSurface;
        private System.Windows.Forms.DataGridViewComboBoxColumn subTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultMUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn systemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TF;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn defaultSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coatingGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignIDDataGridViewTextBoxColumn;
    }
}