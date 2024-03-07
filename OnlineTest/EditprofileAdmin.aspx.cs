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
    public partial class EditprofileAdmin : System.Web.UI.Page
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
            if (Page.IsPostBack == false)
            {
                rowscount = ds.Tables["finalproject"].Rows.Count;
                for (int i = 0; i < rowscount; i++)
                {
                    if (Session["email"].ToString() == ds.Tables["finalproject"].Rows[i]["email"].ToString())

                    {
                        Label1.Text = ds.Tables["finalproject"].Rows[i]["sid"].ToString();
                        txtusername.Text = ds.Tables["finalproject"].Rows[i]["name"].ToString();
                        txtemail.Text = ds.Tables["finalproject"].Rows[i]["email"].ToString();
                        txtmobile.Text = ds.Tables["finalproject"].Rows[i]["mobile"].ToString();
                        txtbatchno.Text = ds.Tables["finalproject"].Rows[i]["batchno"].ToString();
                    }
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

        protected void btnupdate_Click(object sender, EventArgs e)
        {
           
          if(ds.Tables.Count>0)
            {
                int Serchno = int.Parse(Label1.Text);
                DataRow drow = ds.Tables["finalproject"].Rows.Find(Serchno);
                if(drow!=null)
                {
                    drow["name"] = txtusername.Text;
                    drow["email"] = txtemail.Text;
                    drow["mobile"] = txtmobile.Text;
                    drow["batchno"] = txtbatchno.Text;
                   
                   int res= da.Update(ds, "finalproject");
                    if(res>0)
                    {
                        lblmessage.Text = "updated";
                    }
                    else
                    {
                        lblmessage.Text = "not";
                    }
                    
                }
            }
        }
    }
}