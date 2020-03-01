using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DL.Class1 cls = new DL.Class1();
            //DataSet dtResult = cls.Executesearch(TextBox1.Text);
            //dgvResult.DataSource = dtResult.Tables[0];
            //dgvResult.DataBind();

            using (SqlConnection sqlcon = new SqlConnection())
            {
                sqlcon.ConnectionString = cls.GetConnetionString();
                sqlcon.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlcon;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "search";
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvResult.DataSource = reader;
                    dgvResult.DataBind();

                }
            }
        }
    }
}