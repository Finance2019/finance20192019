using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.PL.Add
{
    public partial class FRM_Transfer : Form

    {
        #region متغيرات عامة على الفورم
        #region مسح التكست بوكس
        public void TxtClear()
        {
            TxtTranferID.Text = "";
            TxtTransferNum.Text = "";

        }
        #endregion


        #region نسخة الكلاس

        BL.CLS_Transfer trans = new BL.CLS_Transfer();

        #endregion

        #endregion

        public FRM_Transfer()
        {
            InitializeComponent();
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            TxtClear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            #region رقم جديد للسجل
            DataTable transdt = new DataTable();
            transdt = trans.TransferHD_NewID();
            TxtTranferID.Text = transdt.Rows[0][0].ToString();
           
            #endregion
        }
    }
}
