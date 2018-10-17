using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Finance.BL
{
    class CLS_Search
    {
        #region كلاس ااختيار موظف

        public DataTable Admins_Search(String TxtSearch)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TxtSearch", SqlDbType.NVarChar, 50);
            param[0].Value = TxtSearch;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Admins_Search", param);
            return dt;
        }

        #endregion

    }
}
