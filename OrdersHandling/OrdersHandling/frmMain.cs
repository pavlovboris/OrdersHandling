using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersHandling
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool _isLogout { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLogin.Text = $"Login: {frmLogin.Instance.UserInfo.UserName}";

            OrdersHandlingEntities db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да затворите OrdersHandling?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.ExitThread();
                }
                else { e.Cancel = true; }
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isLogout = true;
                frmLogin.Instance.Show();
                frmLogin.Instance.txtPassword.Text = "";
                Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void codesTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTypes frmtypes = new frmTypes();
            frmtypes.Show();
        }

        private void systemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystems frmsystems = new frmSystems();
            frmsystems.Show();
        }
    }
}
