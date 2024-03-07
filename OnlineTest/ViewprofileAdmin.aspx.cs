using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OnlineTest
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommandBuilder combud = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        
        int rowscount;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=SandyPavs_14;Integrated Security=True");
            loaddata();
            rowscount = ds.Tables["finalproject"].Rows.Count;
            for (int i = 0; i < rowscount; i++)
            {
                if (Session["email"].ToString() == ds.Tables["finalproject"].Rows[i]["email"].ToString())

                {
                    lblname.Text = ds.Tables["finalproject"].Rows[i]["name"].ToString();
                    lblemail.Text = ds.Tables["finalproject"].Rows[i]["email"].ToString();
                    lblmobile.Text = ds.Tables["finalproject"].Rows[i]["mobile"].ToString();
                    lblbatchno.Text = ds.Tables["finalproject"].Rows[i]["batchno"].ToString();
                }
            }
        }
        public void loaddata()
        {
            da = new SqlDataAdapter("select * from finalproject", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            combud = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "finalproject");
        }

    }
}
