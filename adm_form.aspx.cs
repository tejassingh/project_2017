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
            if (CheckBox1.Checked)
            {
                    TextBox_Per_Add.Text = TextBox_Address_Delhi.Text;

            }
            else
            {
                TextBox_Per_Add.Text = "";
            }
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
            TextBox_Department.Text = DropDownListDepartment.SelectedItem.Text;
        }

        protected void TextBox37_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownListDepartment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox_Department.Text = DropDownListDepartment.SelectedItem.Text;
        }
    }
}