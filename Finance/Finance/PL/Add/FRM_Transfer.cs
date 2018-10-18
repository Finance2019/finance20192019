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
        #region نسخة الكلاس

        BL.CLS_Transfer trans = new BL.CLS_Transfer();
        BL.CLS_Search search_ = new BL.CLS_Search();


        #endregion

        #region متغيرات عامة على الفورم

        #region مكونات الداتا جريد
        public void DGV_Column()
        {
         #region رقم الموظف
         DataGridViewTextBoxColumn AdminID = new DataGridViewTextBoxColumn();
         AdminID.DataPropertyName = "AdminID";
         AdminID.HeaderText = "رقم الموظف";
         AdminID.Width = 70;
            #endregion

         #region اسم الموظف
            DataGridViewTextBoxColumn AdminName = new DataGridViewTextBoxColumn();
            AdminName.DataPropertyName = "AdminName";
            AdminName.HeaderText = "اسم الموظف";
            AdminName.Width = 150;
            AdminName.ReadOnly = true;
            #endregion

         #region رقم الوحدة 
            DataGridViewTextBoxColumn AccountUnitsID = new DataGridViewTextBoxColumn();
            AccountUnitsID.DataPropertyName = "AccountUnitsID";
            AccountUnitsID.HeaderText = "رقم الوحدة";
            AccountUnitsID.Width = 50;
            #endregion

         #region اسم  الوحدة 
            DataGridViewTextBoxColumn AccountUnitsName = new DataGridViewTextBoxColumn();
            AccountUnitsName.DataPropertyName = "AccountUnitsName";
            AccountUnitsName.HeaderText = "اسم الوحدة المحول منها";
            AccountUnitsName.Width = 105;
            AccountUnitsName.ReadOnly = true;
            #endregion

         #region رقم الوحدة 
            DataGridViewTextBoxColumn AccountUnitsID2 = new DataGridViewTextBoxColumn();
            AccountUnitsID2.DataPropertyName = "AccountUnitsID2";
            AccountUnitsID2.HeaderText = "رقم الوحدة";
            AccountUnitsID2.Width = 50;
            #endregion

         #region اسم  الوحدة 
            DataGridViewTextBoxColumn AccountUnitsName2 = new DataGridViewTextBoxColumn();
            AccountUnitsName2.DataPropertyName = "AccountUnitsName2";
            AccountUnitsName2.HeaderText = "اسم الوحدة المحول اليها";
            AccountUnitsName2.Width = 105;
            AccountUnitsName2.ReadOnly = true;
            #endregion

         #region اضافات الاعمدة
            DGV.Columns.Add(AdminID);
            DGV.Columns.Add(AdminName);
            DGV.Columns.Add(AccountUnitsID);
            DGV.Columns.Add(AccountUnitsName);
            DGV.Columns.Add(AccountUnitsID2);
            DGV.Columns.Add(AccountUnitsName2);


            #endregion
        }



        #endregion

        #region مسح التكست بوكس
        public void ClearAll()
        {
            TxtTranferID.Text = "";
            TxtTransferNum.Text = "";
        }
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

        #region ادراج اسم الموظف ورقمه
      public void AdminInsert()
        {
            if (Program.GlobalDT != null)
            {
                this.DGV.CurrentRow.Cells[0].Value = Program.GlobalDT.Rows[0][0];
                this.DGV.CurrentRow.Cells[1].Value = Program.GlobalDT.Rows[0][1];
            }
        }

        #endregion


        #region مسح الصف
       public void RowClear()
        {
                this.DGV.CurrentRow.Cells[0].Value = null;
                this.DGV.CurrentRow.Cells[1].Value = null;
                this.DGV.CurrentRow.Cells[2].Value = null;
                this.DGV.CurrentRow.Cells[3].Value = null;
                this.DGV.CurrentRow.Cells[4].Value = null;
                this.DGV.CurrentRow.Cells[5].Value = null;


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

            DGV_Column();


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

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV.BeginEdit(true);

        }

        private void DGV_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            #region ادراج اسم ورقم الموظف

            //ثلاث حالات
            //الحالة الاولى عدم وجود الاسم
            if (DGV.CurrentCell.ColumnIndex == 0 && DGV.Rows[e.RowIndex].Cells[0].Value == null)
            {
                RowClear();
            }
            // حالات الكتابة داخل
            if (DGV.CurrentCell.ColumnIndex == 0 && DGV.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Program.GlobalDT= search_.Admins_Search(this.DGV.CurrentRow.Cells[0].Value.ToString());
                if (Program.GlobalDT.Rows.Count==0)
                {
                    RowClear();
                }
                if (Program.GlobalDT.Rows.Count == 1)
                {
                    AdminInsert();
                }

                if (Program.GlobalDT.Rows.Count > 1)
                {
                    PL.Genral.FRM_AdminSearch frm = new Genral.FRM_AdminSearch();
                    frm.ShowDialog();
                    if (frm.insertRow == true)
                    {
                        RowClear();
                        this.DGV.CurrentRow.Cells[0].Value = frm.DGV_AdminSearch.CurrentRow.Cells[0].Value;
                        this.DGV.CurrentRow.Cells[1].Value = frm.DGV_AdminSearch.CurrentRow.Cells[1].Value;

                    }
                }



            }

            //// الحالة الثانية في حالة وجوداكثر من  مقترح واحد للموظف
            //if (DGV.CurrentCell.ColumnIndex == 0 && DGV.Rows[e.RowIndex].Cells[0].Value != null)
            //{
            //    Program.GlobalDT = search_.Admins_Search(this.DGV.CurrentRow.Cells[0].ToString());
            //}




            #endregion
        }
    }

}
