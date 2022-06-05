
namespace OrdersHandling
{
    partial class frmMU
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
            this.dgvMU = new System.Windows.Forms.DataGridView();
            this.mUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMU
            // 
            this.dgvMU.AllowUserToAddRows = false;
            this.dgvMU.AllowUserToDeleteRows = false;
            this.dgvMU.AutoGenerateColumns = false;
            this.dgvMU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.muCodeDataGridViewTextBoxColumn,
            this.muNameDataGridViewTextBoxColumn});
            this.dgvMU.DataSource = this.mUBindingSource;
            this.dgvMU.Location = new System.Drawing.Point(13, 13);
            this.dgvMU.Name = "dgvMU";
            this.dgvMU.ReadOnly = true;
            this.dgvMU.RowHeadersWidth = 20;
            this.dgvMU.Size = new System.Drawing.Size(327, 332);
            this.dgvMU.TabIndex = 0;
            // 
            // mUBindingSource
            // 
            this.mUBindingSource.DataSource = typeof(OrdersHandling.MU);
            // 
            // muCodeDataGridViewTextBoxColumn
            // 
            this.muCodeDataGridViewTextBoxColumn.DataPropertyName = "MuCode";
            this.muCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.muCodeDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.muCodeDataGridViewTextBoxColumn.Name = "muCodeDataGridViewTextBoxColumn";
            this.muCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.muCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // muNameDataGridViewTextBoxColumn
            // 
            this.muNameDataGridViewTextBoxColumn.DataPropertyName = "MuName";
            this.muNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.muNameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.muNameDataGridViewTextBoxColumn.Name = "muNameDataGridViewTextBoxColumn";
            this.muNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.muNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(13, 356);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 61);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Добави";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(85, 356);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 61);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Изтрий";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(275, 356);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 61);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Запази";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 430);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMU);
            this.Name = "frmMU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement Units";
            this.Load += new System.EventHandler(this.frmMU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMU;
        private System.Windows.Forms.DataGridViewTextBoxColumn muCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mUBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}