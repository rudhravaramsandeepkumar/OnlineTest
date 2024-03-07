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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommandBuilder combu = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=SandyPavs_14;Integrated Security=True");
            loaddata();
        }
        public void loaddata()
        {
            da = new SqlDataAdapter("select * from finalproject",con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            combu = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "finalproject");

        }

        protected void btnaddcandidate_Click(object sender, EventArgs e)
        {
            loaddata();
            if(ds.Tables.Count>0)
            {
                DataRow rows = ds.Tables[0].NewRow();
                rows[1] = txtname.Text;
                rows[2] = txtemail.Text;
                rows[3] = txtmobilenumber.Text;
                rows[4] = txtpassword.Text;
                rows[5] = txtbatchnumber.Text;
                rows[6] = RadioButtonList1.SelectedItem;
                ds.Tables["finalproject"].Rows.Add(rows);
                int res = da.Update(ds, "finalproject");
                if(res>0)
                {
                    Lblname.Text = "Registration Success";
                }
                else
                {
                    Lblname.Text = "Not Added";
                }
            }
        }
    }
}