using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DL;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // String conString = ConfigurationManager.ConnectionStrings["testConnection"].ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {   Regisparam ab = new Regisparam();
              
        //string constr = GetConnetionString();
        //SqlConnection sqlCon = new SqlConnection(constr);
        //sqlCon.Open();
        ab.Name = TextBox1.Text + TextBox2.Text;
            ab.EmailId = TextBox3.Text;
            ab.Address = TextBox4.Text;
            ab.PinCode = Convert.ToInt32(TextBox5.Text);
            ab.PassWordFist = TextBox6.Text;
            ab.PassWordConfirm = TextBox7.Text;

  
            //var passupdate = string.IsNullOrWhiteSpace(PassWordFist) && string.IsNullOrWhiteSpace(PassWordConfirm) && PassWordFist.Equals(PassWordConfirm) ? PassWordFist:

            //String query = "UPDATE Employee SET EName = '"+empName+"', Salary = "+salary+" WHERE EName = 'Amy' ";
            //String query = "INSERT INTO Testing VALUES('"+Name+"', '"+EmailId+"', '"+Address+"', '"+PassWordFist+"', '"+PassWordConfirm+"', "+PinCode+")";

            Class1 classObj = new Class1();

           // classObj.Execute(ab);
            //classObj.ExecuteLogin(cd);


            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlCon;
            //sqlCommand.CommandText = query;

            //sqlCommand.ExecuteNonQuery();
            //sqlCon.Close();
        }


        private string GetConnetionString()
        {
            return ConfigurationManager.ConnectionStrings["testConnection"].ToString();
        }
    }
}