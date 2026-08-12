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
    public partial class View_profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
                GetData();
        }
            void GetData()
            {
                con.Close();
                    SqlCommand cmd = new SqlCommand("select * from Donar where [Donar ID]=@donarid", con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@donarid", Request.QueryString["id"]);
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
    }
