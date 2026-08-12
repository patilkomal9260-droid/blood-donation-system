using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class View_DonarRequest : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvdata.DataSource = GetAppointment();
                gvdata.DataBind();
            }    
           
        }

        DataSet GetAppointment()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select [Donar ID],Name,RequestDate,Status from DonarRequest", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.CommandArgument);
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            DropDownList ddl = (DropDownList)row.FindControl("ddlStatus");
            string status = ddl.SelectedItem.Text;


            SqlCommand cmd = new SqlCommand("Update DonarRequest set Status=@status where [Donar ID]=@id", con);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@ID", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close() ;
            GetAppointment();
        }
    }
}