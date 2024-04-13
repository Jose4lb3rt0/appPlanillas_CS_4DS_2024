using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace appPlanilla_CS_4DS_2024.db
{
    internal class Db
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public Db(string cnn) {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnn].ConnectionString);
            cmd = new SqlCommand("", cn);
            da = new SqlDataAdapter(cmd);
        }
    }
}
