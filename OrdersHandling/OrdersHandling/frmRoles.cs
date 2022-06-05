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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;
        private void frmRoles_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            rolesBindingSource.DataSource = db.Roles.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            rolesBindingSource.Add(roles);
            rolesBindingSource.MoveLast();
            db.Roles.Add(roles);

            if (dgvRoles.ReadOnly == true)
            {
                dgvRoles.ReadOnly = false;

                for (int i = 0; i < dgvRoles.Rows.Count - 1; i++)
                {
                    dgvRoles.Rows[i].ReadOnly = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvRoles.EndEdit();
                    rolesBindingSource.EndEdit();
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
    }
}
