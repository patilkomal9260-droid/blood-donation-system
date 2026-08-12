using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin"] != null)
            {
               lilogin.Visible = false;
               liviewdonar.Visible = true;
               lidonarrequest.Visible = true;
               lidonardetails.Visible = true;
               lilogout.Visible = true;
            }

            else
            {
                lilogin.Visible = true;
                liviewdonar.Visible = false;
                lidonarrequest.Visible = false;
                lidonardetails.Visible = false;
                lilogout.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
           
        }
    }
}