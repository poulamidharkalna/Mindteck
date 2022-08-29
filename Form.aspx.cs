using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Reg_From
{
    public partial class Form : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtName_TextChanged()
        {

        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OFQVSMU;Initial Catalog=Register;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Register]
           ([name]
           ,[address]
           ,[gender]
           ,[phone]
           ,[email]
           ,[username]
           ,[password])
     VALUES
           ('" + txtName.Text + "','" + txtAdd.Text + " ','" + gender + " ','" + txtPhone.Text + "',' " + txtEmail.Text + "','" + txtUser.Text + "','" + txtPass + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('user is register successfully')</script>");
                  


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        protected void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}