using Cheque.ServiceLayer.Contracts.Common;
using Cheque.ServiceLayer.EfServices.Common;
using StructureMap;

namespace Cheque.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class ServiceLayerRegistery : Registry
    {
        /// <summary>
        /// </summary>
        public ServiceLayerRegistery()
        {
            Policies.SetAllProperties(y => { y.OfType<IService>(); });

            Scan(scanner =>
            {
                scanner.Assembly("Cheque.ServiceLayer");
                scanner.WithDefaultConventions();
                scanner.AssemblyContainingType<Service>();
            });
        }
    }
}