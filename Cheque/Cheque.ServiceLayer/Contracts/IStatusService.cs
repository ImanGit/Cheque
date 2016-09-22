using System.Collections;
using Cheque.ServiceLayer.Contracts.Common;

namespace Cheque.ServiceLayer.Contracts
{
    /// <summary>
    /// </summary>
    public interface IStatusService : IBaseService
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        IList FillStatusLookup();
    }
}