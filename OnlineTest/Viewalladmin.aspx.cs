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
    public partial class Viewalladmin : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommandBuilder combud = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        int rowscount;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=SandyPavs_14;Integrated Security=True");
            if (!Page.IsPostBack)
            {
                da = new SqlDataAdapter("select * from finalproject", con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                combud = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "finalproject");
                DataTable dt = ds.Tables["finalproject"];
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("name");
                dt1.Columns.Add("mobile");
                dt1.Columns.Add("email");
                dt1.Columns.Add("batchno");
                dt1.Columns.Add("disc");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["role"].ToString() == "Admin")
                    {

                        dt1.Rows.Add(dt.Rows[i]["name"].ToString(), dt.Rows[i]["mobile"].ToString(), dt.Rows[i]["email"].ToString(), dt.Rows[i]["batchno"].ToString(), dt.Rows[i]["disc"].ToString());
                    }
                }

                gridview.DataSource = dt1;
                gridview.DataBind();

            }

        }
    }
}