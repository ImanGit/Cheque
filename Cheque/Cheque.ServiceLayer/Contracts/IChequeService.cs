using System;
using System.Collections.Generic;
using Cheque.ServiceLayer.Contracts.Common;
using Cheque.ViewModel.Models;

namespace Cheque.ServiceLayer.Contracts
{
    /// <summary>
    /// </summary>
    public interface IChequeService : IBaseService
    {
        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        void Create(DomainClasses.Entities.Cheque model);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        IEnumerable<ChequeViewModel> GetList();

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DomainClasses.Entities.Cheque GetForEdit(Guid id);
    }
}