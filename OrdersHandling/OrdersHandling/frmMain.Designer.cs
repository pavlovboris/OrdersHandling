
namespace OrdersHandling
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picMinimaze = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnOrdersList = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeSubTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxOrders = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.grpBoxOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 275);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.adminSettingsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 72);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picMinimaze
            // 
            this.picMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimaze.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_093_Icon_96;
            this.picMinimaze.Location = new System.Drawing.Point(574, 12);
            this.picMinimaze.Name = "picMinimaze";
            this.picMinimaze.Size = new System.Drawing.Size(60, 49);
            this.picMinimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimaze.TabIndex = 15;
            this.picMinimaze.TabStop = false;
            this.picMinimaze.Click += new System.EventHandler(this.picMinimaze_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_delete_Icon_48;
            this.picClose.Location = new System.Drawing.Point(640, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(60, 49);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 14;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnOrdersList
            // 
            this.btnOrdersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrdersList.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrdersList.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_051_Icon_48;
            this.btnOrdersList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdersList.Location = new System.Drawing.Point(112, 24);
            this.btnOrdersList.Name = "btnOrdersList";
            this.btnOrdersList.Size = new System.Drawing.Size(92, 75);
            this.btnOrdersList.TabIndex = 3;
            this.btnOrdersList.Text = "Orders List";
            this.btnOrdersList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdersList.UseVisualStyleBackColor = true;
            this.btnOrdersList.Click += new System.EventHandler(this.ordersListToolStripMenuItem_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewOrder.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewOrder.Image = global::OrdersHandling.Properties.Resources.glossy_3d_blue_orbs2_037_icon;
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewOrder.Location = new System.Drawing.Point(14, 24);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(92, 75);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_power_Icon_64;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 68);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_053_Icon_48;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_103_Icon_48;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersListToolStripMenuItem,
            this.newOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_063_Icon_64;
            this.ordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(118, 68);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // ordersListToolStripMenuItem
            // 
            this.ordersListToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_orbs2_051_Icon_48;
            this.ordersListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordersListToolStripMenuItem.Name = "ordersListToolStripMenuItem";
            this.ordersListToolStripMenuItem.Size = new System.Drawing.Size(163, 54);
            this.ordersListToolStripMenuItem.Text = "Orders List";
            this.ordersListToolStripMenuItem.Click += new System.EventHandler(this.ordersListToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.glossy_3d_blue_orbs2_037_icon;
            this.newOrderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(163, 54);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codesToolStripMenuItem,
            this.surfacesToolStripMenuItem,
            this.mUToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_fontsize_Icon_64;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 68);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // codesToolStripMenuItem
            // 
            this.codesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCodeToolStripMenuItem,
            this.codesListToolStripMenuItem,
            this.codesTypesToolStripMenuItem,
            this.codesCategoryToolStripMenuItem,
            this.codeSubTypeToolStripMenuItem,
            this.systemsToolStripMenuItem});
            this.codesToolStripMenuItem.Name = "codesToolStripMenuItem";
            this.codesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.codesToolStripMenuItem.Text = "Codes";
            // 
            // newCodeToolStripMenuItem
            // 
            this.newCodeToolStripMenuItem.Name = "newCodeToolStripMenuItem";
            this.newCodeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newCodeToolStripMenuItem.Text = "New Code";
            this.newCodeToolStripMenuItem.Click += new System.EventHandler(this.newCodeToolStripMenuItem_Click);
            // 
            // codesListToolStripMenuItem
            // 
            this.codesListToolStripMenuItem.Name = "codesListToolStripMenuItem";
            this.codesListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codesListToolStripMenuItem.Text = "Codes List";
            this.codesListToolStripMenuItem.Click += new System.EventHandler(this.codesListToolStripMenuItem_Click);
            // 
            // codesTypesToolStripMenuItem
            // 
            this.codesTypesToolStripMenuItem.Name = "codesTypesToolStripMenuItem";
            this.codesTypesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codesTypesToolStripMenuItem.Text = "Codes Types";
            this.codesTypesToolStripMenuItem.Click += new System.EventHandler(this.codesTypesToolStripMenuItem_Click);
            // 
            // codesCategoryToolStripMenuItem
            // 
            this.codesCategoryToolStripMenuItem.Name = "codesCategoryToolStripMenuItem";
            this.codesCategoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codesCategoryToolStripMenuItem.Text = "Codes Category";
            this.codesCategoryToolStripMenuItem.Click += new System.EventHandler(this.codesCategoryToolStripMenuItem_Click);
            // 
            // codeSubTypeToolStripMenuItem
            // 
            this.codeSubTypeToolStripMenuItem.Name = "codeSubTypeToolStripMenuItem";
            this.codeSubTypeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codeSubTypeToolStripMenuItem.Text = "Codes Sub-Types";
            this.codeSubTypeToolStripMenuItem.Click += new System.EventHandler(this.codeSubTypeToolStripMenuItem_Click);
            // 
            // systemsToolStripMenuItem
            // 
            this.systemsToolStripMenuItem.Name = "systemsToolStripMenuItem";
            this.systemsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.systemsToolStripMenuItem.Text = "Systems";
            this.systemsToolStripMenuItem.Click += new System.EventHandler(this.systemsToolStripMenuItem_Click);
            // 
            // surfacesToolStripMenuItem
            // 
            this.surfacesToolStripMenuItem.Name = "surfacesToolStripMenuItem";
            this.surfacesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.surfacesToolStripMenuItem.Text = "Surfaces";
            this.surfacesToolStripMenuItem.Click += new System.EventHandler(this.surfacesToolStripMenuItem_Click);
            // 
            // mUToolStripMenuItem
            // 
            this.mUToolStripMenuItem.Name = "mUToolStripMenuItem";
            this.mUToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.mUToolStripMenuItem.Text = "MU";
            this.mUToolStripMenuItem.Click += new System.EventHandler(this.mUToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // adminSettingsToolStripMenuItem
            // 
            this.adminSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.adminSettingsToolStripMenuItem.Image = global::OrdersHandling.Properties.Resources.Glossy_3d_blue_shield_Icon_64;
            this.adminSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminSettingsToolStripMenuItem.Name = "adminSettingsToolStripMenuItem";
            this.adminSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 68);
            this.adminSettingsToolStripMenuItem.Text = "Admin Settings";
            this.adminSettingsToolStripMenuItem.Visible = false;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // grpBoxOrders
            // 
            this.grpBoxOrders.Controls.Add(this.btnOrdersList);
            this.grpBoxOrders.Controls.Add(this.btnNewOrder);
            this.grpBoxOrders.Location = new System.Drawing.Point(12, 121);
            this.grpBoxOrders.Name = "grpBoxOrders";
            this.grpBoxOrders.Size = new System.Drawing.Size(218, 118);
            this.grpBoxOrders.TabIndex = 16;
            this.grpBoxOrders.TabStop = false;
            this.grpBoxOrders.Text = "Orders";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 297);
            this.Controls.Add(this.grpBoxOrders);
            this.Controls.Add(this.picMinimaze);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(712, 297);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.grpBoxOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeSubTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnOrdersList;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimaze;
        private System.Windows.Forms.GroupBox grpBoxOrders;
    }
}