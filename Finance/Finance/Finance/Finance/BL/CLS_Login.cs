using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Finance.BL
{
    class CLS_Login
    {
        #region كلاس الدخول على البرنامج

        public DataTable Logins_Select(String TxtUserName, String UserPassWord, bool IsActive)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = TxtUserName;
            param[1] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 50);
            param[1].Value = UserPassWord;
            param[2] = new SqlParameter("@IsActive", SqlDbType.Bit);
            param[2].Value = IsActive;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Logins_select", param);
            return dt;
        }

        #endregion

    }
}
