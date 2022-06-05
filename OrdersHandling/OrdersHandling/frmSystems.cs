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
    public partial class frmSystems : Form
    {
        public frmSystems()
        {
            InitializeComponent();
        }
        OrdersHandlingEntities db;
        private void frmSystems_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            systemsBindingSource.DataSource = db.Systems.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Systems systems = new Systems();

            systemsBindingSource.Add(systems);
            systemsBindingSource.MoveLast();
            db.Systems.Add(systems);

            if (dgvSystems.ReadOnly == true)
            {
                dgvSystems.ReadOnly = false;

                for (int i = 0; i < dgvSystems.Rows.Count - 1; i++)
                {
                    dgvSystems.Rows[i].ReadOnly = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvSystems.EndEdit();
                    await db.SaveChangesAsync();
                    dgvSystems.Refresh();
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
            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.Systems.Remove(systemsBindingSource.Current as Systems);
                    systemsBindingSource.RemoveCurrent();

                    MessageBox.Show("Записа е успешно изтрит.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
