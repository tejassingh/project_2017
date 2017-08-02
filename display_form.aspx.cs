using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
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
    protected void Page_Load(object sender, System.EventArgs e)
    {
        if (Session["UserID"] != null)
        {
            Label_UserID.Text = Session["UserID"].ToString();
        }
        Response.Write(Label_UserID.Text);
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection con = new SqlConnection(CS);

        string basic_query = "Select * from [Basic_Details] where usrID='" + Label_UserID.Text+"'";
        SqlCommand basic_com = new SqlCommand(basic_query, con);
        con.Open();
        SqlDataReader basic_reader = basic_com.ExecuteReader();
        if (basic_reader.Read())
        {
            Label_AddressDelhi.Text= basic_reader["Delhi_Address"].ToString();
            Label_PincodeDelhi.Text = basic_reader["Delhi_Pincode"].ToString();
            Label_TelnoDelhi.Text = basic_reader["Delhi_Telephone"].ToString();
            Label_MobnoDelhi.Text = basic_reader["Delhi_MobileNo"].ToString();
            Label_PerAddress.Text = basic_reader["Per_Address"].ToString();
            Label_PerPincode.Text = basic_reader["Per_Pincode"].ToString();
            Label_PerTelno.Text = basic_reader["Per_Telephone"].ToString();
            Label_PerTelno.Text = basic_reader["Per_Telephone"].ToString();
            Label_PerTelno.Text = basic_reader["Per_Telephone"].ToString();
            Label_PerMobno.Text = basic_reader["Per_MobileNo"].ToString();
            Label_FathersOccu.Text = basic_reader["Fathers_Occupation"].ToString();
            Label_MothersOccu.Text = basic_reader["Mothers_Occupation"].ToString();
            Label_OtherUni.Text = basic_reader["Other_Course"].ToString();
        }
        basic_reader.Close();
        con.Close();

        string education_query = "Select * from [Educational_Details] where UsrID='" + Label_UserID.Text + "'";
        SqlCommand education_com = new SqlCommand(education_query, con);
        con.Open();
        SqlDataReader education_reader = education_com.ExecuteReader();
        if (education_reader.Read())
        {
            Label_GradCourse.Text = education_reader["Grad_Course"].ToString();
            Label_GradUni.Text = education_reader["Grad_University"].ToString();
            LabelGradYear.Text = education_reader["Grad_Year"].ToString();
            Label_GradDiv.Text = education_reader["Grad_Division"].ToString();
            Label_GradSub.Text = education_reader["Grad_Subjects"].ToString();
            Label_PGradCourse.Text = education_reader["PGrad_Course"].ToString();
            Label_PGradUni.Text = education_reader["PGrad_University"].ToString();
            Label_PGradYear.Text = education_reader["PGrad_Year"].ToString();
            Label_PGradDiv.Text = education_reader["PGrad_Division"].ToString();
            Label_PGradSub.Text = education_reader["PGrad_Subjects"].ToString();
            Label_MphilIUni.Text = education_reader["MPhil_I_University"].ToString();
            Label_MphilIYear.Text = education_reader["MPhil_I_Year"].ToString();
            Label_MphilIDiv.Text = education_reader["MPhil_I_Division"].ToString();
            Label_MphilISub.Text = education_reader["MPhil_I_Subjects"].ToString();
            Label_MphilIIUni.Text = education_reader["MPhil_II_University"].ToString();
            Label_MphilIIYear.Text = education_reader["MPhil_II_Year"].ToString();
            Label_MphilIIDiv.Text = education_reader["MPhil_II_Division"].ToString();
            Label_MphilIISub.Text = education_reader["MPhil_II_Subjects"].ToString();
            Label_Anyotherexam.Text = education_reader["Any_Other_Exam"].ToString();
            Label_AnyotherUni.Text = education_reader["Any_Other_Exam_Uni"].ToString();
            Label_AnyotherYear.Text = education_reader["Any_Other_Exam_Year"].ToString();
            Label_AnyotherDiv.Text = education_reader["Any_Other_Exam_Division"].ToString();
            Label_AnyotherSub.Text = education_reader["Any_Other_Exam_Subjects"].ToString();
        }
        education_reader.Close();
        con.Close();


    }

   /* protected void Button1_Click1(object sender, System.EventArgs e)
    {
        Response.Write(Label4.Text);
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        this.Page.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
    }*/

   
}

 

