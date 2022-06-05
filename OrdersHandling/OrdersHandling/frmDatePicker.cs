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
    public partial class frmDatePicker : Form
    {
        public frmDatePicker()
        {
            InitializeComponent();
        }
        public int isClosed=1;
        private void cldrDatePick_DateSelected(object sender, DateRangeEventArgs e)
        {
            isClosed = 0;
            Close();
        }
    }
}
