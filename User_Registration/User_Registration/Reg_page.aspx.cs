using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace User_Registration
{
    public partial class Reg_page : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string sql = "Insert into Users(UserName,Password,EmailId,Country,Gender) values(@f1,@f2,@f3,@f4,@f5)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@f1", txt_username.Text);
                cmd.Parameters.AddWithValue("@f2", txt_password.Text);
                cmd.Parameters.AddWithValue("@f3", txt_email.Text);
                cmd.Parameters.AddWithValue("@f4", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@f5", RadioButtonList1.SelectedValue);

                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}