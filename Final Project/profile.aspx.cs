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
    public partial class profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              GetData();
            }
        }

        void GetData()
        {
            con.Close();
            string donarid = Convert.ToString(Session["DonarID"]);
            if (!string.IsNullOrEmpty(donarid))
            {
      
                SqlCommand cmd = new SqlCommand("select * from Donar where [Donar ID]=@donarid", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@donarid", donarid);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                   
                    TextName.Text = sdr.GetValue(1).ToString();
                    TextEmail.Text = sdr.GetValue(2).ToString();
                    txtPassword.Text = sdr.GetValue(3).ToString();
                    string bloodgroup = sdr.GetValue(4).ToString();
                    ddlbloodgroup.SelectedValue = bloodgroup;
                    txtContact.Text = sdr.GetValue(5).ToString();
                    TextCity.Text = sdr.GetValue(6).ToString();
                    
                }
                sdr.Close(); 
            }  
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Session["Donar ID"] == null)
            {
                Response.Redirect("Donar Request.aspx");
                return;
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
           
            SqlCommand cmd = new SqlCommand("update Donar set Name=@name,Email=@email,Password=@password,BloodGroup=@bloodgroup,Contact=@contact,City=@city where [Donar ID]=@donarid", con);
            cmd.Parameters.AddWithValue("@name", TextName.Text);
            cmd.Parameters.AddWithValue("@email", TextEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@BloodGroup", ddlbloodgroup.SelectedValue);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@City", TextCity.Text);
            cmd.Parameters.AddWithValue("@donarid", Session["Donar ID"]);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();

        }
    }
}