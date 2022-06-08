
namespace OrdersHandling
{
    partial class frmColorSelector
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvColorSelector = new System.Windows.Forms.DataGridView();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(13, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(328, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // dgvColorSelector
            // 
            this.dgvColorSelector.AllowUserToAddRows = false;
            this.dgvColorSelector.AllowUserToDeleteRows = false;
            this.dgvColorSelector.AutoGenerateColumns = false;
            this.dgvColorSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColorSelector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorNameDataGridViewTextBoxColumn,
            this.defaultMaterialDataGridViewTextBoxColumn});
            this.dgvColorSelector.DataSource = this.colorsBindingSource;
            this.dgvColorSelector.Location = new System.Drawing.Point(13, 40);
            this.dgvColorSelector.Name = "dgvColorSelector";
            this.dgvColorSelector.ReadOnly = true;
            this.dgvColorSelector.RowHeadersWidth = 20;
            this.dgvColorSelector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColorSelector.Size = new System.Drawing.Size(328, 150);
            this.dgvColorSelector.TabIndex = 1;
            this.dgvColorSelector.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCodeSelector_CellDoubleClick);
            this.dgvColorSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCodeSelector_KeyDown);
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataSource = typeof(OrdersHandling.Colors);
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // defaultMaterialDataGridViewTextBoxColumn
            // 
            this.defaultMaterialDataGridViewTextBoxColumn.DataPropertyName = "DefaultMaterial";
            this.defaultMaterialDataGridViewTextBoxColumn.HeaderText = "DefaultMaterial";
            this.defaultMaterialDataGridViewTextBoxColumn.Name = "defaultMaterialDataGridViewTextBoxColumn";
            this.defaultMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 202);
            this.Controls.Add(this.dgvColorSelector);
            this.Controls.Add(this.txtFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColorSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Selector";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCodeSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        public System.Windows.Forms.DataGridView dgvColorSelector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorsBindingSource;
    }
}