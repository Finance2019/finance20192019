using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance.BL
{
    class CLS_Transfer
    {
        #region جلب رقم جديد للسجل
        public DataTable TransferHD_NewID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("TransferHD_NewID", null);
            return dt;
        }


        #endregion

        #region اضافة قرار جديد

        public void TransferHD_Add(
                                  int TranferID,
                                  int TransferNum,
                                  DateTime TransferDate,
                                  int AddAdminID
                                )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@TranferID", SqlDbType.Int);
            param[0].Value = TranferID;

            param[1] = new SqlParameter("@TransferNum", SqlDbType.Int);
            param[1].Value = TransferNum;

            param[2] = new SqlParameter("@TransferDate", SqlDbType.Date);
            param[2].Value = TransferDate;

            param[3] = new SqlParameter("@AddAdminID", SqlDbType.Int);
            param[3].Value = AddAdminID;

            DAL.ExecuteCommand("TransferHD_Add", param);

            DAL.Close();
        }


        #endregion

        #region تعديل قرار 

        public void TransferHD_Update(
                                  int TranferID,
                                  int TransferNum,
                                  DateTime TransferDate,
                                  int EditAdminID
                                )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@TranferID", SqlDbType.Int);
            param[0].Value = TranferID;

            param[1] = new SqlParameter("@TransferNum", SqlDbType.Int);
            param[1].Value = TransferNum;

            param[2] = new SqlParameter("@TransferDate", SqlDbType.Date);
            param[2].Value = TransferDate;

            param[3] = new SqlParameter("@EditAdminID", SqlDbType.Int);
            param[3].Value = EditAdminID;

            DAL.ExecuteCommand("TransferHD_Update", param);

            DAL.Close();
        }


        #endregion

        #region حذف قرار 

        public void TransferHD_Del(
                                  int TranferID
                                )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TranferID", SqlDbType.Int);
            param[0].Value = TranferID;

            DAL.ExecuteCommand("TransferHD_Del", param);

            DAL.Close();
        }


        #endregion


    }
}
