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
    public partial class frmTypes : Form
    {
        public frmTypes()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;

        private void frmTypes_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            typesBindingSource.DataSource = db.Types.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Types types = new Types();

            typesBindingSource.Add(types);
            typesBindingSource.MoveLast();
            db.Types.Add(types);

            if (dgvTypes.ReadOnly == true)
            {
                dgvTypes.ReadOnly = false;

                for (int i = 0; i < dgvTypes.Rows.Count - 1; i++)
                {
                    dgvTypes.Rows[i].ReadOnly = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvTypes.EndEdit();
                    await db.SaveChangesAsync();
                    dgvTypes.Refresh();
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
