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
    public partial class StudentResults : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder combud = null;
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=SandyPavs_14;Integrated Security=True");
            if(!Page.IsPostBack)
            {
                da = new SqlDataAdapter("select * from finalproject ",con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                combud = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds,"finalproject");
                DataTable dt = ds.Tables["finalproject"];
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("name");
                dt1.Columns.Add("mobile");
                dt1.Columns.Add("batchno");
                dt1.Columns.Add("que1");
                dt1.Columns.Add("que2");
                dt1.Columns.Add("que3");
                dt1.Columns.Add("que4");
               

                for (int i=0;i<dt.Rows.Count;i++)
                {
                    if(dt.Rows[i]["role"].ToString()=="Student")
                    {
                        dt1.Rows.Add(dt.Rows[i]["name"].ToString(), dt.Rows[i]["mobile"].ToString(), dt.Rows[i]["que1"].ToString(), dt.Rows[i]["que2"].ToString(), dt.Rows[i]["que3"].ToString(), dt.Rows[i]["que4"].ToString());
                    }
                }
                gridview.DataSource = dt1;
                gridview.DataBind();
                
            }
        }
    }
}