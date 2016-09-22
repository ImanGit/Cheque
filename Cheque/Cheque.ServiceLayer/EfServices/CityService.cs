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
    public class CityService : ICityService
    {
        #region Ctor

        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _city = unitOfWork.Set<City>();
        }

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IList FillCityLookup()
        {
            return _city
                .AsNoTracking()
                .Select(s => new {s.Id, s.CustomeCode, s.Title})
                .ToList();
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<City> _city;

        #endregion
    }
}