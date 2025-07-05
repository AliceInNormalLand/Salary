using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public class ConnectSQL
    {
        private static ConnectSQL instance;
        public static ConnectSQL Instance
        {
            get { if (instance == null) instance = new ConnectSQL(); return ConnectSQL.instance; }
            private set { ConnectSQL.instance = value; }
        }
        private ConnectSQL() { }
        private string connectString = @"Data Source=ALICEWANG\SQLEXPRESS01;Initial Catalog=HRPayrollDB;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=0;Max Pool Size=500;TrustServerCertificate=True;";

        public SqlConnection getconnect()
        {
            SqlConnection sqlc = new SqlConnection(connectString);
            sqlc.Open();
            return sqlc;
        }
        
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "HRPayrollDB",
                DataSource = @"ALICEWANG\SQLEXPRESS01",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ConnectTimeout = 0,
                MaxPoolSize = 500,
                TrustServerCertificate = true
            };
            return stringBuilder.ConnectionString;
        }
        // trả về một table khi truyền vào câu lệnh select
        public static DataTable table(string sql)
        {
            instance = new ConnectSQL();
            DataTable table = new DataTable();
            table.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, instance.getconnect());
            adapter.Fill(table);
            instance.getconnect().Close();
            return table;
        }

        public static void Execute(string sql, Dictionary<string, object> parameters = null)
        {
            string connString = GetConnectionString();

            using (SqlConnection sqlConnect = new SqlConnection(connString))
            {
                sqlConnect.Open();

                using (SqlCommand cmd = new SqlCommand(sql, sqlConnect))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            string conn_string = GetConnectionString();
            SqlConnection sqlConnect = new SqlConnection(conn_string);
            sqlConnect.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //public DataTable tableChiphi()
        //{
        //    instance = new ConnectSQL();
        //    DataTable table = new DataTable();
        //    table.Clear();
        //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CompanyExpenses", instance.getconnect());
        //    adapter.Fill(table);
        //    instance.getconnect().Close();
        //    return table;
        //}
        //public static bool ExecuteNonQuery(string sql)
        //{
        //    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            SqlCommand cmd = new SqlCommand(sql, connection);
        //            cmd.ExecuteNonQuery();
        //            connection.Close();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }

        //}
    }
}
