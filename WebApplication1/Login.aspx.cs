using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginParams cd = new LoginParams();
            cd.Name = TextBox1.Text;
            cd.PassWordFist = TextBox2.Text;

            DL.Class1 obj = new DL.Class1();
           int result= obj.ExecuteLogin(cd);
            if (result==1)
            {
                Response.Redirect("");
            }
        }
    }
}