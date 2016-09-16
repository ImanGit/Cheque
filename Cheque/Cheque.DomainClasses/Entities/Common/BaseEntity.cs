using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.DomainClasses.Entities.Common
{
    public abstract class BaseEntity:Entity
    {
        #region Properties

        /// <summary>
        ///     شناسه یکتای موجودیت
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        ///     gets or sets TimeStamp for prevent concurrency Problems
        /// </summary>
        public virtual byte[] RowVersion { get; set; }

        #endregion
    }
}
