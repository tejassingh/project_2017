using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace PhD
{
    public partial class admission_form : System.Web.UI.Page
    {
        private enum TabIndex
        {
            DEFAULT = 0,
            ONE = 1,
            TWO = 2,
            THREE = 3,
            FOUR = 4
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["usrid"].ToString()))
            {
                Label_UserID.Text = Session["usrid"].ToString();
            }
            if (!IsPostBack)
            {
                TextBoxD2.Text = "Select Department";
                populatefields();
            }
        }

       private void populatefields()             //Check if user has partially filled form or not
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string checkuser_Basic_Details = "select count(*) from Basic_Details where usrid='" + Label_UserID.Text + "'";
                SqlCommand checkuser_Basic_Details_cmd = new SqlCommand(checkuser_Basic_Details, con);
                int result_Basic_Details = (int)checkuser_Basic_Details_cmd.ExecuteScalar();
                con.Close();
                if (result_Basic_Details == 1)
                {
                    con.Open();
                    SqlDataReader usrReader_Basic_Details = null;
                    SqlCommand usr_Basic_Details = new SqlCommand("select * from Basic_Details where usrid='" + Label_UserID.Text + "'", con);
                    usrReader_Basic_Details = usr_Basic_Details.ExecuteReader();
                    while (usrReader_Basic_Details.Read())
                    {
                        TextBox_Address_Delhi.Text = (usrReader_Basic_Details.GetValue(1).ToString());
                        TextBox_Pincode_Delhi.Text = (usrReader_Basic_Details.GetValue(2).ToString());
                        TextBox_Telephone_Delhi.Text = (usrReader_Basic_Details.GetValue(3).ToString());
                        TextBox_MobileNo.Text = (usrReader_Basic_Details.GetValue(4).ToString());
                        TextBox_Per_Add.Text = (usrReader_Basic_Details.GetValue(5).ToString());
                        TextBox_Per_Pincode.Text = (usrReader_Basic_Details.GetValue(6).ToString());
                        TextBox_Per_Telephone.Text = (usrReader_Basic_Details.GetValue(7).ToString());
                        TextBox_Per_MobileNo.Text = (usrReader_Basic_Details.GetValue(8).ToString());
                        TextBox_fathersocc.Text = (usrReader_Basic_Details.GetValue(9).ToString());
                        TextBox_mothersocc.Text = (usrReader_Basic_Details.GetValue(10).ToString());
                        TextBox_otheruni.Text = (usrReader_Basic_Details.GetValue(11).ToString());
                        TextBox_EnrollNo.Text = (usrReader_Basic_Details.GetValue(12).ToString());
                        DropDownListDepartment.SelectedItem.Text = (usrReader_Basic_Details.GetValue(13).ToString());
                    }
                    con.Close();
                }
                string checkuser_Education_Details = "select count(*) from Educational_Details where usrid='" + Label_UserID.Text + "'";
                con.Open();
                SqlCommand checkuser_Education_Details_cmd = new SqlCommand(checkuser_Education_Details, con);
                Int32 result_Education_Details = (Int32)checkuser_Education_Details_cmd.ExecuteScalar();
                con.Close();
                if (result_Education_Details == 1)
                {
                    con.Open();
                    SqlDataReader usrReader_Educational_Details = null;
                    SqlCommand usr_Educational_Details = new SqlCommand("select * from Educational_Details where usrid='" + Label_UserID.Text + "'", con);
                    usrReader_Educational_Details = usr_Educational_Details.ExecuteReader();
                    while (usrReader_Educational_Details.Read())
                    {
                        DropDownList_Grad_Course.SelectedItem.Text = (usrReader_Educational_Details.GetValue(1).ToString());
                        TextBox_Grad_Uni.Text = (usrReader_Educational_Details.GetValue(2).ToString());
                        TextBox_Grad_Year.Text = (usrReader_Educational_Details.GetValue(3).ToString());
                        TextBox_Grad_Div.Text = (usrReader_Educational_Details.GetValue(4).ToString());
                        TextBox_Grad_Subjects.Text = (usrReader_Educational_Details.GetValue(5).ToString());
                        DropDownList_PGrad_Course.SelectedItem.Text = (usrReader_Educational_Details.GetValue(6).ToString());
                        TextBox_PGrad_Uni.Text = (usrReader_Educational_Details.GetValue(7).ToString());
                        TextBox_PGrad_Year.Text = (usrReader_Educational_Details.GetValue(8).ToString());
                        TextBox_PGrad_Div.Text = (usrReader_Educational_Details.GetValue(9).ToString());
                        TextBox_PGrad_Subjects.Text = (usrReader_Educational_Details.GetValue(10).ToString());
                        TextBox_MPhil_1_Uni.Text = (usrReader_Educational_Details.GetValue(11).ToString());
                        TextBox_MPhil_1_Year.Text = (usrReader_Educational_Details.GetValue(12).ToString());
                        TextBox_MPhil_1_Div.Text = (usrReader_Educational_Details.GetValue(13).ToString());
                        TextBox_MPhil_1_Subjects.Text = (usrReader_Educational_Details.GetValue(14).ToString());
                        TextBox_MPhil_2_Uni.Text = (usrReader_Educational_Details.GetValue(15).ToString());
                        TextBox_MPhil_2_Year.Text = (usrReader_Educational_Details.GetValue(16).ToString());
                        TextBox_MPhil_2_Div.Text = (usrReader_Educational_Details.GetValue(17).ToString());
                        TextBox_MPhil_2_Subjects.Text = (usrReader_Educational_Details.GetValue(18).ToString());
                        TextBox_AnyOther_Uni.Text = (usrReader_Educational_Details.GetValue(19).ToString());
                        TextBox_AnyOther_Year.Text = (usrReader_Educational_Details.GetValue(20).ToString());
                        TextBox_AnyOther_Div.Text = (usrReader_Educational_Details.GetValue(21).ToString());
                        TextBox_AnyOther_Subjects.Text = (usrReader_Educational_Details.GetValue(22).ToString());
                    }
                    con.Close();
                }
            }
            catch(Exception ex1)
            {
                Response.Write("ERROR: " + ex1.ToString());
            } 
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox_Per_Add_TextChanged(object sender, EventArgs e)
        {

        }



        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
       /* protected void RadioButtonList_Currently_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList_Currently_Emp.SelectedItem.Text == "YES")
            {
                TextBox_Name_Insti.Enabled = true;
                TextBox_Designation.Enabled = true;
                TextBox_From_Date.Enabled = true;
                TextBox_To_Date.Enabled = true;
                RadioButtonList_Type_Emp.Enabled = true;
                TextBox_Brief_Details.Enabled = true;
                TextBox_Office_TelNo.Enabled = true;

            }
            else if (RadioButtonList_Currently_Emp.SelectedItem.Text == "NO")
            {
                TextBox_Name_Insti.Enabled = false;
                TextBox_Designation.Enabled = false;
                TextBox_From_Date.Enabled = false;
                TextBox_To_Date.Enabled = false;
                RadioButtonList_Type_Emp.Enabled = false;
                TextBox_Brief_Details.Enabled = false;
                TextBox_Office_TelNo.Enabled = false;
            }
        } */

        protected void TextBox31_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox37_TextChanged(object sender, EventArgs e)
        {
            
        }





        protected void TextBox37_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void DropDownListDepartment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Text == "YES")
            {
                TextBox_otheruni.Enabled = true;
            }
            else if (RadioButtonList1.SelectedItem.Text == "NO")
            {
                TextBox_otheruni.Enabled = false;
            }

        }

        private void SetSelectedTab(TabIndex tabIndex)
        {
            Hdnfldtabs.Value = ((int)tabIndex).ToString();
        }

        /*protected void Button3_Click(object sender, EventArgs e)
        {
            
        }*/


       


        protected void Save1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string checkuserid="select count(*) from Basic_Details where usrID='"+Label_UserID.Text+"'";
                SqlCommand checkuseridcmd = new SqlCommand(checkuserid, con);
                Int32 result = (Int32)checkuseridcmd.ExecuteScalar();
                con.Close();
                if (result == 0)
                {
                    string insertQuery = "insert into [Basic_Details] values(@usrid,@deladd,@delpincode,@deltelno,@delmobno,@peradd,@perpincode,@pertelno,@permobno,@fathersocc,@mothersocc,@othercourse,@enrollno,@department)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@usrid", Label_UserID.Text);
                    cmd.Parameters.AddWithValue("@deladd", TextBox_Address_Delhi.Text);
                    cmd.Parameters.AddWithValue("@delpincode", TextBox_Pincode_Delhi.Text);
                    cmd.Parameters.AddWithValue("@deltelno", TextBox_Telephone_Delhi.Text);
                    cmd.Parameters.AddWithValue("@delmobno", TextBox_MobileNo.Text);
                    cmd.Parameters.AddWithValue("@peradd", TextBox_Per_Add.Text);
                    cmd.Parameters.AddWithValue("@perpincode", TextBox_Per_Pincode.Text);
                    cmd.Parameters.AddWithValue("@pertelno", TextBox_Per_Telephone.Text);
                    cmd.Parameters.AddWithValue("@permobno", TextBox_Per_MobileNo.Text);
                    if (string.IsNullOrWhiteSpace(TextBox_fathersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@fathersocc", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fathersocc", TextBox_fathersocc.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_mothersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@mothersocc", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@mothersocc", TextBox_mothersocc.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_otheruni.Text))
                    {
                        cmd.Parameters.AddWithValue("@othercourse", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@othercourse", TextBox_otheruni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_mothersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@enrollno", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@enrollno", TextBox_EnrollNo.Text);
                    }
                    cmd.Parameters.AddWithValue("@department", DropDownListDepartment.SelectedItem.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                string checkuser_Education_id="select count(*) from Educational_Details where UsrID='"+Label_UserID.Text+"'";
                con.Open();
                SqlCommand checkuser_Education_cmd = new SqlCommand(checkuser_Education_id, con);
                Int32 result_Education = (Int32)checkuser_Education_cmd.ExecuteScalar();
                con.Close();
                if (result_Education == 0)
                {
                    string insertQuery1 = "insert into [Educational_Details] values(@usrid,@gradcourse,@graduni,@gradyear,@graddiv,@gradsub,@pgradcourse,@graduni,@pgradyear,@pgraddiv,@pgradsub,@mphiluni1,@mphilyr1,@mphildiv1,@mphilsub1,@mphiluni2,@mphilyr2,@mphildiv2,@mphilsub2,@anyotherexuni,@anyotherexyr,@anyotherexdiv,@anyotherexsub)";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(insertQuery1, con);
                    cmd1.Parameters.AddWithValue("@usrid", Label_UserID.Text);
                    cmd1.Parameters.AddWithValue("@gradcourse", DropDownList_Grad_Course.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@graduni", TextBox_Grad_Uni.Text);
                    cmd1.Parameters.AddWithValue("@gradyear", TextBox_Grad_Year.Text);
                    cmd1.Parameters.AddWithValue("@graddiv", TextBox_Grad_Div.Text);
                    cmd1.Parameters.AddWithValue("@gradsub", TextBox_Grad_Subjects.Text);
                    cmd1.Parameters.AddWithValue("@pgradcourse", DropDownList_PGrad_Course.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@pgraduni", TextBox_PGrad_Uni.Text);
                    cmd1.Parameters.AddWithValue("@pgradyear", TextBox_PGrad_Year.Text);
                    cmd1.Parameters.AddWithValue("@pgraddiv", TextBox_PGrad_Div.Text);
                    cmd1.Parameters.AddWithValue("@pgradsub", TextBox_PGrad_Subjects.Text);
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni1", TextBox_MPhil_1_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr1", TextBox_MPhil_1_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv1", TextBox_MPhil_1_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub1", TextBox_MPhil_1_Subjects.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni2", TextBox_MPhil_2_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr2", TextBox_MPhil_2_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv2", TextBox_MPhil_2_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub2", TextBox_MPhil_2_Subjects.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexuni", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexuni", TextBox_AnyOther_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexyr", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexyr", TextBox_AnyOther_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexdiv", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexdiv", TextBox_AnyOther_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexsub", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexsub", TextBox_AnyOther_Subjects.Text);
                    }
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:" + ex1.ToString());
            }
            TextBoxD2.Text = DropDownListDepartment.Text;
            if (IsPostBack)
            {
                Response.Write("Successfully Saved !!!");
            }
        }

        protected void Next1_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.ONE);
            populatefields_Research_Details();
        }



        protected void Update_Basic_Edu_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                try
                {
                    SqlConnection con = new SqlConnection(CS);
                    con.Open();
                    string updateQuery = "update [Basic_Details] set Delhi_Address=@deladd,Delhi_Pincode=@delpincode,Delhi_Telephone=@deltelno,Delhi_MobileNo=@delmobno,Per_Address=@peradd,Per_Pincode=@perpincode,Per_Telephone=@pertelno,Per_MobileNo=@permobno,Fathers_Occupation=@fathersocc,Mothers_Occupation=@mothersocc,Other_Course=@othercourse,Enrollment_No=@enrollno,Department=@department where usrID='"+Label_UserID.Text+"'";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@deladd", TextBox_Address_Delhi.Text);
                    cmd.Parameters.AddWithValue("@delpincode", TextBox_Pincode_Delhi.Text);
                    cmd.Parameters.AddWithValue("@deltelno", TextBox_Telephone_Delhi.Text);
                    cmd.Parameters.AddWithValue("@delmobno", TextBox_MobileNo.Text);
                    cmd.Parameters.AddWithValue("@peradd", TextBox_Per_Add.Text);
                    cmd.Parameters.AddWithValue("@perpincode", TextBox_Per_Pincode.Text);
                    cmd.Parameters.AddWithValue("@pertelno", TextBox_Per_Telephone.Text);
                    cmd.Parameters.AddWithValue("@permobno", TextBox_Per_MobileNo.Text);
                    if (string.IsNullOrWhiteSpace(TextBox_fathersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@fathersocc", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fathersocc", TextBox_fathersocc.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_mothersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@mothersocc", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@mothersocc", TextBox_mothersocc.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_otheruni.Text))
                    {
                        cmd.Parameters.AddWithValue("@othercourse", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@othercourse", TextBox_otheruni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_mothersocc.Text))
                    {
                        cmd.Parameters.AddWithValue("@enrollno", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@enrollno", TextBox_EnrollNo.Text);
                    }
                    cmd.Parameters.AddWithValue("@department", DropDownListDepartment.SelectedItem.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string updateQuery1 = "update [Educational_Details] set Grad_Course=@gradcourse,Grad_University=@graduni,Grad_Year=@gradyear,Grad_Division=@graddiv,Grad_Subjects=@gradsub,PGrad_Course=@pgradcourse,PGrad_University=@pgraduni,PGrad_Year=@pgradyear,PGrad_Division=@pgraddiv,PGrad_Subjects=@pgradsub,MPhil_I_University=@mphiluni1,MPhil_I_Year=@mphilyr1,MPhil_I_Division=@mphildiv1,MPhil_I_Subjects=@mphilsub1,MPhil_II_University=@mphiluni2,MPhil_II_Year=@mphilyr2,MPhil_II_Division=@mphildiv2,MPhil_II_Subjects=@mphilsub2,Any_Other_Exam_Uni=@anyotherexuni,Any_Other_Exam_Year=@anyotherexyr,Any_Other_Exam_Division=@anyotherexdiv,Any_Other_Exam_Subjects=@anyotherexsub where UsrID='"+Label_UserID.Text+"'";
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(updateQuery1, con);
                    cmd1.Parameters.AddWithValue("@gradcourse", DropDownList_Grad_Course.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@graduni", TextBox_Grad_Uni.Text);
                    cmd1.Parameters.AddWithValue("@gradyear", TextBox_Grad_Year.Text);
                    cmd1.Parameters.AddWithValue("@graddiv", TextBox_Grad_Div.Text);
                    cmd1.Parameters.AddWithValue("@gradsub", TextBox_Grad_Subjects.Text);
                    cmd1.Parameters.AddWithValue("@pgradcourse", DropDownList_PGrad_Course.SelectedItem.Text);
                    cmd1.Parameters.AddWithValue("@pgraduni", TextBox_PGrad_Uni.Text);
                    cmd1.Parameters.AddWithValue("@pgradyear", TextBox_PGrad_Year.Text);
                    cmd1.Parameters.AddWithValue("@pgraddiv", TextBox_PGrad_Div.Text);
                    cmd1.Parameters.AddWithValue("@pgradsub", TextBox_PGrad_Subjects.Text);
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni1", TextBox_MPhil_1_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr1", TextBox_MPhil_1_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv1", TextBox_MPhil_1_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_1_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub1", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub1", TextBox_MPhil_1_Subjects.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphiluni2", TextBox_MPhil_2_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilyr2", TextBox_MPhil_2_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphildiv2", TextBox_MPhil_2_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_MPhil_2_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub2", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@mphilsub2", TextBox_MPhil_2_Subjects.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Uni.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexuni", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexuni", TextBox_AnyOther_Uni.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Year.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexyr", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexyr", TextBox_AnyOther_Year.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Div.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexdiv", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexdiv", TextBox_AnyOther_Div.Text);
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_AnyOther_Subjects.Text))
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexsub", (object)DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@anyotherexsub", TextBox_AnyOther_Subjects.Text);
                    }
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex1)
                {
                    Response.Write("ERROR:" + ex1.ToString());
                }
                SetSelectedTab(TabIndex.ONE);
                TextBoxD2.Text = DropDownListDepartment.Text;
                populatefields_Research_Details();
            } 
        }


        private void populatefields_Research_Details()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string checkuser_Research = "select count(*) from Research_Details where UsrID='" + Label_UserID.Text + "'";
                SqlCommand checkuser_Research_cmd = new SqlCommand(checkuser_Research, con);
                Int32 result = (Int32)checkuser_Research_cmd.ExecuteScalar();
                con.Close();
                if (result == 1)
                {
                    con.Open();
                    SqlDataReader userdata_reader = null;
                    SqlCommand userdata_reader_cmd = new SqlCommand("select * from Research_Details where UsrID='" + Label_UserID.Text + "'", con);
                    userdata_reader = userdata_reader_cmd.ExecuteReader();
                    while (userdata_reader.Read())
                    {
                        TextBox_Fellowship.Text = (userdata_reader.GetValue(1).ToString());
                        TextBox_Languages0.Text = (userdata_reader.GetValue(2).ToString());
                        TextBox_Research_Exp.Text = (userdata_reader.GetValue(3).ToString());
                        TextBox_Research_Topic.Text = (userdata_reader.GetValue(4).ToString());
                    //    RadioButtonList_Currently_Emp.SelectedItem.Text = (userdata_reader.GetValue(5).ToString());
                        TextBox_Name_Insti.Text = (userdata_reader.GetValue(6).ToString());
                        TextBox_Designation.Text = (userdata_reader.GetValue(7).ToString());
                        TextBox_From_Date.Text = (userdata_reader.GetValue(8).ToString());
                        TextBox_To_Date.Text = (userdata_reader.GetValue(9).ToString());
                     //   RadioButtonList_Type_Emp.SelectedItem.Text = (userdata_reader.GetValue(10).ToString());
                        TextBox_Brief_Details.Text = (userdata_reader.GetValue(11).ToString());
                        TextBox_Office_TelNo.Text = (userdata_reader.GetValue(12).ToString());
                    }
                    con.Close();
                }
            }
            catch(Exception ex1)
            {
                Response.Write("ERROR " + ex1.ToString());
            }
        }

        protected void Previous_Basic_Edu_Click(object sender,EventArgs e)
        {
            SetSelectedTab(TabIndex.DEFAULT);
        }


        protected void Save2_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string insertQuery="insert into [Research_Details] values(@usrid,@fellowship,@lang,@researchexp,@titleresearch,@currapplied,@nameofinsti,@designation,@period_of_emp_from,@period_of_emp_to,@type_of_emp,@briefdetails,@officetelno)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@usrid",Label_UserID.Text);
                cmd.Parameters.AddWithValue("@fellowship", TextBox_Fellowship.Text);
                cmd.Parameters.AddWithValue("@lang", TextBox_Languages0.Text);
                if (string.IsNullOrWhiteSpace(TextBox_Research_Exp.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@researchexp", TextBox_Research_Exp.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Research_Topic.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@titleresearch", TextBox_Research_Topic.Text);
                }
                if (string.IsNullOrWhiteSpace(RadioButtonList_Currently_Emp.SelectedItem.Text))
                {
                    cmd.Parameters.AddWithValue("@currapplied", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@currapplied", RadioButtonList_Currently_Emp.SelectedItem.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Name_Insti.Text))
                {
                    cmd.Parameters.AddWithValue("@nameofinsti", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nameofinsti", TextBox_Name_Insti.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Designation.Text))
                {
                    cmd.Parameters.AddWithValue("@designation", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@designation", TextBox_Designation.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_From_Date.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", TextBox_From_Date.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_To_Date.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", TextBox_To_Date.Text);
                }
                if (string.IsNullOrWhiteSpace(RadioButtonList_Type_Emp.SelectedItem.Text))
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", RadioButtonList_Type_Emp.SelectedItem.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Brief_Details.Text))
                {
                    cmd.Parameters.AddWithValue("@briefdetails", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@briefdetails", TextBox_Brief_Details.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Office_TelNo.Text))
                {
                    cmd.Parameters.AddWithValue("@officetelno", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@officetelno", TextBox_Office_TelNo.Text);
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:" + ex1.ToString());
            }
        }

       


        protected void Update_Research_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string insertQuery = "update [Research_Details] set Fellowship_Scholarship=@fellowship,Languages=@lang,Research_Experience=@researchexp,Title_of_Research=@titleresearch,Currently_Applied=@currapplied,Name_Instituition=@nameinsti,Designation=@designation,Period_of_Employment_From=@period_of_emp_from,Period_of_Employment_To=@period_of_emp_to,Type_of_Employment=@type_of_emp,Brief_Details=@briefdetails,Office_Telno=@officetelno where UsrID='"+Label_UserID.Text+"'";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@fellowship", TextBox_Fellowship.Text);
                cmd.Parameters.AddWithValue("@lang", TextBox_Languages0.Text);
                if (string.IsNullOrWhiteSpace(TextBox_Research_Exp.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@researchexp", TextBox_Research_Exp.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Research_Topic.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@titleresearch", TextBox_Research_Topic.Text);
                }
                cmd.Parameters.AddWithValue("@currapplied", RadioButtonList_Currently_Emp.SelectedItem.Text);
                if (string.IsNullOrWhiteSpace(TextBox_Name_Insti.Text))
                {
                    cmd.Parameters.AddWithValue("@nameinsti", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nameinsti", TextBox_Name_Insti.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Designation.Text))
                {
                    cmd.Parameters.AddWithValue("@designation", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@designation", TextBox_Designation.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_From_Date.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", TextBox_From_Date.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_To_Date.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", TextBox_To_Date.Text);
                }
                if (string.IsNullOrWhiteSpace(RadioButtonList_Type_Emp.SelectedItem.Text))
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", RadioButtonList_Type_Emp.SelectedItem.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Brief_Details.Text))
                {
                    cmd.Parameters.AddWithValue("@briefdetails", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@briefdetails", TextBox_Brief_Details.Text);
                }
                if (string.IsNullOrWhiteSpace(TextBox_Office_TelNo.Text))
                {
                    cmd.Parameters.AddWithValue("@officetelno", (object)DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@officetelno", TextBox_Office_TelNo.Text);
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:" + ex1.ToString());
            }
        }

        protected void Next2_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.TWO);
            bool folderExists = Directory.Exists(Server.MapPath("~/Uploads/"+Label_UserID.Text));
            if (!folderExists)
                Directory.CreateDirectory(Server.MapPath("~/Uploads/"+Label_UserID.Text));

            /*string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
              SqlConnection con = new SqlConnection(CS);
              string checkuser = "select count(*) from [Upload_Doc] where UsrID='" + Label_UserID.Text + "'";
              SqlCommand cmd = new SqlCommand(checkuser, con);
              con.Open();
              Int32 result = (Int32)cmd.ExecuteScalar();
              con.Close();
              if (result == 0)
              {
                  string insertuser = "insert into [Upload_Doc] (UsrID) values('" + Label_UserID.Text + "')";
                  SqlCommand cmd1 = new SqlCommand(insertuser, con);
                  con.Open();
                  cmd1.ExecuteNonQuery();
                  con.Close();
              }
              else
              {

              }*/
        }

        protected void Previous_Research_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.ONE);
            populatefields_Research_Details();

        }

        protected void Next3_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.THREE);
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string checkuser = "select count(*) from [Upload_Documents] where UsrID='" + Label_UserID.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuser, con);
            con.Open();
            Int32 result = (Int32)cmd.ExecuteScalar();
            con.Close();
            if (result == 0)
            {
                //string insertQuery = "insert into [Upload_Doc] values(@usrid,@xiicertifile,@xiicertimime,@xiicertibindata,@xiicertidatetime,@xcertifile,@xcertimime,@xcertibindata,@xcertidatetime,@xiimarksheetfile,@xiimarksheetmime,@xiimarksheetbindata,@xiimarksheetdatetime,@xmarksheetfile,@xmarksheetmime,@xmarksheetbindata,@xmarksheetdatetime,@gradmarkfile,@gradmarkmime,@gradmarkbindata,@gradmarkdatetime,@pgradmarkfile,@pgradmarkmime,@pgradmarkbindata,@pgradmarkdatetime,@gradcertifile,@gradcertimime,@gradcertibindata,@gradcertidatetime,@pgradcertifile,@pgradcertimime,@pgradcertibindata,@pgradcertidatetime,@dochodfile,@dochodmime,@dochodbindata,@dochoddatetime,@signfile,@signmime,@signbindata,@signdatetime,@photofile,@photomime,@photobindata,@photodatetime)";
                string insertQuery = "insert into [Upload_Documents] values(@usrid,@xiicertifile,@xiicertidatetime,@xcertifile,@xcertidatetime,@xiimarksheetfile,xiimarksheetdatetime,@xmarksheetfile,@xmarksheetdatetime,@gradmarkfile,@gradmarkdatetime,@pgradmarkfile,@pgradmarkdatetime,@gradcertifile,@gradcertidatetime,@pgradcertifile,@pgradcertidatetime,@dochodfile,@dochoddatetime,@signfile,@signdatetime,@photofile,@photodatetime)";
                SqlCommand cmd1 = new SqlCommand(insertQuery, con);
                cmd1.Parameters.AddWithValue("@usrid", Label_UserID.Text);
                
                if (FileUpload1.PostedFile == null || string.IsNullOrEmpty(FileUpload1.PostedFile.FileName) || FileUpload1.PostedFile.InputStream == null)
                {
                    Label1.Text = "Error - Unable to upload XII Certificate. Please Try again.";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label1.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload1.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label1.Text = "Maximum file size 25KB exceeded.";
                            Label1.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload1.SaveAs(Server.MapPath("~/Uploads/"+ Label_UserID.Text + "/xii_certi_" + FileUpload1.FileName));
                            cmd1.Parameters.AddWithValue("@xiicertifile", "~/Uploads/" + Label_UserID.Text + "/xii_certi_" + FileUpload1.FileName);
                            //cmd1.Parameters.AddWithValue("xiicertimime", FileUpload1.PostedFile.ContentType);
                            //byte[] imagebytes1 = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
                            //FileUpload1.PostedFile.InputStream.Read(imagebytes1, 0, imagebytes1.Length);
                            //cmd1.Parameters.AddWithValue("@xiicertibindata", imagebytes1);
                            Session["ImageBytes1"] = FileUpload1.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@xiicertidatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload2.PostedFile == null || string.IsNullOrEmpty(FileUpload2.PostedFile.FileName) || FileUpload2.PostedFile.InputStream == null)
                {
                    Label2.Text = "Error - Unable to upload X Certificate. Please Try again.";
                    Label2.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload2.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label2.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label2.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload2.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label2.Text = "Maximum file size 25KB exceeded.";
                            Label2.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload2.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/x_certi_" + FileUpload2.FileName));
                            cmd1.Parameters.AddWithValue("@xcertifile", "~/Uploads/" + Label_UserID.Text + "/x_certi_" + FileUpload2.FileName);
                            //cmd1.Parameters.AddWithValue("xcertimime", FileUpload2.PostedFile.ContentType);
                            //byte[] imagebytes2 = new byte[FileUpload2.PostedFile.InputStream.Length + 1];
                            //FileUpload2.PostedFile.InputStream.Read(imagebytes2, 0, imagebytes2.Length);
                            //cmd1.Parameters.AddWithValue("@xcertibindata", imagebytes2);
                            Session["ImageBytes2"] = FileUpload2.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@xcertidatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload3.PostedFile == null || string.IsNullOrEmpty(FileUpload3.PostedFile.FileName) || FileUpload3.PostedFile.InputStream == null)
                {
                    Label3.Text = "Error - Unable to upload XII Marksheet. Please Try again.";
                    Label3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload3.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label3.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label3.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload3.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label3.Text = "Maximum file size 25KB exceeded.";
                            Label3.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload3.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/xii_marksheet_" + FileUpload3.FileName));
                            cmd1.Parameters.AddWithValue("@xiimarksheetfile", "~/Uploads/" + Label_UserID.Text + "/xii_marksheet_" + FileUpload3.FileName);
                            /*cmd1.Parameters.AddWithValue("@xiimarksheetmime", FileUpload3.PostedFile.ContentType);
                            byte[] imagebytes3 = new byte[FileUpload3.PostedFile.InputStream.Length + 1];
                            FileUpload3.PostedFile.InputStream.Read(imagebytes3, 0, imagebytes3.Length);
                            cmd1.Parameters.AddWithValue("@xiimarksheetbindata", imagebytes3);*/
                            Session["ImageBytes3"] = FileUpload3.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@xiimarksheetdatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload4.PostedFile == null || string.IsNullOrEmpty(FileUpload4.PostedFile.FileName) || FileUpload4.PostedFile.InputStream == null)
                {
                    Label4.Text = "Error - Unable to upload X Marksheet. Please Try again.";
                    Label4.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload4.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label4.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label4.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload4.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label4.Text = "Maximum file size 25KB exceeded.";
                            Label4.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload4.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/x_marksheet_" + FileUpload4.FileName));
                            cmd1.Parameters.AddWithValue("@xmarksheetfile", "~/Uploads/" + Label_UserID.Text + "/x_marksheet_" + FileUpload4.FileName);
                            /*cmd1.Parameters.AddWithValue("@xmarksheetmime", FileUpload4.PostedFile.ContentType);
                            byte[] imagebytes4 = new byte[FileUpload4.PostedFile.InputStream.Length + 1];
                            FileUpload4.PostedFile.InputStream.Read(imagebytes4, 0, imagebytes4.Length);
                            cmd1.Parameters.AddWithValue("@xmarksheetbindata", imagebytes4);*/
                            Session["ImageBytes4"] = FileUpload4.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@xmarksheetdatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload5.PostedFile == null || string.IsNullOrEmpty(FileUpload5.PostedFile.FileName) || FileUpload5.PostedFile.InputStream == null)
                {
                    Label5.Text = "Error - Unable to upload Graduation Marksheet. Please Try again.";
                    Label5.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload5.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label5.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label5.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload5.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label5.Text = "Maximum file size 25KB exceeded.";
                            Label5.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload5.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/grad_marksheet_" + FileUpload5.FileName));
                            cmd1.Parameters.AddWithValue("@gradmarkfile", "~/Uploads/" + Label_UserID.Text + "/grad_marksheet_" + FileUpload5.FileName);
                            /*cmd1.Parameters.AddWithValue("@gradmarkmime", FileUpload5.PostedFile.ContentType);
                            byte[] imagebytes5 = new byte[FileUpload5.PostedFile.InputStream.Length + 1];
                            FileUpload5.PostedFile.InputStream.Read(imagebytes5, 0, imagebytes5.Length);
                            cmd1.Parameters.AddWithValue("@gradmarkbindata", imagebytes5);*/
                            Session["ImageBytes5"] = FileUpload5.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@gradmarkdatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload6.PostedFile == null || string.IsNullOrEmpty(FileUpload6.PostedFile.FileName) || FileUpload6.PostedFile.InputStream == null)
                {
                    Label6.Text = "Error - Unable to upload Post Graduation Marksheet. Please Try again.";
                    Label6.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload6.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label6.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label6.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload6.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label6.Text = "Maximum file size 25KB exceeded.";
                            Label6.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload6.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/pgrad_marksheet_" + FileUpload6.FileName));
                            cmd1.Parameters.AddWithValue("@pgradmarkfile", "~/Uploads/" + Label_UserID.Text + "/pgrad_marksheet_" + FileUpload6.FileName);
                            /*cmd1.Parameters.AddWithValue("@pgradmarkmime", FileUpload6.PostedFile.ContentType);
                            byte[] imagebytes6 = new byte[FileUpload6.PostedFile.InputStream.Length + 1];
                            FileUpload6.PostedFile.InputStream.Read(imagebytes6, 0, imagebytes6.Length);
                            cmd1.Parameters.AddWithValue("@pgradmarkbindata", imagebytes6);*/
                            Session["ImageBytes6"] = FileUpload6.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@pgradmarkdatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload7.PostedFile == null || string.IsNullOrEmpty(FileUpload7.PostedFile.FileName) || FileUpload7.PostedFile.InputStream == null)
                {
                    Label7.Text = "Error - Unable to upload Graduation Certificate. Please Try again.";
                    Label7.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload7.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label7.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label7.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload7.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label7.Text = "Maximum file size 25KB exceeded.";
                            Label7.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload7.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/grad_certi_" + FileUpload7.FileName));
                            cmd1.Parameters.AddWithValue("@gradcertifile", "~/Uploads/" + Label_UserID.Text + "/grad_certi_" + FileUpload7.FileName);
                            /*cmd1.Parameters.AddWithValue("@gradcertimime", FileUpload7.PostedFile.ContentType);
                            byte[] imagebytes7 = new byte[FileUpload7.PostedFile.InputStream.Length + 1];
                            FileUpload7.PostedFile.InputStream.Read(imagebytes7, 0, imagebytes7.Length);
                            cmd1.Parameters.AddWithValue("@gradcertibindata", imagebytes7);*/
                            Session["ImageBytes7"] = FileUpload7.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@gradcertidatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload8.PostedFile == null || string.IsNullOrEmpty(FileUpload8.PostedFile.FileName) || FileUpload8.PostedFile.InputStream == null)
                {
                    Label8.Text = "Error - Unable to upload Post Graduation Certificate. Please Try again.";
                    Label8.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload8.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label8.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label8.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload8.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label8.Text = "Maximum file size 25KB exceeded.";
                            Label8.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload8.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/pgrad_certi_" + FileUpload8.FileName));
                            cmd1.Parameters.AddWithValue("@pgradcertifile", "~/Uploads/" + Label_UserID.Text + "/pgrad_certi_" + FileUpload8.FileName);
                            /*cmd1.Parameters.AddWithValue("@pgradcertimime", FileUpload8.PostedFile.ContentType);
                            byte[] imagebytes8 = new byte[FileUpload8.PostedFile.InputStream.Length + 1];
                            FileUpload8.PostedFile.InputStream.Read(imagebytes8, 0, imagebytes8.Length);
                            cmd1.Parameters.AddWithValue("@pgradcertibindata", imagebytes8);*/
                            Session["ImageBytes8"] = FileUpload8.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@pgradcertidatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload9.PostedFile == null || string.IsNullOrEmpty(FileUpload9.PostedFile.FileName) || FileUpload9.PostedFile.InputStream == null)
                {
                    //Label9.Text = "Error - Unable to upload Post Graduation Certificate. Please Try again.";
                    //Label9.ForeColor = System.Drawing.Color.Red;
                    cmd1.Parameters.AddWithValue("@pgradcertifile", (object)DBNull.Value);
                    //cmd1.Parameters.AddWithValue("@pgradcertimime", (object)DBNull.Value);
                    //cmd1.Parameters.AddWithValue("@pgradcertibindata", (object)DBNull.Value);
                    cmd1.Parameters.AddWithValue("@pgradcertidatetime", (object)DBNull.Value);
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload9.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label9.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label9.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload9.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label9.Text = "Maximum file size 25KB exceeded.";
                            Label9.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload9.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/doc_hod_" + FileUpload9.FileName));
                            cmd1.Parameters.AddWithValue("@dochodfile", "~/Uploads/" + Label_UserID.Text + "/doc_hod_" + FileUpload8.FileName);
                            /*cmd1.Parameters.AddWithValue("@dochodmime", FileUpload8.PostedFile.ContentType);
                            byte[] imagebytes9 = new byte[FileUpload9.PostedFile.InputStream.Length + 1];
                            FileUpload9.PostedFile.InputStream.Read(imagebytes9, 0, imagebytes9.Length);
                            cmd1.Parameters.AddWithValue("@dochodbindata", imagebytes9);*/
                            Session["ImageBytes9"] = FileUpload9.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@dochoddatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload10.PostedFile == null || string.IsNullOrEmpty(FileUpload10.PostedFile.FileName) || FileUpload10.PostedFile.InputStream == null)
                {
                    Label10.Text = "Error - Unable to upload Signature. Please Try again.";
                    Label10.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload10.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label10.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label10.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload10.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label10.Text = "Maximum file size 25KB exceeded.";
                            Label10.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload10.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/sign_" + FileUpload10.FileName));
                            cmd1.Parameters.AddWithValue("@signfile", "~/Uploads/" + Label_UserID.Text + "/sign_" + FileUpload10.FileName);
                            /*cmd1.Parameters.AddWithValue("@signmime", FileUpload10.PostedFile.ContentType);
                            byte[] imagebytes10 = new byte[FileUpload10.PostedFile.InputStream.Length + 1];
                            FileUpload10.PostedFile.InputStream.Read(imagebytes10, 0, imagebytes10.Length);
                            cmd1.Parameters.AddWithValue("@signbindata", imagebytes10);*/
                            Session["ImageBytes10"] = FileUpload10.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@signdatetime", DateTime.Now);
                        }
                    }
                }

                if (FileUpload11.PostedFile == null || string.IsNullOrEmpty(FileUpload11.PostedFile.FileName) || FileUpload11.PostedFile.InputStream == null)
                {
                    Label11.Text = "Error - Unable to upload Photograph. Please Try again.";
                    Label11.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload11.FileName);
                    if (fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".pdf")
                    {
                        Label11.Text = "Only files with .jpeg or .jpg or .pdf extension  are allowed";
                        Label11.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        int fileSize = FileUpload11.PostedFile.ContentLength;
                        if (fileSize > 25600)
                        {
                            Label11.Text = "Maximum file size 25KB exceeded.";
                            Label11.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            FileUpload11.SaveAs(Server.MapPath("~/Uploads/" + Label_UserID.Text + "/photo_" + FileUpload11.FileName));
                            cmd1.Parameters.AddWithValue("@photofile", "~/Uploads/" + Label_UserID.Text + "/photo_" + FileUpload11.FileName);
                            /*cmd1.Parameters.AddWithValue("@photomime", FileUpload8.PostedFile.ContentType);
                            byte[] imagebytes11 = new byte[FileUpload11.PostedFile.InputStream.Length + 1];
                            FileUpload11.PostedFile.InputStream.Read(imagebytes11, 0, imagebytes11.Length);
                            cmd1.Parameters.AddWithValue("@photobindata", imagebytes11);*/
                            Session["ImageBytes11"] = FileUpload11.FileBytes;
                            Image1.ImageUrl = "~/Handler.ashx";
                            cmd1.Parameters.AddWithValue("@photodatetime", DateTime.Now);
                        }
                    }
                }
                con.Open();
                cmd1.ExecuteNonQuery();
                Response.Write("Uploaded Successfully");
                con.Close();
            }
    
        }

        protected void Previous3_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.TWO);
            
        }

        protected void Next4_Click(object sender, EventArgs e)
        {

        }

        protected void Button_XIICerti_Upload_Click(object sender, EventArgs e)
        {
            if (FileUploadxii_certi.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUploadxii_certi.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Lb1.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Lb1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUploadxii_certi.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Lb1.Text = "Maximum file size 256KB exceeded.";
                        Lb1.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUploadxii_certi.SaveAs(Server.MapPath("~/Uploads/" + FileUploadxii_certi.FileName));
                     Session["ImageBytes"]= FileUploadxii_certi.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Lb1.Text = "File Uploaded";
                    Lb1.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Lb1.Text = "Please Select a valid file to upload.";
                Lb1.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button2_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload2.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label2.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label2.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload2.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label2.Text = "Maximum file size 256KB exceeded.";
                        Label2.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload2.SaveAs(Server.MapPath("~/Uploads/" + FileUpload2.FileName));
                    Session["ImageBytes"] = FileUpload2.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label2.Text = "File Uploaded";
                    Label2.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label2.Text = "Please Select a valid file to upload.";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button3_Click(object sender, EventArgs e)
        {
            if (FileUpload3.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload3.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label3.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload4.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label3.Text = "Maximum file size 256KB exceeded.";
                        Label3.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload3.SaveAs(Server.MapPath("~/Uploads/" + FileUpload3.FileName));
                    Session["ImageBytes"] = FileUpload3.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label3.Text = "File Uploaded";
                    Label3.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label3.Text = "Please Select a valid file to upload.";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button4_Click(object sender, EventArgs e)
        {
            if (FileUpload4.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload4.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label4.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label4.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload4.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label4.Text = "Maximum file size 256KB exceeded.";
                        Label4.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload4.SaveAs(Server.MapPath("~/Uploads/" + FileUpload4.FileName));
                    Session["ImageBytes"] = FileUpload4.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label4.Text = "File Uploaded";
                    Label4.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label4.Text = "Please Select a valid file to upload.";
                Label4.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button5_Click(object sender, EventArgs e)
        {
            if (FileUpload5.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload5.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label5.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label5.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload5.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label5.Text = "Maximum file size 256KB exceeded.";
                        Label5.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload5.SaveAs(Server.MapPath("~/Uploads/" + FileUpload5.FileName));
                    Session["ImageBytes"] = FileUpload5.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label5.Text = "File Uploaded";
                    Label5.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label5.Text = "Please Select a valid file to upload.";
                Label5.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button6_Click(object sender, EventArgs e)
        {
            if (FileUpload6.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload6.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label6.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label6.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload6.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label6.Text = "Maximum file size 256KB exceeded.";
                        Label6.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload6.SaveAs(Server.MapPath("~/Uploads/" + FileUpload6.FileName));
                    Session["ImageBytes"] = FileUpload6.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label6.Text = "File Uploaded";
                    Label6.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label6.Text = "Please Select a valid file to upload.";
                Label6.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button7_Click(object sender, EventArgs e)
        {
            if (FileUpload7.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload7.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label7.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label7.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload7.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label7.Text = "Maximum file size 256KB exceeded.";
                        Label7.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload7.SaveAs(Server.MapPath("~/Uploads/" + FileUpload7.FileName));
                    Session["ImageBytes"] = FileUpload7.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label7.Text = "File Uploaded";
                    Label7.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label7.Text = "Please Select a valid file to upload.";
                Label7.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button8_Click(object sender, EventArgs e)
        {
            if (FileUpload8.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload8.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label8.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label8.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload8.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label8.Text = "Maximum file size 256KB exceeded.";
                        Label8.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload8.SaveAs(Server.MapPath("~/Uploads/" + FileUpload9.FileName));
                    Session["ImageBytes"] = FileUpload8.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label8.Text = "File Uploaded";
                    Label8.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label8.Text = "Please Select a valid file to upload.";
                Label8.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button9_Click(object sender, EventArgs e)
        {
            if (FileUpload9.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload9.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label9.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label9.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload9.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label9.Text = "Maximum file size 256KB exceeded.";
                        Label9.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload9.SaveAs(Server.MapPath("~/Uploads/" + FileUpload9.FileName));
                    Session["ImageBytes"] = FileUpload9.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label9.Text = "File Uploaded";
                    Label9.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label9.Text = "Please Select a valid file to upload.";
                Label9.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button10_Click(object sender, EventArgs e)
        {
            if (FileUpload10.HasFile)
            {
               
                string fileExtension = System.IO.Path.GetExtension(FileUpload10.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label10.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label10.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload10.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label10.Text = "Maximum file size 256KB exceeded.";
                        Label10.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload10.SaveAs(Server.MapPath("~/Uploads/" + FileUpload10.FileName));
                    Session["ImageBytes"] = FileUpload10.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label10.Text = "File Uploaded";
                    Label10.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label10.Text = "Please Select a valid file to upload.";
                Label10.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void button_download_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/octect-stream";
            Response.AppendHeader("content-disposition","attachment;filename=admission_form.docx;");
            Response.TransmitFile(Server.MapPath("~/Files/admission_form.docx"));
            Response.End();
        }
        protected void upload_button11_Click(object sender, EventArgs e)
        {
            if (FileUpload11.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload11.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label11.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label11.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload11.PostedFile.ContentLength;
                    if (fileSize > 262144)
                    {
                        Label11.Text = "Maximum file size 256KB exceeded.";
                        Label11.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload11.SaveAs(Server.MapPath("~/Uploads/" + FileUpload11.FileName));
                    Session["ImageBytes"] = FileUpload11.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label11.Text = "File Uploaded";
                    Label11.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label11.Text = "Please Select a valid file to upload.";
                Label11.ForeColor = System.Drawing.Color.Red;
            }
        }


        protected void Next4_Click1(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.FOUR);
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Write("works");
            Session["UserID"] = Label_UserID.Text;
            Response.Redirect("~/display_form.aspx");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Session["UserID"] = Label_UserID.Text;
            Response.Redirect("~/display_form.aspx");
        }

       
    }
}