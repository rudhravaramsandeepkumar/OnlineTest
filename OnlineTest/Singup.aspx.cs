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
    public partial class Singup : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder combu = null;
        DataSet ds = null;
        string Email, password;
            int id;
        int rowscount;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=SandyPavs_14;Integrated Security=True");
            con.Open();
            if(Page.IsPostBack==false)
            {
                loadsno();
            }
        }
        public void loadsno()
        {
            da = new SqlDataAdapter("select * from finalproject ", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            combu = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "finalproject");
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            loadsno();
         rowscount=   ds.Tables["finalproject"].Rows.Count;
            for(int i=0;i<rowscount;i++)
            {
                Email = ds.Tables["finalproject"].Rows[i]["email"].ToString();
               // id = int.Parse( ds.Tables["finalproject"].Rows[i]["sid"].ToString());
                password = ds.Tables["finalproject"].Rows[i]["password"].ToString();
                if (Email == txtusername.Text && password == txtpassword.Text)
                {
                    Session["email"] = Email; 
                    if (ds.Tables["finalproject"].Rows[i]["role"].ToString() == "Admin")
                    {
                        Response.Redirect("~/Admin.aspx");
                    }
                    else
                        if (ds.Tables["finalproject"].Rows[i]["role"].ToString() == "Student")
                    {
                        Response.Redirect("~/Student.aspx");
                    }
                }
                else
                    lblmessage.Text = "username or password dosnt match";
               // break;
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }
    }
}