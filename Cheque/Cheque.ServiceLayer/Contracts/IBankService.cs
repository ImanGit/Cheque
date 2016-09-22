using System.Collections;
using System.Collections.Generic;
using Cheque.DomainClasses.Entities;
using Cheque.ServiceLayer.Contracts.Common;

namespace Cheque.ServiceLayer.Contracts
{
    /// <summary>
    /// </summary>
    public interface IBankService : IBaseService
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        IList<Bank> GetList();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        IList FillBankLookup();
    }
}