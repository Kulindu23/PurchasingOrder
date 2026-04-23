using System.Data.SqlClient;
using System.Data;


namespace Purchasing_Order
{
    class Database
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlDataReader dr;

        public Database()
        {
            con = new SqlConnection("Data Source=DESKTOP-969UD0H;Initial Catalog=KS23;Integrated Security=True;");
        }
        public void OpenConnection()
        {
            con.Open();  
        }
        public void CloseConnection()
        {
            con.Close();
        }
        public DataTable GetData(string a)
        {
            OpenConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
