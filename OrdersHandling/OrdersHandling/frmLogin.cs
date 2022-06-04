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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private static frmLogin _instance;
        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }

        public Users UserInfo { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OrdersHandlingEntities db = new OrdersHandlingEntities();

            db.Database.Connection.ConnectionString = "data source=apellobg-orders-mng.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=OrdMng;Password=?WXO?tERW,U; MultipleActiveResultSets=True;App=EntityFramework;";

            var sql = (from user in db.Users where user.UserName == txtUserName.Text && user.Password == txtPassword.Text select user).SingleOrDefault();

            if (sql != null)
            {
                UserInfo = sql;

                Hide();

                frmMain frm = new frmMain();

                frm.ShowDialog();
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Потребителското име или парола са грешни", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
