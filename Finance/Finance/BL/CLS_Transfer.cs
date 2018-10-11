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

    }
}
