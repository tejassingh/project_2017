using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


public partial class display_form : System.Web.UI.Page
{
    string strConnString = ConfigurationManager.ConnectionStrings["Basic_DetailsConnectionString"].ConnectionString;
    string str;
    SqlCommand com;



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mytext"] != null)
        {
            Label4.Text = Session["mytext"].ToString();
        }
        Response.Write(Label4.Text);
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "Select * from [Table] where Delhi_Mobile = '" + Label4.Text +"'";
        com = new SqlCommand(str, con);
        SqlDataReader reader = com.ExecuteReader();

        if (reader.Read())
        {
            Label1.Text = reader["Delhi_Address"].ToString();


            //  reader.Read();
            Label2.Text = reader["Delhi_Pincode"].ToString();

            //  reader.Read();
            Label3.Text = reader["Delhi_Telephone"].ToString();

            //  reader.Read();
            Label5.Text = reader["Per_Address"].ToString();

            //  reader.Read();
            Label6.Text = reader["Per_Pincode"].ToString();

            // reader.Read();
            Label7.Text = reader["Per_Telephone"].ToString();

            // reader.Read();
            Label8.Text = reader["Per_Mobile"].ToString();

            // reader.Read();
            Label9.Text = reader["Father_Occupation"].ToString();

            // reader.Read();
            Label10.Text = reader["Mother_Occupation"].ToString();

            // reader.Read();
            Label11.Text = reader["Other_Course"].ToString();

            // reader.Read();
            Label12.Text = reader["DU_Enroll"].ToString();


        }
        else
            Response.Write("ni mila");


        reader.Close();
        con.Close();

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write(Label4.Text);
    }
}

 

