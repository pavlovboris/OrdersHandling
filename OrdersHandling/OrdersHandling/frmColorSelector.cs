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
    public partial class frmColorSelector : Form
    {
        public frmColorSelector()
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

            colorsBindingSource.DataSource = db.Colors.ToList();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            colorsBindingSource.DataSource = db.Colors.Where(c => c.ColorName.Contains(txtFilter.Text)).ToList();
        }

        private void dgvCodeSelector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvColorSelector.Rows[e.RowIndex].DataBoundItem != null)
            {
                xclicked = false;
                Close();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                dgvColorSelector.Focus();
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
                dgvColorSelector.Focus();
            }
        }
    }
}
