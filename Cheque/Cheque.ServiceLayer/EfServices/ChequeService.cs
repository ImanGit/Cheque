using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheque.DataLayer.Context;
using Cheque.ServiceLayer.Contracts;

namespace Cheque.ServiceLayer.EfServices
{
    public class ChequeService:IChequeService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<DomainClasses.Entities.Cheque> _cheque;

        #endregion

        #region Ctor

        public ChequeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _cheque = unitOfWork.Set<DomainClasses.Entities.Cheque>();
        }
        #endregion
        #region Create

        public void Create(DomainClasses.Entities.Cheque model)
        {
            _cheque.Add(model);
            _unitOfWork.SaveAllChanges();
        }
        #endregion

        #region Read
        public IList<DomainClasses.Entities.Cheque> GetList()
        {
            return _cheque
                .AsNoTracking()
                .ToList();
        }
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
