using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhD
{
    public partial class admission_form : System.Web.UI.Page
    {
        private enum TabIndex
        {
            DEFAULT = 0,
            ONE = 1,
            TWO = 2,
            THREE = 3
            
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
            if (RadioButtonList1.SelectedItem.Text == "YES")
            {
                TextBox3.Enabled = true;
            }
            else if (RadioButtonList1.SelectedItem.Text == "NO")
            {
                TextBox3.Enabled = false;
            }
        }

        protected void upload_button_Click(object sender, EventArgs e)
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            SetSelectedTab(TabIndex.DEFAULT);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

       

        protected void Next1_Click(object sender, EventArgs e)
        {
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
    }
}