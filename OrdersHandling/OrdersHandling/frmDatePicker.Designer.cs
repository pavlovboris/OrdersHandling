
namespace OrdersHandling
{
    partial class frmDatePicker
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
            this.cldrDatePick = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cldrDatePick
            // 
            this.cldrDatePick.Location = new System.Drawing.Point(13, 13);
            this.cldrDatePick.Name = "cldrDatePick";
            this.cldrDatePick.TabIndex = 0;
            this.cldrDatePick.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldrDatePick_DateSelected);
            // 
            // frmDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 182);
            this.Controls.Add(this.cldrDatePick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Selector";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MonthCalendar cldrDatePick;
    }
}