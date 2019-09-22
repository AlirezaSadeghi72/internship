using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void tsmi_NewCustomer_Click(object sender, EventArgs e)
        {
            Form new_customer = new frm_Customer();
            new_customer.ShowDialog();
        }
    }
}
