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
    public partial class frmOrderEdit : Form
    {
        public frmOrderEdit()
        {
            InitializeComponent();
        }
        public Orders order = new Orders();
        public OrdersHandlingEntities db;
        private void frmOrderEdit_Load(object sender, EventArgs e)
        {
            if (frmLogin.Instance.UserInfo.UserName=="admin")
            {
                cmbPartnerName.Visible = true;
            } else
            {
                cmbPartnerName.Visible = false;
            }
            //db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            partnersBindingSource.DataSource = db.Partners.ToList();
            codesBindingSource.DataSource = db.Codes.Where(c => c.Type == 5).ToList();
            colorsBindingSource.DataSource = db.Colors.ToList();
            ordersBindingSource.DataSource = order;
            lblOrderNumber.Text = order.ID.ToString();
            codesBindingSource1.DataSource = db.Codes.ToList();
            surfaceBindingSource.DataSource = db.Surface.ToList();
            mUBindingSource.DataSource = db.MU.ToList();
            orderLinesBindingSource.DataSource = db.OrderLines.Where(o => o.OrderID == order.ID).ToList();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvOrderLines.EndEdit();
                    ordersBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                    MessageBox.Show("Промените са успешно запаметени.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Вероятно въведените данни са некоректни, искате ли да разгледате детайли?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        MessageBox.Show(ex.Source + " : " + ex.Message + " : " + ex.InnerException + " : " + ex.StackTrace + " : " + ex.Data);
                    }
                }
            }
        }
       
        private void dgvOrderLines_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderLines.Rows[e.RowIndex].Cells[1].Value==null)
            {
                dgvOrderLines.Rows[e.RowIndex].Cells[1].Value = order.ID;
                dgvOrderLines.Rows[e.RowIndex].Cells[2].Value = 6;
            }
           
        }

        private void dgvOrderLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void btnEditLines_Click(object sender, EventArgs e)
        {
            OrderLines orderline = new OrderLines();
            orderline.OrderID = order.ID;
            orderline.CodeID = 6;
            Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
            orderline.MU = code.DefaultMU;
            orderline.Length = code.DefaultLength;
            orderline.SurfaceID = (int)code.DefaultSurface;
            if (orderline.SurfaceID.ToString()==null)
            {
                orderline.SurfaceID = 1;
            }
            orderline.DeliveryDate = dateTimeExpectedDate.Value;
            Types type = (from types in db.Types where types.TypeID == code.Type select types).SingleOrDefault();
            orderline.IsForCoating = type.IsForCoating;
            orderline.SqmCorrections = 1;
            orderLinesBindingSource.Add(orderline);
            orderLinesBindingSource.MoveLast();
            db.OrderLines.Add(orderline);
        }

        private void dgvOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderLines.CurrentRow != null)
            {
                OrderLines orderline = dgvOrderLines.Rows[e.RowIndex].DataBoundItem as OrderLines;
                Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
                Types type = (from types in db.Types where types.TypeID == code.Type select types).SingleOrDefault();
                if (e.ColumnIndex == 2 | e.ColumnIndex == 3)
                {
                    orderline.MU = code.DefaultMU;
                    orderline.Length = code.DefaultLength;
                   
                    if (code.DefaultSurface != null)
                    {
                        orderline.SurfaceID = (int)code.DefaultSurface;
                    } else
                    {
                        orderline.SurfaceID = 1;
                    }
                    
                    orderline.IsForCoating = type.IsForCoating;
                    orderline.SqmCorrections = 1;

                    if (orderline.Length == null)
                    {
                        orderline.Length = 1;
                    }
                } else if (e.ColumnIndex == 5 | e.ColumnIndex ==6  ) 
                {
                    orderline.QTY = Math.Round((double)(orderline.Pcs * orderline.Length),2);
                }
            }
        }

        private void dgvOrderLines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex==21)
            {
                frmDatePicker frmdatepicker = new frmDatePicker();
                frmdatepicker.Show();
                frmdatepicker.FormClosed += Frmdatepicker_FormClosed;
            }
        }

        private void Frmdatepicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDatePicker datepicker = (frmDatePicker)sender;

            if (datepicker.isClosed==0)
            {
                dgvOrderLines.CurrentCell.Value = datepicker.cldrDatePick.SelectionStart;
            }
        }
    }
}
