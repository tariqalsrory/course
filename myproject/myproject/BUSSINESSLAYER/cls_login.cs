using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace myproject.BUSSINESSLAYER
{
    class cls_login
    {
        public DataTable login(string id,string pass)
        {
            DAL.data_access_layer dal = new DAL.data_access_layer();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            parm[1].Value = pass;
            dal.opendata();
            DataTable dt = new DataTable();
            dt = dal.selectdata("sp_login", parm);
           dal.closedata();
            return dt;

        }
    }
}