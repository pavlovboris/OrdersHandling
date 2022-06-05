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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        OrdersHandlingEntities db;

        private void frmUsers_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            usersBindingSource.DataSource = db.Users.ToList();
            partnersBindingSource.DataSource = db.Partners.ToList();
            rolesBindingSource.DataSource = db.Roles.ToList();
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.PartnerID = 3;
            usersBindingSource.Add(user);
            usersBindingSource.MoveLast();
            db.Users.Add(user);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvUsers.EndEdit();
                    await db.SaveChangesAsync();
                    dgvUsers.Refresh();
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
