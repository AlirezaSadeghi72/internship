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
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }
        private int countcust;
        private int ID = 1;
        private void frm_Customer_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ID += db.grCustomer.getMaxID(c => c.SHMO) ?? 0;
                cbox_AccountSide.DataSource =
                    db.grCustgroup.get();
                cbox_AccountSide.ValueMember = "group_rdf";
                cbox_AccountSide.DisplayMember = "group_name";
                cbox_Visitor.DataSource = db.grVisitor.get();
                cbox_Visitor.ValueMember = "vis_rdf";
                cbox_Visitor.DisplayMember = "vis_name";
                countcust = db.grCustomer.get(c => c.code.StartsWith("001029042")).Count();

            }
            countcust++;
            if (countcust < 10)
                txt_CustCod.Text += "00";
            else if (countcust < 100)
                txt_CustCod.Text += "0";

            txt_CustCod.Text += countcust.ToString();

            txt_CustNumber.Text = ID.ToString();
        }
        private bool checkInfo()
        {
            if (txt_CustName.Text.Trim() == "")
                return false;
            return true;
        }
        private CUSTOMERS ReturnCustInfo()
        {
            var cust = new CUSTOMERS()
            {
                code = txt_CustCod.Text,
                special = (chbox_CustSpecific.Checked) ? "t" : "f",
                MONAME = txt_CustName.Text,
                group_rdf = int.Parse(cbox_AccountSide.SelectedValue.ToString()),
                vis_rdf = int.Parse(cbox_Visitor.SelectedValue.ToString()),
                addre = txt_Address.Text,
                tell1 = txt_Tell.Text,
                cred = (chbox_CheckCredit.Checked) ? -1 :
                    (txt_Credibility.Text != "") ? 0 :
                    Convert.ToDecimal(txt_Credibility.Text),
                check_eteb = chbox_CheckCredit.Checked ? 1 : 0,
                sharh = rtxt_Description.Text,
                just_naghdi = (chbox_InvoiceToInvoice.Checked) ? 1 : 0,
                MaxManFactor = (chbox_InvoiceToInvoice.Checked) ? 0 :
                    (txt_MaxMinFactor.Text != "") ? 0 :
                    int.Parse(txt_MaxMinFactor.Text),
                BANKNAME = "--",
                tell2 = "",
                cell = "",
                active = "t",
                man = 0,
                rdf_city = 29,
                rdf_region = 42,
                hesab_status = 1,
                result_m = "ذکر نشد",
                SHHES = "",
                bankshobe = "",
                peygham1 = ""
            };
            
            return cust;

            //cust.code = txt_CustCod.Text;
            //if (chbox_CustSpecific.Checked)
            //    cust.special = "t";
            //else
            //    cust.special = "f";

            //cust.MONAME = txt_CustName.Text;

            ////using (UnitOfWork db = new UnitOfWork())
            ////{
            ////    cust.group_rdf = db.grCustgroup.get(c => c.group_name == cbox_AccountSide.Text)
            ////        .First().group_rdf;
            ////    cust.vis_rdf = db.grVisitor.get
            ////            (c => c.vis_name == cbox_Visitor.Text)
            ////        .First().vis_rdf;
            ////}
            //cust.group_rdf = int.Parse(cbox_AccountSide.SelectedValue.ToString());
            //cust.vis_rdf = int.Parse(cbox_Visitor.SelectedValue.ToString());
            //cust.addre = txt_Address.Text;
            //cust.tell1 = txt_Tell.Text;

            //if (chbox_CheckCredit.Checked)
            //    cust.cred = -1;
            //else if (txt_Credibility.Text != "")
            //    cust.cred = 0;
            //else
            //    cust.cred = Convert.ToDecimal(txt_Credibility.Text);
        
            //if (chbox_InvoiceToInvoice.Checked)
            //{
            //    cust.just_naghdi = 1;
            //    cust.MaxManFactor = 0;
            //}
            //else
            //{
            //    cust.just_naghdi = 0;
            //    if (txt_MaxMinFactor.Text != "")
            //        cust.MaxManFactor = 0;
            //    else
            //        cust.MaxManFactor = int.Parse(txt_MaxMinFactor.Text);
            //}
           
            //cust.check_eteb = chbox_CheckCredit.Checked ? 1 : 0;
            //cust.sharh = rtxt_Description.Text;

            ////// نکته : تبدیل 
            ////double x = 56.5;
            //////تبدیل نوع صریح (Explicit type conversion)
            ////decimal y = Convert.ToDecimal(56.5);
            ////// تبدیل نوع ضمنی(Implicit type conversion)
            ////decimal y1 = (Decimal)56.5;
            ////decimal y2 = 56.543m;

            ////----------- null
            //cust.BANKNAME = "--";
            //cust.tell2 = "";
            //cust.cell = "";
            //cust.active = "t";
            //cust.man = 0;
            //cust.rdf_city = 29;
            //cust.rdf_region = 42;
            //cust.hesab_status = 1;
            //cust.result_m = "ذکر نشد";
            //cust.SHHES = "";
            //cust.bankshobe = "";
            //cust.peygham1 = "";
        }

        private void btn_adoLambda_Click(object sender, EventArgs e)
        {
            if (!checkInfo())
            {
                MessageBox.Show("لطفا نام مشتری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CUSTOMERS customer = ReturnCustInfo();


                using (UnitOfWork db = new UnitOfWork())
                {
                    db.grCustomer.insert(customer);
                    db.Saveing();
                }

                ResultMessage();
            }
        }



        private void btn_adoQuery_Click(object sender, EventArgs e)
        {
            if (!checkInfo())
            {
                MessageBox.Show("لطفا نام مشتری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adoTest query = new adoTest();
                CUSTOMERS customer = ReturnCustInfo();
                query.insertQuery(customer.code, customer.special, customer.MONAME, customer.group_rdf,
                    customer.vis_rdf, customer.addre, customer.tell1, customer.cred, customer.check_eteb,
                    customer.just_naghdi, customer.MaxManFactor, customer.sharh);

                ResultMessage();
            }
        }

        private void btn_adoSP_Click(object sender, EventArgs e)
        {
            if (!checkInfo())
            {
                MessageBox.Show("لطفا نام مشتری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adoTest query = new adoTest();
                CUSTOMERS customer = ReturnCustInfo();
                query.insertSP(customer.code, customer.special, customer.MONAME, customer.group_rdf,
                    customer.vis_rdf, customer.addre, customer.tell1, customer.cred, customer.check_eteb,
                    customer.just_naghdi, customer.MaxManFactor, customer.sharh);

                ResultMessage();
            }
        }

        private void btn_entitySP_Click(object sender, EventArgs e)
        {
            if (!checkInfo())
            {
                MessageBox.Show("لطفا نام مشتری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CUSTOMERS customer = ReturnCustInfo();
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.insertEntitySP(customer.code, customer.special, customer.MONAME, customer.group_rdf,
                        customer.vis_rdf, customer.addre, customer.tell1, customer.cred, customer.check_eteb,
                        customer.just_naghdi, customer.MaxManFactor, customer.sharh);
                }

                ResultMessage();
            }
        }

        private void ResultMessage()
        {
            MessageBox.Show("مشتری وارد شد.");
            restform();
        }

        private void restform()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ID = db.grCustomer.getMaxID(c => c.SHMO) ?? 0;
                countcust = db.grCustomer.get(c => c.code.StartsWith("001029042")).Count();

            }

            txt_CustNumber.Text = (ID++).ToString();

            countcust++;
            if (countcust < 10)
                txt_CustCod.Text += "00";
            else if (countcust < 100)
                txt_CustCod.Text += "0";

            txt_CustCod.Text += countcust.ToString();

            txt_CustName.Text = "";
            chbox_CustSpecific.Checked = false;
            cbox_AccountSide.SelectedIndex = 0;
            cbox_Visitor.SelectedIndex = 0;
            txt_Address.Text = "خراسان جنوبي قائن شهرک آزادگان پيروزي 3";
            txt_Tell.Text = "";
            txt_Credibility.Text = "0";
            chbox_CheckCredit.Checked = false;
            chbox_CashPos.Checked = false;
            chbox_InvoiceToInvoice.Checked = false;

        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void chbox_InvoiceToInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_InvoiceToInvoice.Checked)
            {
                txt_MaxMinFactor.Text = (1).ToString();
            }
            else
            {
                txt_MaxMinFactor.Text = (0).ToString();
            }
        }

        private void chbox_CashPos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_CashPos.Checked)
            {
                txt_Credibility.Text = (-1).ToString();
            }
            else
            {
                txt_Credibility.Text = (0).ToString();
            }
        }

        private void btn_TopLastCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
