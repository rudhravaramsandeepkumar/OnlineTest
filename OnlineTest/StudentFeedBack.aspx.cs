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
    public partial class StudentFeedBack : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommandBuilder combud = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        int rowcount;
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
                for (int i=0;i<dt.Rows.Count;i++)
                {
                    if(dt.Rows[i]["role"].ToString()=="Student")
                    {

                        dt1.Rows.Add(dt.Rows[i]["name"].ToString(), dt.Rows[i]["mobile"].ToString(), dt.Rows[i]["email"].ToString(),dt.Rows[i]["batchno"].ToString() ,dt.Rows[i]["disc"].ToString());
                    }
                }

                gridview.DataSource = dt1;
               gridview.DataBind();

            }
        }

        //protected void gridview_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    GridViewRow dr = e.Row;
        //    if(dr.Cells[6].Text=="Student")
        //    {
              
        //    }
        //}
        //public void loaddata()
        //{
        //    da = new SqlDataAdapter("select * from finalproject", con);
        //    da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //    combud = new SqlCommandBuilder(da);
        //    ds = new DataSet();
        //    da.Fill(ds, "finalproject");

        //rowcount = ds.Tables["finalproject"].Rows.Count;
        //DataTable dt = new DataTable();
        //DataRow rows = dt.NewRow();
        //for (int i=0;i<rowcount;i++)
        //{
        //    if(ds.Tables["finalproject"].Rows[i]["role"].ToString()=="Student")
        //    {
        //       rows[i]= ds.Tables["finalproject"].Rows[i]["name"].ToString();
        //      rows[i] = ds.Tables["finalproject"].Rows[i]["mobile"].ToString();
        //        //gridview.DataSource = ds.Tables["finalproject"].Rows[i]["email"].ToString();
        //        //gridview.DataSource = ds.Tables["finalproject"].Rows[i]["batchno"].ToString();
        //        //gridview.DataSource = ds.Tables["finalproject"].Rows[i]["disc"].ToString();
        //        dt.Rows.Add(rows);
        //    }
        //    gridview.DataSource = dt;
        //    gridview.DataBind();

        //}
        //if(ds.Tables.Count>0)
        //{
        //    for(int i=0;i<ds.Tables["finalproject"].Rows.Count;i++)
        //    {
        //        gridview.DataSource = ds.Tables["finalproject"];
        //        if(gridview.=="Student")
        //        {
        //txtrowid.Text = Gridview1.SelectedRow.Cells[1].Text;
        //txtname.Text = Gridview1.SelectedRow.Cells[2].Text;
        //txtmarks.Text = Gridview1.SelectedRow.Cells[3].Text;
        //        }
        //    }
        //}


    }
}