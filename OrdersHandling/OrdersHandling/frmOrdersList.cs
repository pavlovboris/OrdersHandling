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

            if (frmLogin.Instance.UserInfo.RoleID != 1)
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
                            ordersBindingSource.DataSource = db.Orders.Where(o => o.Customer_ID == selectedpartner.ID && o.IsOffer == cmbFilter.SelectedIndex && o.Project.Contains(txtFilter.Text) | o.Colors.ColorName.Contains(txtFilter.Text) | o.Codes.Code.Contains(txtFilter.Text)).ToList();
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

            if (order != null)
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

        private void dgvOrdersList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && dgvOrdersList.Rows[e.RowIndex].DataBoundItem != null)
                {
                    dgvOrdersList.ClearSelection();  
                    dgvOrdersList.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private async void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                /*if (MessageBox.Show("Сигурни ли сте, че искате да изтриете маркираните изцяло редове?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }*/

                foreach (DataGridViewRow dr in dgvOrdersList.Rows)
                {
                    if (dr.DataBoundItem != null && dr.Selected == true)
                    {
                        if (MessageBox.Show("Сигурни ли сте, че искате да изтриете избраните редове?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Orders orders = new Orders();
                            orders = dr.DataBoundItem as Orders;

                            if (orders != null && orders.IsOffer!=0)
                            {
                                var list = (from orderline in db.OrderLines where orderline.OrderID == orders.ID select orderline).ToList();
                                var attachments = (from uploaded in db.UploadedFiles where uploaded.OrderID == orders.ID select uploaded).ToList();

                                foreach (UploadedFiles upld in attachments)
                                {
                                    db.UploadedFiles.Remove(upld);
                                }

                                foreach (OrderLines ordl in list)
                                {
                                    db.OrderLines.Remove(ordl);
                                }

                                dgvOrdersList.Rows.Remove(dr);
                                ordersBindingSource.Remove(orders);
                                db.Orders.Remove(orders);
                                try
                                {
                                    await db.SaveChangesAsync();
                                    MessageBox.Show("Записите са изтрити успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            } else
                            {
                                MessageBox.Show("Можете да триете само документи от тип : Offer", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
