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
    public partial class frmPowderCodeSelector : Form
    {
        public frmPowderCodeSelector()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;
        public bool xclicked = true;
        public bool cancel = false;

        private void frmCodeSelector_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            codesBindingSource.DataSource = db.Codes.Where(c=> c.Type==5).ToList();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            codesBindingSource.DataSource = db.Codes.Where(c => c.Code.Contains(txtFilter.Text) | c.Description.Contains(txtFilter.Text)).ToList();
        }

        private void dgvCodeSelector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCodeSelector.Rows[e.RowIndex].DataBoundItem != null)
            {
                xclicked = false;
                Close();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                dgvCodeSelector.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cancel = true;
                Close();
            }
        }

        private void dgvCodeSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                xclicked = false;
                Close();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cancel = true;
                Close();
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                xclicked = false;
                Close();
            }
            else if (e.KeyChar == 38)
            {
                dgvCodeSelector.Focus();
            }
        }
    }
}
