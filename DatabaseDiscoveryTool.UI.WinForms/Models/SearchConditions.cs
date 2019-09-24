using System.Data.SqlClient;
using DatabaseDiscoveryTool.UI.WinForms.Helpers;

namespace DatabaseDiscoveryTool.UI.WinForms.Models
{
    public class SearchConditions
    {
        public string Search1 { get; set; }
        public string Search2 { get; set; }

        public string ConnectionString { get; set; }

        public string Database
        {
            get
            {
                var sqlconn = new SqlConnection(ConnectionString);
                return sqlconn.Database;
            }
        }
        
        public bool SearchOnlyInTableNames { get; set; }
        
        public bool SearchOnlyInColumnNames { get; set; }
        public string SearchValue { get; set; }
    }
}