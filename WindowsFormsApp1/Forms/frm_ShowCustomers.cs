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
        #region متغیر ها

        private List<CUSTOMERS> dt;
        private bool isSearch = false, isKeySpase = false,isLode = false;
        private List<int> listCheckboxTrue = new List<int>();
        #endregion

        public frm_ShowCustomers()
        {
            InitializeComponent();
        }

        private void frm_ShowCustomers_Load(object sender, EventArgs e)
        {
            //var max = conection.getMaxID(c => c.SHMO);
            //var vis = conection.functionVis(25);
            dgv_customers.DataSource = dt = conection.get<CUSTOMERS>(orderBy: c => c.SHMO, firstOrLirst: false, top: 10);
            //dt = ((List<CUSTOMERS>) dgv_customers.DataSource).Select(c => new customerView()
            //{
            //    cust = c,
            //    @select = new CheckBox()
            //}).ToList();
            //dgv_customers.DataSource = dt;

            SetGrid();

            txt_SelectNumber.Text = 0.ToString();
        }



        #region رویداد ها

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.PaleTurquoise;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string filter = textBox1.Text.Trim();
            if (filter == "" && !isSearch)
            {
                dgv_customers.DataSource = dt;

            }
            else if (filter != "")
            {
                isSearch = false;
                dgv_customers.DataSource = dt.Where(c => c.MONAME.Contains(filter) || c.addre.Contains(filter)).ToList();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                isSearch = false;
                textBox1.Text = "";
            }
            else if ((e.KeyCode == Keys.Space && textBox1.Text.Trim() == "" && isSearch)
                     ||
                     (e.KeyCode == Keys.Enter && dgv_customers.Rows.Count == 1))
            {
                isKeySpase = true;
                textBox1.Text = "";
                SetCheckBoxColumn();
            }
            else if (dgv_customers.Rows.Count > 0)
            {
                int rowIndexSelected = dgv_customers.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    isSearch = true;
                    textBox1.Text = "";
                    if (rowIndexSelected > 0)
                    {
                        dgv_customers.Rows[rowIndexSelected - 1].Cells["select"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    isSearch = true;
                    textBox1.Text = "";
                    if (rowIndexSelected < dgv_customers.RowCount - 1)
                    {
                        dgv_customers.Rows[rowIndexSelected + 1].Cells["select"].Selected = true;
                    }
                }
            }

        }

        private void dgv_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isKeySpase)
            {
                isKeySpase = false;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                SetCheckBoxColumn();
            }
        }

        private void dgv_customers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isKeySpase = true;
                SetCheckBoxColumn();
            }
        }

        private void dgv_customers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_customers.Rows)
            {
                int search = (int)row.Cells["shmo"].Value;
                if (listCheckboxTrue.Find(i => i == search) == search)
                {
                    row.Cells["select"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
                else
                {
                    row.Cells["select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            //if(dgv_customers.Rows.Count == listCheckboxTrue.Count)
            //    checkBox1.Checked = true;
            //else
            //    checkBox1.Checked = false;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                foreach (DataGridViewRow row in dgv_customers.Rows)
                {

                    if (checkBox1.Checked)
                    {
                        listCheckboxTrue.Add((int) row.Cells["shmo"].Value);
                    }
                    else
                    {
                        listCheckboxTrue.Remove((int) row.Cells["shmo"].Value);
                    }

                }

                txt_SelectNumber.Text = listCheckboxTrue.Count.ToString();
                dgv_customers_DataBindingComplete(sender,
                    new DataGridViewBindingCompleteEventArgs(ListChangedType.ItemAdded));
            
        }
        #endregion

        #region متد ها

        private void SetGrid()
        {
            foreach (DataGridViewColumn Col in dgv_customers.Columns)
            {
                //Col.Visible = false;
            }
            dgv_customers.Columns["shmo"].Visible = true;
            dgv_customers.Columns["shmo"].HeaderText = "شماره مشتری";

            dgv_customers.Columns["moname"].Visible = true;
            dgv_customers.Columns["moname"].HeaderText = "نام مشتری";

            dgv_customers.Columns["addre"].Visible = true;
            dgv_customers.Columns["addre"].HeaderText = "آدرس";

            dgv_customers.Columns["tell1"].Visible = true;
            dgv_customers.Columns["tell1"].HeaderText = "تلفن";

            dgv_customers.Columns["cred"].Visible = true;
            dgv_customers.Columns["cred"].HeaderText = "اعتبار";

            dgv_customers.Columns["sharh"].Visible = true;
            dgv_customers.Columns["sharh"].HeaderText = "توضیحات";

            dgv_customers.Columns["maxmanfactor"].Visible = true;
            dgv_customers.Columns["maxmanfactor"].HeaderText = "ت.ف.مجاز مانده";

            dgv_customers.Columns["select"].Visible = true;
            dgv_customers.Columns["select"].HeaderText = "انتخاب";

        }



        private void SetCheckBoxColumn()
        {
            var rowIndex = dgv_customers.CurrentCell.RowIndex;
            if (Convert.ToBoolean(dgv_customers.SelectedRows[0].Cells["select"].Value) == false)
            {
                dgv_customers.Rows[rowIndex].Cells["select"].Value = true;
                dgv_customers.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                listCheckboxTrue.Add((int)dgv_customers.Rows[rowIndex].Cells["shmo"].Value);
                //افزودن کد مشتری به لیست ایتم های انتخابی
                //dt.FirstOrDefault(c => c.SHMO == (int)dgv_customers.Rows[rowIndex].Cells["shmo"].Value).select.Checked = true;

            }
            else
            {
                dgv_customers.Rows[rowIndex].Cells["select"].Value = false;
                dgv_customers.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                listCheckboxTrue.Remove((int)dgv_customers.Rows[rowIndex].Cells["shmo"].Value);

                //حذف کد مشتری از لیست ایتم های انتخابی
                //dt.FirstOrDefault(c => c.SHMO == (int)dgv_customers.Rows[rowIndex].Cells["shmo"].Value).select.Checked = false;

            }
            //تعدا
            txt_SelectNumber.Text = listCheckboxTrue.Count.ToString();
        }
        #endregion


    }

}
