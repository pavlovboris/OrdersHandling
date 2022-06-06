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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public OrdersHandlingEntities db;
        private bool _isLogout { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLogin.Text = $"Login: {frmLogin.Instance.UserInfo.UserName}";

            OrdersHandlingEntities db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";
            
            if (frmLogin.Instance.UserInfo.RoleID==1)
            {
                adminSettingsToolStripMenuItem.Visible = true;
            } else
            {
                adminSettingsToolStripMenuItem.Visible = false;
            }
        
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да затворите OrdersHandling?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.ExitThread();
                }
                else { e.Cancel = true; }
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isLogout = true;
                frmLogin.Instance.Show();
                frmLogin.Instance.txtPassword.Text = "";
                Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void codesTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmTypes frmtypes = new frmTypes();

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmtypes.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen==false)
            {
                frmtypes.Show();
            }
        }

        private void systemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmSystems frmsystems = new frmSystems();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmsystems.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if(isOpen==false)
            {
                frmsystems.Show();
            }
        }

        private void codesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmCodesList frmcodeslist = new frmCodesList();

            foreach(Form f in Application.OpenForms)
            {
                if (f.Name == frmcodeslist.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                frmcodeslist.Show();
            }

        }

        private void codeSubTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmSubTypes frmSubtypes = new frmSubTypes();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmSubtypes.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                frmSubtypes.Show();
            }
        }

        private void ordersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            frmOrdersList frmorderslist = new frmOrdersList();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmorderslist.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if(!isOpen)
            {
                frmorderslist.Show();
            }
        }

        private void surfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmSurfaces frmsurfaces = new frmSurfaces();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmsurfaces.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if(!isOpen)
            {
                frmsurfaces.Show();
            }
        }

        private void mUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmMU frmmu = new frmMU();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmmu.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                frmmu.Show();
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmColors frmcolors = new frmColors();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmcolors.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if(!isOpen)
            {
                frmcolors.Show();
            }
        }

        private void codesCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmCategory frmcategory = new frmCategory();

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmcategory.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                frmcategory.Show();
            }
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            db = new OrdersHandlingEntities();
            Orders orders = new Orders();
            frmOrderEdit neworder = new frmOrderEdit();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == neworder.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                orders.Customer_ID = frmLogin.Instance.UserInfo.PartnerID;
                orders.Orddate = DateTime.Today;
                orders.IsOffer = 1;
                db.Orders.Add(orders);
                neworder.order = orders;
                neworder.db = db;
                neworder.Show();
            } 
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmUsers frmusers = new frmUsers();

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmusers.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                frmusers.Show();
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            frmRoles frmroles = new frmRoles();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmroles.Name)
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                frmroles.Show();
            }
        }

        private void newCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
