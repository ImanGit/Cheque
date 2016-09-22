using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cheque.DataLayer.Context;
using Cheque.DomainClasses.Entities;
using Cheque.ServiceLayer.Contracts;

namespace Cheque.ServiceLayer.EfServices
{
    /// <summary>
    /// </summary>
    public class BankService : IBankService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        public BankService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _bank = unitOfWork.Set<Bank>();
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Bank> _bank;

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IList<Bank> GetList()
        {
            return _bank
                .AsNoTracking()
                .ToList();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IList FillBankLookup()
        {
            return _bank
                .AsNoTracking()
                .Select(s => new {s.Id, s.CustomeCode, s.Title})
                .ToList();
        }

        #endregion
    }
}