using System.Collections;
using Cheque.ServiceLayer.Contracts.Common;

namespace Cheque.ServiceLayer.Contracts
{
    /// <summary>
    /// </summary>
    public interface ICityService : IBaseService
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        IList FillCityLookup();
    }
}