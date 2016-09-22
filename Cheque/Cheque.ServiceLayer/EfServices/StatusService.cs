using System.Collections;
using System.Data.Entity;
using System.Linq;
using Cheque.DataLayer.Context;
using Cheque.DomainClasses.Entities;
using Cheque.ServiceLayer.Contracts;

namespace Cheque.ServiceLayer.EfServices
{
    /// <summary>
    /// </summary>
    public class StatusService : IStatusService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        public StatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _status = unitOfWork.Set<Status>();
        }

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IList FillStatusLookup()
        {
            return _status
                .AsNoTracking()
                .Select(s => new {s.Id, s.Title})
                .ToList();
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Status> _status;

        #endregion
    }
}