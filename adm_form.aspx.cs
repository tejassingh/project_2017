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

            if (!IsPostBack)
                TextBox37.Text = "Select Department";

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

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedItem.Text == "YES")
            {
                TextBox31.Enabled = true;
                TextBox32.Enabled = true;
                TextBox33.Enabled = true;
                TextBox34.Enabled = true;
                RadioButtonList3.Enabled = true;
                TextBox35.Enabled = true;
                TextBox36.Enabled = true;

            }
            else if (RadioButtonList2.SelectedItem.Text == "NO")
            {
                TextBox31.Enabled = false;
                TextBox32.Enabled = false;
                TextBox33.Enabled = false;
                TextBox34.Enabled = false;
                RadioButtonList3.Enabled = false;
                TextBox35.Enabled = false;
                TextBox36.Enabled = false;
            }
        }

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
                TextBox3.Enabled = true;
            }
            else if (RadioButtonList1.SelectedItem.Text == "NO")
            {
                TextBox3.Enabled = false;
            }

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

      /*  protected void upload_button_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx")
                {
                    lblmsg.Text = "Only files with .doc or .docx extension are allowed";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg.Text = "Maximum file size 2MB exceeded.";
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                    lblmsg.Text = "File Upload";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg.Text = "Please Select a valid file to upload.";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
*/
        protected void Button4_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.DEFAULT);
        }


        
       

        protected void Next1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string insertQuery = "insert into [Basic_Details] values(@usrid,@deladd,@delpincode,@deltelno,@delmobno,@peradd,@perpincode,@pertelno,@permobno,@fathersocc,@mothersocc,@othercourse,@enrollno)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@deladd", TextBox_Address_Delhi.Text);
                cmd.Parameters.AddWithValue("@delpincode", TextBox_Pincode_Delhi.Text);
                cmd.Parameters.AddWithValue("@deltelno", TextBox_Telephone_Delhi.Text);
                cmd.Parameters.AddWithValue("@delmobno", TextBox_MobileNo.Text);
                cmd.Parameters.AddWithValue("@peradd", TextBox_Per_Add.Text);
                cmd.Parameters.AddWithValue("@perpincode", TextBox_Per_Pincode.Text);
                cmd.Parameters.AddWithValue("@pertelno", TextBox_Per_Telephone.Text);
                cmd.Parameters.AddWithValue("@permobno", TextBox_Per_MobileNo.Text);
                if (!string.IsNullOrWhiteSpace(TextBox25.Text))
                {
                    cmd.Parameters.AddWithValue("@fathersocc", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fathersocc", TextBox25.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox30.Text))
                {
                    cmd.Parameters.AddWithValue("@mothersocc", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@mothersocc", TextBox30.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox3.Text))
                {
                    cmd.Parameters.AddWithValue("@othercourse", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@othercourse", TextBox3.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox30.Text))
                {
                    cmd.Parameters.AddWithValue("@enrollno", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@enrollno", TextBox26.Text);
                }
                cmd.ExecuteNonQuery();
                string insertQuery1 = "insert into [Educational_Details] values(@eduid,@usrid,@gradcourse,@graduni,@gradyear,@graddiv,@gradsub,@pgradcourse,@graduni,@pgradyear,@pgraddiv,@pgradsub,@mphiluni1,@mphilyr1,mphildiv1,@mphilsub1,@mphiluni2,@mpilyr2,@mphildiv2,@mphilsub2,@anyotherexuni,@anyotherexyr,@anyotherexdiv,@anyotherexsub)";
                SqlCommand cmd1 = new SqlCommand(insertQuery1, con);
                //cmd1.Parameters.AddWithValue("@eduid",);
                //cmd1.Parameters.AddWithValue("@usrid",)
                cmd1.Parameters.AddWithValue("@gradcourse", DropDownList1.SelectedItem.Text);
                cmd1.Parameters.AddWithValue("@graduni", TextBox_Grad_Uni.Text);
                cmd1.Parameters.AddWithValue("@gradyear", TextBox_Grad_year.Text);
                cmd1.Parameters.AddWithValue("@graddiv", TextBox_Grad_Div.Text);
                cmd1.Parameters.AddWithValue("@gradsub", TextBox8.Text);
                cmd1.Parameters.AddWithValue("@pgradcourse", DropDownList2.SelectedItem.Text);
                cmd1.Parameters.AddWithValue("@pgraduni", TextBox9.Text);
                cmd1.Parameters.AddWithValue("@pgradyear", TextBox10.Text);
                cmd1.Parameters.AddWithValue("@pgraddiv", TextBox11.Text);
                cmd1.Parameters.AddWithValue("@pgradsub", TextBox12.Text);
                if (!string.IsNullOrWhiteSpace(TextBox13.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphiluni1", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphiluni1", TextBox13.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox14.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphilyr1", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphilyr1", TextBox14.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox15.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphildiv1", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphildiv1", TextBox15.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox16.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphilsub1", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphilsub1", TextBox16.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox17.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphiluni2", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphiluni2", TextBox17.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox18.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphilyr2", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphilyr2", TextBox18.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox19.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphildiv2", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphildiv2", TextBox19.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox20.Text))
                {
                    cmd1.Parameters.AddWithValue("@mphilsub2", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@mphilsub2", TextBox20.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox21.Text))
                {
                    cmd1.Parameters.AddWithValue("@anyotherexuni", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@anyotherexuni", TextBox21.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox22.Text))
                {
                    cmd1.Parameters.AddWithValue("@anyotherexyr", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@anyotherexyr", TextBox22.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox23.Text))
                {
                    cmd1.Parameters.AddWithValue("@anyotherexdiv", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@anyotherexdiv", TextBox23.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox24.Text))
                {
                    cmd1.Parameters.AddWithValue("@anyotherexsub", null);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@anyotherexsub", TextBox24.Text);
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
        }

        protected void Next2_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.TWO);
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                string insertQuery="insert into [Research_Details] values(@researchid,@usrid,@fellowship,@lang,@researchexp,@titleresearch,@currapplied,@nameinsti,@designation,@period_of_emp_from,@period_of_emp_to,@type_of_emp,@briefdetails,@officetelno)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                //cmd.Parameters.AddWithValue("@researchid",);
                //cmd.Parameters.AddWithValue("@usrid",);
                cmd.Parameters.AddWithValue("@fellowship", TextBox27.Text);
                cmd.Parameters.AddWithValue("@lang", TextBox_Languages0.Text);
                if (!string.IsNullOrWhiteSpace(TextBox28.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@researchexp", TextBox28.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox29.Text))
                {
                    cmd.Parameters.AddWithValue("@researchexp", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@titleresearch", TextBox29.Text);
                }
                if (!string.IsNullOrWhiteSpace(RadioButtonList2.SelectedItem.Text))
                {
                    cmd.Parameters.AddWithValue("@currapplied", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@currapplied", RadioButtonList2.SelectedItem.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox31.Text))
                {
                    cmd.Parameters.AddWithValue("@nameinsti", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nameinsti", TextBox31.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox31.Text))
                {
                    cmd.Parameters.AddWithValue("@nameinsti", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nameinsti", TextBox31.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox32.Text))
                {
                    cmd.Parameters.AddWithValue("@designation", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@designation", TextBox32.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox33.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_from", TextBox33.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox34.Text))
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@period_of_emp_to", TextBox34.Text);
                }
                if (!string.IsNullOrWhiteSpace(RadioButtonList3.SelectedItem.Text))
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@type_of_emp", RadioButtonList3.SelectedItem.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox35.Text))
                {
                    cmd.Parameters.AddWithValue("@briefdetails", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@briefdetails", TextBox35.Text);
                }
                if (!string.IsNullOrWhiteSpace(TextBox36.Text))
                {
                    cmd.Parameters.AddWithValue("@officetelno", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@officetelno", TextBox36.Text);
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:" + ex1.ToString());
            }
        }

        protected void test1_Click(object sender, EventArgs e)
        {
            
        }

        private void SetSelectedTab(TabIndex tabIndex)
        {
            Hdnfldtabs.Value = ((int)tabIndex).ToString();
            
        }


        protected void Previous2_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.ONE);

        }

        protected void Next3_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.THREE);
        }

        protected void Previous3_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.TWO);
        }

        protected void Next4_Click(object sender, EventArgs e)
        {

        }

        protected void upload_button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    Label1.Text = "Only files with .jpeg or .jpg extension are allowed";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        Label1.Text = "Maximum file size 2MB exceeded.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                     Session["ImageBytes"]= FileUpload1.FileBytes;
                    Image1.ImageUrl = "~/Handler.ashx";
                    Label1.Text = "File Uploaded";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                Label1.Text = "Please Select a valid file to upload.";
                Label1.ForeColor = System.Drawing.Color.Red;
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
                    if (fileSize > 2097152)
                    {
                        Label2.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label3.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label4.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label5.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label6.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label7.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label8.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label9.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label10.Text = "Maximum file size 2MB exceeded.";
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
                    if (fileSize > 2097152)
                    {
                        Label11.Text = "Maximum file size 2MB exceeded.";
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
            Session["mytext"] = TextBox_MobileNo.Text;
            Response.Redirect("~/display_form.aspx");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Session["mytext"] = TextBox_MobileNo.Text;
            Response.Redirect("~/display_form.aspx");
        }
    }
}