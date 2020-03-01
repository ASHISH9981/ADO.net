using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication1;
using System.Data;

namespace DL
{
    public class Class1
    {

        public string GetConnetionString()
        {
            return ConfigurationManager.ConnectionStrings["securedConnection"].ToString();
        }

        public void Execute(Regisparam query)
        {
            using (SqlConnection sqlcon = new SqlConnection())
            {
                sqlcon.ConnectionString = GetConnetionString();
                sqlcon.Open();
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlcon;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "Registration ";
                    cmd.Parameters.AddWithValue("@Name",query.Name);
                    cmd.Parameters.AddWithValue("EmailId", query.EmailId);
                    cmd.Parameters.AddWithValue("@Addresscheck", query.Address);
                    cmd.Parameters.AddWithValue("@PassWordFist", query.PassWordFist);
                    cmd.Parameters.AddWithValue("@PassWordConfirm", query.PassWordConfirm);
                    cmd.Parameters.AddWithValue("@PinCode", query.PinCode);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int ExecuteLogin(LoginParams query)
        {
            int result;
            using (SqlConnection sqlcon = new SqlConnection())
            {
                sqlcon.ConnectionString = GetConnetionString();
                sqlcon.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlcon;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "login";
                    cmd.Parameters.AddWithValue("@Name", query.Name);
                    cmd.Parameters.AddWithValue("@PassWordFist", query.PassWordFist);
                    cmd.Parameters.Add("@result",System.Data.SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                     result = (int)cmd.Parameters["@result"].Value;
                }
            }
            return result;
        }


        ///Datatable
        //public DataTable Executesearch(string query)
        //{
        //    DataTable ob = new DataTable();
        //    using (SqlConnection sqlcon = new SqlConnection())
        //    {
        //        sqlcon.ConnectionString = GetConnetionString();
        //        sqlcon.Open();

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = sqlcon;
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "search";
        //            cmd.Parameters.AddWithValue("@Name", query);
        //            SqlDataAdapter data = new SqlDataAdapter(cmd);

        //            data.Fill(ob);

        //        }
        //    }
        //    return ob;
        //}


        //dataset
        //
        //public DataSet Executesearch(string query)
        //{
        //    DataSet ob = new DataSet();
        //    using (SqlConnection sqlcon = new SqlConnection())
        //    {
        //        sqlcon.ConnectionString = GetConnetionString();
        //        sqlcon.Open();

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = sqlcon;
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "search";
        //            cmd.Parameters.AddWithValue("@Name", query);
        //            SqlDataAdapter data = new SqlDataAdapter(cmd);

        //            data.Fill(ob);

        //        }
        //    }
        //    return ob;
        //}

        //public SqlDataReader Executesearch(string query)
        //{
        //    using (SqlConnection sqlcon = new SqlConnection())
        //    {
        //        sqlcon.ConnectionString = GetConnetionString();
        //        sqlcon.Open();

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = sqlcon;
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "search";
        //            cmd.Parameters.AddWithValue("@Name", query);
        //            SqlDataReader reader = cmd.ExecuteReader();
                    

        //        }
        //    }
        //    return ob;
        //}
    }
}
