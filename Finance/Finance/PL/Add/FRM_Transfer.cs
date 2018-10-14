using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Finance.PL.Add
{
    public partial class FRM_Transfer : Form

    {
        #region متغيرات عامة على الفورم

        #region مسح التكست بوكس
        public void ClearAll()
        {
            TxtTranferID.Text = "";
            TxtTransferNum.Text = "";
        }
        #endregion

        #region نسخة الكلاس

        BL.CLS_Transfer trans = new BL.CLS_Transfer();

        #endregion

        #region متغير نص
        string stat = "xxx";
        int ID_;
        #endregion

        #region تفعيل  جميع الازرار 

        public void BTN_Enble()
        {
            Btn_New.Visible = true;
            Btn_Edit.Visible = true;
            Btn_Del.Visible = true;
            Btn_Save.Visible = false;
            Btn_Undo.Visible = false;
            Btn_Print.Visible = true;
            Btn_First.Visible = true;
            Btn_Prev.Visible = true;
            Btn_Next.Visible = true;
            Btn_Last.Visible = true;

        }

        #endregion

        #region تعطيل  جميع الازرار 

        public void BTN_Disable()
        {
            Btn_New.Visible = false;
            Btn_Edit.Visible = false;
            Btn_Del.Visible = false;
            Btn_Save.Visible = true;
            Btn_Undo.Visible = true;
            Btn_Print.Visible = false;
            Btn_First.Visible = false;
            Btn_Prev.Visible = false;
            Btn_Next.Visible = false;
            Btn_Last.Visible = false;

        }

        #endregion

        #region تفعيل التكستات

        public void Txt_Enable()
        {

            TxtTransferNum.ReadOnly = false;
            TxtTranferID.ReadOnly = true;
            DTP.Enabled = true;
        }

        #endregion

        #region تعطيل التكستات

        public void Txt_Disable()
        {

            TxtTransferNum.ReadOnly = true;
            TxtTranferID.ReadOnly = false;
            DTP.Enabled = false;
        }

        #endregion

        #region التنقل 

        public void Move(int rec)
        {
            DataTable transDT = trans.TransferHD_All();
            TxtTranferID.Text = transDT.Rows[rec][0].ToString();
            TxtTransferNum.Text = transDT.Rows[rec][1].ToString();
            DTP.Text = transDT.Rows[rec][2].ToString();
        }

        #endregion


        #endregion

        #region العمليات التى تتم على الفورم
        public FRM_Transfer()
        {
            InitializeComponent();
           
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            #region زر حفظ
            try
            {
                #region التحقق من الفراغات

                #region  ملء الفراغ  رقم واسم القرار
                if (TxtTransferNum.Text == string.Empty.Trim())
                {
                    TxtTransferNum.Focus();
                    MessageBox.Show("يجب ادخال رقم القرار", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region ملء الفراغ  تاريخ القرار
                if (DTP.Text == String.Empty.Trim())
                {
                    DTP.Focus();
                    MessageBox.Show("يجب ادخال التاريخ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion


                #endregion


                #region تنفيذ الحفظ والتعديل
                Txt_Disable();
                BTN_Enble();
                if (stat == "new")
                {
                    #endregion

                    #region رقم جديد للسجل
                    DataTable transdt = new DataTable();
                    transdt = trans.TransferHD_NewID();
                    TxtTranferID.Text = transdt.Rows[0][0].ToString();

                    #endregion

                    #region الحفظ

                    //كود الحفظ -- جديد
                    trans.TransferHD_Add(
                        Convert.ToInt32(TxtTranferID.Text.Trim()),
                        Convert.ToInt32(TxtTransferNum.Text.Trim()),
                        DTP.Value,
                       Convert.ToInt32( Program.loginDt.Rows[0][2].ToString())
                   
                        );

                    #endregion


                }
                else
                {
                    #region تعديل
                    trans.TransferHD_Update(
                                          Convert.ToInt32(TxtTranferID.Text.Trim()),
                                          Convert.ToInt32(TxtTransferNum.Text.Trim()),
                                          DTP.Value,
                                         Convert.ToInt32(Program.loginDt.Rows[0][2].ToString())

                                          );
                    #endregion

                }

                //DGV_All_Search();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            #endregion

        }

        private void Btn_New_Click_1(object sender, EventArgs e)
        {
            #region جديد
            try
            {
                ClearAll();
                stat = "new";
                BTN_Disable();
                Txt_Enable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            #endregion
        }

        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 

            try
            {
                DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (m == DialogResult.OK)
                {
                    if (stat == "new")
                    {
                        ClearAll();
                    }
                    else
                    {
                       // كود للعودة الى الوضع السابق في حالة التعديل
                    }
                    Txt_Disable();
                    BTN_Enble();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            #endregion

        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            #region الحذف
            try
            {
                if (TxtTranferID.Text == string.Empty.Trim())
                {
                    return;
                }


                #region عملية الحذف ورسالة التاكيد عليها 
                DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (m == DialogResult.OK)
                {
                    #region عملية الحذف
                    trans.TransferHD_Del(Convert.ToInt32(TxtTranferID.Text));
                    ClearAll();
                }
                else
                {
                    ClearAll();
                    return;
                }



                #endregion

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }


            #endregion
            #endregion
        }

        private void TxtTransferNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region منع كتابة الحروف داخل المبلغ
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            #endregion

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            #region تعديل
            try
            {
                if (TxtTranferID.Text==string.Empty.Trim())
                {
                    return;
                }
                stat = "edit";
                BTN_Disable();
                Txt_Enable();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            #endregion
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            #region زرار اول سجل
            try
            {

                ////للمراجعة فيما بعد
                //if (ID_ == 0 || TxtTranferID.Text != string.Empty.Trim())
                //{
                //    return;
                //}
                ID_ = 0;
                Move(ID_);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                
            }
            #endregion
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            #region زرار اخر سجل
            try
            {
                if (ID_ == trans.TransferHD_All().Rows.Count - 1)
                {
                    return;
                }
                ID_ = trans.TransferHD_All().Rows.Count - 1;
                Move(ID_);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

            #endregion
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            #region زرار السابق
            try
            {
                if (ID_ == 0)
                {
                    return;
                }

                ID_ -= 1;
                Move(ID_);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

            #endregion
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            #region زرار التالى
            try
            {
                if (ID_ == trans.TransferHD_All().Rows.Count - 1)
                {
                    return;
                }

                ID_ += 1;
                Move(ID_);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

            #endregion
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            #region طباعة

            #endregion

        }
        #endregion
    }

}
