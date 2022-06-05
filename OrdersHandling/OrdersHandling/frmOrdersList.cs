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
    public partial class frmOrdersList : Form
    {
        public frmOrdersList()
        {
            InitializeComponent();
        }
        OrdersHandlingEntities db;

        private void frmOrdersList_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            partnersBindingSource.DataSource = db.Partners.Where(p => p.ID == frmLogin.Instance.UserInfo.PartnerID).SingleOrDefault();
            partnersBindingSource1.DataSource = db.Partners.ToList();
            colorsBindingSource.DataSource = db.Colors.ToList();
            codesBindingSource.DataSource = db.Codes.ToList();
            lstFilterCompleted.SelectedIndex = 1;
            cmbFilter.SelectedIndex = 0;
            cmbCustomer.SelectedItem = db.Partners.Where(p => p.ID == frmLogin.Instance.UserInfo.PartnerID).SingleOrDefault();
            Partners selectedpartner = cmbCustomer.SelectedItem as Partners;

            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex).ToList();

            if (frmLogin.Instance.UserInfo.RoleID!=1)
            {
                cmbCustomer.Enabled = false; 
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partners selectedpartner = cmbCustomer.SelectedItem as Partners;

            if (selectedpartner != null)
            {
                if (string.IsNullOrEmpty(txtFilter.Text))
                {
                    switch (lstFilterCompleted.SelectedIndex)
                    {
                        case 2:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                            break;
                        case 0:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 1 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                            break;
                        case 1:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                            break;
                    }
                }
                else
                {
                    switch (lstFilterCompleted.SelectedIndex)
                    {
                        case 2:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex &&  o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                            break;
                        case 0:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 1 && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                            break;
                        case 1:
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                            break;
                    }
                }
            }
        }

        private void dgvOrdersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders order = new Orders();

            order = dgvOrdersList.CurrentRow.DataBoundItem as Orders;

            if ( order != null)
            {
                frmOrderEdit frmorderedit = new frmOrderEdit();
                frmorderedit.order = order;
                frmorderedit.db = db;
                frmorderedit.Show();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            Partners selectedpartner = cmbCustomer.SelectedItem as Partners;
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated== 1 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                }
            } else
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 1 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 0 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                }
            }
        }

        private void lblFilterCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partners selectedpartner = cmbCustomer.SelectedItem as Partners;
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 1 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                }
            }
            else
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 1 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 0 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partners selectedpartner = cmbCustomer.SelectedItem as Partners;
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 1 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.Compleated == 0 && o.IsOffer == cmbFilter.SelectedIndex).ToList();
                        break;
                }
            }
            else
            {
                switch (lstFilterCompleted.SelectedIndex)
                {
                    case 2:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 0:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 1 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                    case 1:
                        ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Compleated == 0 && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
                        break;
                }
            }
        }
    }
}
