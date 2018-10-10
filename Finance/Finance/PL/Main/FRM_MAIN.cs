using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            try
            {
               // PL.Invoice.FRM_BUY_BILL f = new Invoice.FRM_BUY_BILL();
                //f.MdiParent = this.MdiParent;
               // f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
           // PL.Main.FRM_LOGIN frm = new FRM_LOGIN();
            //frm.Close();
        }

        private void Btn_Customers_Click(object sender, EventArgs e)
        {

            //PL.Parts.FRM_CUST_SUP frm = new Parts.FRM_CUST_SUP();
            //frm.MdiParent = this.MdiParent;
            //frm.label9.Text = "العمـــــــــــــــلاء";
            //frm.Text = "العمـــــــــــــــلاء";
            //frm.TxtSup_CustTypeID.Text = "1";
            //frm.TxtSup_Cust_FatherID.Text = "0";
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();

        }

        private void Btn_Vendors_Click(object sender, EventArgs e)
        {
            //PL.Parts.FRM_CUST_SUP frm = new Parts.FRM_CUST_SUP();
            //frm.MdiParent = this.MdiParent;
            //frm.label9.Text = "المــــــــــــــوردين";
            //frm.Text = "المــــــــــــــوردين";
            //frm.TxtSup_CustTypeID.Text = "2";
            //frm.TxtSup_Cust_FatherID.Text = "0";
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();

        }

        private void Btn_Unites_Click(object sender, EventArgs e)
        {
            //PL.Parts.FRM_UNITES frm = new Parts.FRM_UNITES();
            //frm.MdiParent = this.MdiParent;
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();
        }

        private void Btn_Groups_Click(object sender, EventArgs e)
        {
            //PL.Parts.FRM_GROUP frm = new Parts.FRM_GROUP();
            //frm.MdiParent = this.MdiParent;
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();
        }

        private void Btn_Category_Click(object sender, EventArgs e)
        {
            //PL.Parts.FRM_CATEGORY frm = new Parts.FRM_CATEGORY();
            //frm.MdiParent = this.MdiParent;
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();

        }

        private void Btn_Items_Click(object sender, EventArgs e)
        {
            //PL.Parts.FRM_ITEMS frm = new Parts.FRM_ITEMS();
            //frm.MdiParent = this.MdiParent;
            //frm.TxtAdminID.Text = Program.loginDt.Rows[0][3].ToString();
            //frm.Show();

        }
    }
}
