using System.Configuration;

namespace DAL
{
    public static class DbConfigurations
    {
        private const string DB_CONFIG_NAME = "TpFinalConn";

        public static string getDbName()
        {
            return ConfigurationManager.ConnectionStrings["TpFinalConn"].ConnectionString;
        }
    }
}
