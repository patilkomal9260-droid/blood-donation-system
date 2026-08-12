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
    public partial class Donar_Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Insert Into Donar Values (@Name,@Email,@password,@Bloodgroup,@Contact,@City)", con);
            cmd.Parameters.AddWithValue("@Name", TextName.Text);
            cmd.Parameters.AddWithValue("@Email", TextEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@BloodGroup", ddlbloodgroup.Text);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@City", TextCity.Text);

            con.Open();
            cmd.ExecuteNonQuery();

            TextName.Text = "";
            TextEmail.Text = "";
            txtPassword.Text = "";
            TextCity.Text = "";
            txtContact.Text = "";
            ddlbloodgroup.SelectedIndex = 0;


            this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Registered Successfully..!','','success');", true);

        }
    }
}