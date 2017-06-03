using System;
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
            
        }

        protected void TextBox37_TextChanged(object sender, EventArgs e)
        {
            
        }





        protected void TextBox37_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void DropDownListDepartment_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox37.Text = DropDownListDepartment.SelectedItem.Text;
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

        protected void TextBox_Address_Delhi_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Basic_DetailsConnectionString"].ConnectionString);
                conn1.Open();
                string insertQuery = "insert into [Table] (Delhi_Address, Delhi_Pincode, Delhi_Telephone, Delhi_Mobile, Per_Address, Per_Pincode, Per_Telephone, Per_Mobile, Father_Occupation, Mother_Occupation, Other_Course, DU_Enroll) values (@dadd, @dpin, @dtel, @dmob, @padd, @ppin, @ptel, @pmob, @focc, @mocc, @ocourse, @duenroll)";
                SqlCommand com1 = new SqlCommand(insertQuery,conn1);
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
                Response.Redirect("Basic_Details_Form.aspx");
                Response.Write("SUCCESS!!!");
                conn1.Close();
            }
            catch (Exception ex1)
            {
                Response.Write("ERROR:"+ ex1.ToString());
            }
        }
    }
}