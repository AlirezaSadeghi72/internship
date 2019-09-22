using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataLayer;

namespace WindowsFormsApp1.Forms
{
    public partial class frm_ShowCustomers : Form
    {
        private IEnumerable<CUSTOMERS> dt;
        public frm_ShowCustomers()
        {
            InitializeComponent();
        }

        private void frm_ShowCustomers_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_customers.DataSource = dt = db.grCustomer.get(orderBy: c => c.SHMO, firstOrLirst: false, top: 10);
            }

            SetGrid();

            dgv_customers.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void SetGrid()
        {
            foreach (DataGridViewColumn Col in dgv_customers.Columns)
            {
                Col.Visible = false;
            }
            dgv_customers.Columns["shmo"].Visible = true;
            dgv_customers.Columns["shmo"].HeaderText = "شماره مشتری";

            dgv_customers.Columns["moname"].Visible = true;
            dgv_customers.Columns["moname"].HeaderText = "نام مشتری";

            dgv_customers.Columns["addre"].Visible = true;
            dgv_customers.Columns["addre"].HeaderText = "آدرس";

            dgv_customers.Columns["Tell1"].Visible = true;
            dgv_customers.Columns["Tell1"].HeaderText = "تلفن";

            dgv_customers.Columns["cred"].Visible = true;
            dgv_customers.Columns["cred"].HeaderText = "اعتبار";

            dgv_customers.Columns["sharh"].Visible = true;
            dgv_customers.Columns["sharh"].HeaderText = "توضیحات";

            dgv_customers.Columns["maxmanfactor"].Visible = true;
            dgv_customers.Columns["maxmanfactor"].HeaderText = "ت.ف.مجاز مانده";

            dgv_customers.Columns["select"].Visible = true;
        }

        private void dgv_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                //dgv_customers.Columns["select"].Selected = true;
                //if (dgv_customers.Rows[e.RowIndex].Cells["select"].Value == null)
                //    dgv_customers.Rows[e.RowIndex].Cells["select"].Value = false;
                //if ((bool)dgv_customers.Rows[e.RowIndex].Cells["select"].Value == false)
                //{
                //    dgv_customers.Rows[e.RowIndex].Cells["select"].Value = true;
                //    dgv_customers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                //}
                //else
                //{
                //    dgv_customers.Rows[e.RowIndex].Cells["select"].Value = false;
                //    dgv_customers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //}
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.PaleTurquoise;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
        }


        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_customers.Columns["select"].Selected = true;
            if (dgv_customers.SelectedRows[0].Cells["select"].Value == null)
                dgv_customers.SelectedRows[0].Cells["select"].Value = false;
            if ((bool)dgv_customers.SelectedRows[0].Cells["select"].Value == false)
            {
                dgv_customers.SelectedRows[0].Cells["select"].Value = true;
                dgv_customers.SelectedRows[0].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
            else
            {
                dgv_customers.SelectedRows[0].Cells["select"].Value = false;
                dgv_customers.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dgv_customers.DataSource = dt.Where(c => c.MONAME.Contains(textBox1.Text) || c.addre.Contains(textBox1.Text)).ToList();
            }
            else
            {
                dgv_customers.DataSource = dt;
            }


        }
    }

}
