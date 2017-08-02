using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_login_Click(object sender, EventArgs e)
    {
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        try
        {
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            string checkuserquery = "select count(*) from login where usrid='"+ Text_UserID.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuserquery, con);
            Int32 temp = (Int32)cmd.ExecuteScalar();
            con.Close();
            if (temp == 1)
            {
                con.Open();
                string checkpasswordquery = "select password from login where usrid='" + Text_UserID.Text + "'";
                SqlCommand passcmd = new SqlCommand(checkpasswordquery, con);
                string password = passcmd.ExecuteScalar().ToString().Replace(" ","");
                con.Close();
                if (password == Text_Password.Text)
                {
                    //Response.Write("Login successful!!!");
                    Session["usrid"] = Text_UserID.Text;
                    Response.Redirect("~/adm_form.aspx");
                }
                else
                {
                    Response.Write("Password Incorrect");
                }
            }
            else
            {
                Response.Write("User ID does not exists");
            }
        }
        catch (Exception ex1)
        {
            Response.Write("ERROR:" + ex1.ToString());
        }
 
    }
}