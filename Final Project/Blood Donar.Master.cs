using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Blood_Donar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Donar ID"]!=null)
            {
                liregister.Visible = false;
                lilogin.Visible = false;
                lidonationrequest.Visible = true;
                lilogout.Visible = true;
            }

            else
            {
                liregister.Visible = true;
                lilogin.Visible = true;
                lidonationrequest.Visible = false;
                lilogout.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Blood Donation.aspx");
        }
    }
}