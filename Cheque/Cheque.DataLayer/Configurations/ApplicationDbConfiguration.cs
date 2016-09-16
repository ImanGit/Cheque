using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Cheque.DataLayer.Configurations
{
    /// <summary>
    /// </summary>
    public class ApplicationDbConfiguration : DbConfiguration
    {
        /// <summary>
        /// </summary>
        public ApplicationDbConfiguration()
        {
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}