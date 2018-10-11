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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_Login logins = new BL.CLS_Login();

        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            #region التحقق من اسم المستخدم
            if (TxtUserName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            #endregion

            #region التحقق من كلمة المرور
            if (TxtUserPassWord.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserPassWord.Focus();
                return;
            }
            #endregion

            #region عملية الدخول
            DataTable dt = logins.Logins_Select(TxtUserName.Text, TxtUserPassWord.Text, true);
            if (dt.Rows.Count > 0)
            {
                #region عملية فتح الفورم والصلاحيات فيما بعد
                Program.loginDt = dt;
                this.Hide();

                //PL.Main.FRM_MAIN frm = new FRM_MAIN();
              //  frm.MdiParent = this.MdiParent;
                //frm.Show();

                return;
                #endregion
            }
            MessageBox.Show("خطأ في اسم المستخدم/كلمة المرور", "خطأ دخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxtUserName.Focus();
            return;

            #endregion


        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            #region النقل الى المربع الاخر
            try
            {
                #region الانتقال الى مربع كلمة السر
                if (e.KeyCode == Keys.Enter && TxtUserName.Text != string.Empty)
                {
                    TxtUserPassWord.Focus();

                }
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            #endregion

        }

        private void TxtUserPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            #region الانتقال الى الزر الدخول
            try
            {
                if (e.KeyCode == Keys.Enter && TxtUserName.Text != string.Empty)
                {
                    BtnOK.Focus();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            #endregion
        }
    }
}
