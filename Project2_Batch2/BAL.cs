using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace _3_tier2
{
    public class BAL
    {
        public DataTable holdName(string name)
        {
            string Bname = name;
            DAL dal = new DAL();
            DataTable DalName = dal.Dholdname(Bname);
            return DalName;
        }

    }
}

