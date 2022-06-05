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
    public partial class frmSurfaces : Form
    {
        public frmSurfaces()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;
        private void Surfaces_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";
            surfaceBindingSource.DataSource = db.Surface.ToList();
            codesBindingSource.DataSource = db.Codes.Where(c => c.Type==5).ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Surface surface = new Surface();

            surfaceBindingSource.Add(surface);
            surfaceBindingSource.MoveLast();
            db.Surface.Add(surface);

            if (dgvSurfaces.ReadOnly == true)
            {
                dgvSurfaces.ReadOnly = false;

                for (int i = 0; i < dgvSurfaces.Rows.Count - 1; i++)
                {
                    dgvSurfaces.Rows[i].ReadOnly = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvSurfaces.EndEdit();
                    await db.SaveChangesAsync();
                    dgvSurfaces.Refresh();
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
    }
}
