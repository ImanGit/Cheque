using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Cheque.DataLayer.Context;
using Cheque.ServiceLayer.Contracts;
using Cheque.ViewModel.Models;

namespace Cheque.ServiceLayer.EfServices
{
    /// <summary>
    /// </summary>
    public class ChequeService : IChequeService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ChequeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _cheque = unitOfWork.Set<DomainClasses.Entities.Cheque>();
        }

        #endregion

        #region Create

        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        public void Create(DomainClasses.Entities.Cheque model)
        {
            _cheque.Add(model);
            _unitOfWork.SaveAllChanges();
        }

        #endregion

        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<DomainClasses.Entities.Cheque> _cheque;

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ChequeViewModel> GetList()
        {
            IEnumerable<DomainClasses.Entities.Cheque> cheque = _cheque
                .AsNoTracking()
                .ToList();
            return _mapper.Map<IEnumerable<DomainClasses.Entities.Cheque>, IEnumerable<ChequeViewModel>>(cheque);
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DomainClasses.Entities.Cheque GetForEdit(Guid id)
        {
            return _cheque
                .FirstOrDefault(s => s.Id == id);
        }

        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}