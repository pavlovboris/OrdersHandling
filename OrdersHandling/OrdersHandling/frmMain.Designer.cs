
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeSubTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 670);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
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
            this.codesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codesToolStripMenuItem.Text = "Codes";
            // 
            // newCodeToolStripMenuItem
            // 
            this.newCodeToolStripMenuItem.Name = "newCodeToolStripMenuItem";
            this.newCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newCodeToolStripMenuItem.Text = "New Code";
            // 
            // codesListToolStripMenuItem
            // 
            this.codesListToolStripMenuItem.Name = "codesListToolStripMenuItem";
            this.codesListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codesListToolStripMenuItem.Text = "Codes List";
            // 
            // codesTypesToolStripMenuItem
            // 
            this.codesTypesToolStripMenuItem.Name = "codesTypesToolStripMenuItem";
            this.codesTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codesTypesToolStripMenuItem.Text = "Codes Types";
            this.codesTypesToolStripMenuItem.Click += new System.EventHandler(this.codesTypesToolStripMenuItem_Click);
            // 
            // codesCategoryToolStripMenuItem
            // 
            this.codesCategoryToolStripMenuItem.Name = "codesCategoryToolStripMenuItem";
            this.codesCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codesCategoryToolStripMenuItem.Text = "Codes Category";
            // 
            // codeSubTypeToolStripMenuItem
            // 
            this.codeSubTypeToolStripMenuItem.Name = "codeSubTypeToolStripMenuItem";
            this.codeSubTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeSubTypeToolStripMenuItem.Text = "Codes Sub-Types";
            // 
            // systemsToolStripMenuItem
            // 
            this.systemsToolStripMenuItem.Name = "systemsToolStripMenuItem";
            this.systemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.systemsToolStripMenuItem.Text = "Systems";
            this.systemsToolStripMenuItem.Click += new System.EventHandler(this.systemsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 692);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}