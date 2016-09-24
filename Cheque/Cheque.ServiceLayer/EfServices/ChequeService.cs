using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Cheque.DataLayer.Context;
using Cheque.Mapping.Extensions;
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
        public void Create(ChequeViewModel model)
        {
            var m= _mapper.Map<ChequeViewModel, DomainClasses.Entities.Cheque>(model);
            _cheque.Add(m);
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
        public ChequeViewModel GetForEdit(Guid id)
        {
            DomainClasses.Entities.Cheque cheque = _cheque
                .FirstOrDefault(s => s.Id == id);
            return _mapper.Map<DomainClasses.Entities.Cheque, ChequeViewModel>(cheque);
        }

        #endregion
        #region Update
        public void Edit(ChequeViewModel vm)
        {
            var cheque = _cheque.First(s => s.Id == vm.Id);
            _mapper.Map(vm,cheque);
            //cheque.BranchCode = vm.BranchCode;
            //cheque.AccountOwner = vm.AccountOwner;
            //cheque.AssignmentedOn = vm.AssignmentedOn.ToGeorgeDateTime();
            _unitOfWork.SaveAllChanges(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion
        #region Delete
        #endregion
    }
}