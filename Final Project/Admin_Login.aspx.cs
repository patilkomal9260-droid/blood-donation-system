using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@gmail.com" && txtPassword.Text == "admin")
            {
                Session["Admin"] = "True";
                Response.Redirect("View_Donarlist.aspx");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Invalid Login..!','','error');", true);
            }
        }
    }
}