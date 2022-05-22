using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Project2_Batch2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void display_Click(object sender, EventArgs e)
        {
            //string name = TextBox1.Text;
            BAL bal = new BAL();
            DataTable dt = bal.holdName(name);
            GridView1.DataSource = dt;
            GridView1.DataBind();



        }


    }

}