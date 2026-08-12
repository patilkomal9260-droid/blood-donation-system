using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Donar_Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from Donar where Email=@email and Password=@pwd", con);
            cmd.Parameters.AddWithValue("@email", TextEmail.Text);
            cmd.Parameters.AddWithValue("@pwd", TextPassword.Text);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();
                Session["DonarID"] = sdr.GetValue(0);
                Response.Redirect("profile.aspx");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Invalid Login..!','','error');", true);
            }

        }
    }
}