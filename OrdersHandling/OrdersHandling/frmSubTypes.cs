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
    public partial class frmSubTypes : Form
    {
        public frmSubTypes()
        {
            InitializeComponent();
        }
        OrdersHandlingEntities db;


        private void frmSubTypes_Load(object sender, EventArgs e)
        {
            db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            subTypesBindingSource.DataSource = db.SubTypes.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubTypes subTypes = new SubTypes();

            subTypesBindingSource.Add(subTypes);
            subTypesBindingSource.MoveLast();
            db.SubTypes.Add(subTypes);

            if (dgvSubTypes.ReadOnly == true)
            {
                dgvSubTypes.ReadOnly = false;

                for (int i = 0; i < dgvSubTypes.Rows.Count - 1; i++)
                {
                    dgvSubTypes.Rows[i].ReadOnly = true;
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dgvSubTypes.CurrentRow.Cells[0].Value.ToString()=="none")
                    {
                        MessageBox.Show("Не можете да изтриете този запис.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        db.SubTypes.Remove(subTypesBindingSource.Current as SubTypes);
                        subTypesBindingSource.RemoveCurrent();

                        MessageBox.Show("Записа е успешно изтрит.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dgvSubTypes.EndEdit();
                    await db.SaveChangesAsync();
                    dgvSubTypes.Refresh();
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
