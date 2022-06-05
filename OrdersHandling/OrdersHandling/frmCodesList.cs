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
    public partial class frmCodesList : Form
    {
        public frmCodesList()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;

        private void frmCodesList_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            typesBindingSource.DataSource =db.Types.ToList();
            codesBindingSource.DataSource = db.Codes.ToList();
            categoryBindingSource.DataSource = db.Category.ToList();
            systemsBindingSource.DataSource = db.Systems.ToList();
            subTypesBindingSource.DataSource = db.SubTypes.ToList();
            mUBindingSource.DataSource = db.MU.ToList();
            surfaceBindingSource.DataSource = db.Surface.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Codes codes = new Codes();

            codesBindingSource.Add(codes);
            codesBindingSource.MoveLast();
            db.Codes.Add(codes);

            dgvCodesList.CurrentRow.Cells[2].Value = 1;
            dgvCodesList.CurrentRow.Cells[6].Value = 2;
            dgvCodesList.CurrentRow.Cells[7].Value = 1;

            if (dgvCodesList.ReadOnly == true)
            {
                dgvCodesList.ReadOnly = false;

                for (int i = 0; i < dgvCodesList.Rows.Count - 1; i++)
                {
                    dgvCodesList.Rows[i].ReadOnly = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvCodesList.EndEdit();
                    await db.SaveChangesAsync();
                    dgvCodesList.Refresh();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Types type = cmbFilterType.SelectedItem as Types;
            if (type != null)
            {
                codesBindingSource.DataSource = db.Codes.Where(c => c.Type == type.TypeID).ToList();
            }
        }

        private void btnClearTypeFilter_Click(object sender, EventArgs e)
        {
            codesBindingSource.DataSource = db.Codes.ToList();
        }
    }
}
