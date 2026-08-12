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
    public partial class Donar_Request : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("Insert Into [DonarRequest] values (@Name,@RequestDate,@Status)", con);
            cmd.Parameters.AddWithValue("@name", TextName.Text);
            cmd.Parameters.AddWithValue("@RequestDate", TextRequestDate.Text);
            cmd.Parameters.AddWithValue("@Status", Textstatus.Text );
            

            con.Open();
            cmd.ExecuteNonQuery();

            TextName.Text = "";
            TextRequestDate.Text = "";
            Textstatus.Text = "";

            this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Donar Request Submitted..!','','success');", true);


        }
    }
}