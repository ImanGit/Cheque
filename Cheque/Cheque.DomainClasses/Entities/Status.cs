﻿using System.Collections.Generic;
using Cheque.DomainClasses.Entities.Common;

namespace Cheque.DomainClasses.Entities
{
    /// <summary>
    /// </summary>
    public class Status : BaseEntity
    {
        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual ICollection<Cheque> Cheques { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// </summary>
        public virtual string CustomCode { get; set; }

        #endregion
    }
}