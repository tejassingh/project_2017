﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

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
            FOUR=4
        }




        protected void Page_Load(object sender, EventArgs e)
        {

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
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Basic_DetailsConnectionString"].ConnectionString);
                conn1.Open();
                string insertQuery = "insert into [Table] (Delhi_Address, Delhi_Pincode, Delhi_Telephone, Delhi_Mobile, Per_Address, Per_Pincode, Per_Telephone, Per_Mobile, Father_Occupation, Mother_Occupation, Other_Course, DU_Enroll) values (@dadd, @dpin, @dtel, @dmob, @padd, @ppin, @ptel, @pmob, @focc, @mocc, @ocourse, @duenroll)";
                SqlCommand com1 = new SqlCommand(insertQuery, conn1);
                com1.Parameters.AddWithValue("@dadd", TextBox_Address_Delhi.Text);
                com1.Parameters.AddWithValue("@dpin", TextBox_Pincode_Delhi.Text);
                com1.Parameters.AddWithValue("@dtel", TextBox_Telephone_Delhi.Text);
                com1.Parameters.AddWithValue("@dmob", TextBox_MobileNo.Text);
                com1.Parameters.AddWithValue("@padd", TextBox_Per_Add.Text);
                com1.Parameters.AddWithValue("@ppin", TextBox_Per_Pincode.Text);
                com1.Parameters.AddWithValue("@ptel", TextBox_Per_Telephone.Text);
                com1.Parameters.AddWithValue("@pmob", TextBox_Per_MobileNo.Text);
                com1.Parameters.AddWithValue("@focc", TextBox25.Text);
                com1.Parameters.AddWithValue("@mocc", TextBox30.Text);
                com1.Parameters.AddWithValue("@ocourse", TextBox3.Text);
                com1.Parameters.AddWithValue("@duenroll", TextBox26.Text);

                com1.ExecuteNonQuery();
               /* Response.Redirect("Basic_Details_Form.aspx");
                Response.Write("SUCCESS!!!"); 
                */
                conn1.Close();
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:" + ex1.ToString());
            }
            SetSelectedTab(TabIndex.ONE);
        }

        protected void Next2_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.TWO);
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

        protected void upload_button_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload2.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload2.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg.Text = "Maximum file size 2MB exceeded.";
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload2.SaveAs(Server.MapPath("~/Uploads/" + FileUpload2.FileName));
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
        protected void upload_button1_Click(object sender, EventArgs e)
        {
            if (FileUpload3.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload3.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg1.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload3.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg1.Text = "Maximum file size 2MB exceeded.";
                        lblmsg1.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload3.SaveAs(Server.MapPath("~/Uploads/" + FileUpload3.FileName));
                    lblmsg1.Text = "File Upload";
                    lblmsg1.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg1.Text = "Please Select a valid file to upload.";
                lblmsg1.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void Upload_button2_Click(object sender, EventArgs e)
        {
            if (FileUpload4.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload4.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg2.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload4.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg2.Text = "Maximum file size 2MB exceeded.";
                        lblmsg2.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload4.SaveAs(Server.MapPath("~/Uploads/" + FileUpload4.FileName));
                    lblmsg2.Text = "File Upload";
                    lblmsg2.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg2.Text = "Please Select a valid file to upload.";
                lblmsg2.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button3_Click(object sender, EventArgs e)
        {
            if (FileUpload5.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload4.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg3.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload5.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg3.Text = "Maximum file size 2MB exceeded.";
                        lblmsg3.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload5.SaveAs(Server.MapPath("~/Uploads/" + FileUpload5.FileName));
                    lblmsg3.Text = "File Upload";
                    lblmsg3.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg3.Text = "Please Select a valid file to upload.";
                lblmsg3.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button4_Click(object sender, EventArgs e)
        {
            if (FileUpload6.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload6.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg4.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg4.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload6.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg4.Text = "Maximum file size 2MB exceeded.";
                        lblmsg4.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload6.SaveAs(Server.MapPath("~/Uploads/" + FileUpload6.FileName));
                    lblmsg4.Text = "File Upload";
                    lblmsg4.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg4.Text = "Please Select a valid file to upload.";
                lblmsg4.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button5_Click(object sender, EventArgs e)
        {
            if (FileUpload7.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload7.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg5.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg5.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload7.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg5.Text = "Maximum file size 2MB exceeded.";
                        lblmsg5.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload7.SaveAs(Server.MapPath("~/Uploads/" + FileUpload7.FileName));
                    lblmsg5.Text = "File Upload";
                    lblmsg5.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg5.Text = "Please Select a valid file to upload.";
                lblmsg5.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button6_Click(object sender, EventArgs e)
        {
            if (FileUpload8.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload8.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg6.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg6.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload8.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg6.Text = "Maximum file size 2MB exceeded.";
                        lblmsg6.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload8.SaveAs(Server.MapPath("~/Uploads/" + FileUpload8.FileName));
                    lblmsg6.Text = "File Upload";
                    lblmsg6.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg6.Text = "Please Select a valid file to upload.";
                lblmsg6.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button7_Click(object sender, EventArgs e)
        {
            if (FileUpload9.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload9.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg7.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg7.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload9.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg7.Text = "Maximum file size 2MB exceeded.";
                        lblmsg7.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload9.SaveAs(Server.MapPath("~/Uploads/" + FileUpload9.FileName));
                    lblmsg7.Text = "File Upload";
                    lblmsg7.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg7.Text = "Please Select a valid file to upload.";
                lblmsg7.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button8_Click(object sender, EventArgs e)
        {
            if (FileUpload10.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload10.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg8.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg8.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload10.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg8.Text = "Maximum file size 2MB exceeded.";
                        lblmsg8.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload9.SaveAs(Server.MapPath("~/Uploads/" + FileUpload10.FileName));
                    lblmsg8.Text = "File Upload";
                    lblmsg8.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg8.Text = "Please Select a valid file to upload.";
                lblmsg8.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void upload_button9_Click(object sender, EventArgs e)
        {
            if (FileUpload9.HasFile)
            {
               
                string fileExtension = System.IO.Path.GetExtension(FileUpload11.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg9.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg9.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload11.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg9.Text = "Maximum file size 2MB exceeded.";
                        lblmsg9.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload11.SaveAs(Server.MapPath("~/Uploads/" + FileUpload11.FileName));
                    lblmsg9.Text = "File Uploaded";
                    lblmsg9.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg9.Text = "Please Select a valid file to upload.";
                lblmsg9.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void button_download_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/octect-stream";
            Response.AppendHeader("content-disposition","attachment;filename=admission_form.docx;");
            Response.TransmitFile(Server.MapPath("~/Files/admission_form.docx"));
            Response.End();
        }
        protected void upload_button10_Click(object sender, EventArgs e)
        {
            if (FileUpload12.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload12.FileName);

                if (fileExtension.ToLower() != ".jpeg" && fileExtension.ToLower() != ".jpg")
                {
                    lblmsg10.Text = "Only files with .jpeg or .jpg extension are allowed";
                    lblmsg10.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload12.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblmsg10.Text = "Maximum file size 2MB exceeded.";
                        lblmsg10.ForeColor = System.Drawing.Color.Red;
                    }
                    FileUpload12.SaveAs(Server.MapPath("~/Uploads/" + FileUpload12.FileName));
                    lblmsg10.Text = "File Upload";
                    lblmsg10.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblmsg10.Text = "Please Select a valid file to upload.";
                lblmsg10.ForeColor = System.Drawing.Color.Red;
            }
        }


   








        protected void Next4_Click1(object sender, EventArgs e)
        {
            Session["mytext"] = TextBox_MobileNo.Text;
            Response.Redirect("~/display_form.aspx");
        }
    }
}