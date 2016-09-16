﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.DomainClasses.Entities.Common
{
    public abstract class Entity
    {
        #region Properties

        /// <summary>
        ///     gets or sets date that this entity was created
        /// </summary>
        public virtual DateTime? CreatedOn { get; set; }

        /// <summary>
        ///     gets or sets Date that this entity was updated
        /// </summary>
        public virtual DateTime? ModifiedOn { get; set; }

        /// <summary>
        ///     gets or sets IP Address of Creator
        /// </summary>
        public virtual string CreatorIp { get; set; }

        /// <summary>
        ///     gets or set IP Address of Modifier
        /// </summary>
        public virtual string ModifierIp { get; set; }

        /// <summary>
        ///     به منظور ممانعت از ویرایش
        /// </summary>
        public virtual bool ModifyLocked { get; set; }

        /// <summary>
        ///     indicate this entity is deleted softly
        /// </summary>
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        ///     gets or sets information of user agent of modifier
        /// </summary>
        public virtual string ModifierAgent { get; set; }

        /// <summary>
        ///     gets or sets information of user agent of Creator
        /// </summary>
        public virtual string CreatorAgent { get; set; }

        /// <summary>
        ///     gets or sets count of Modification Default is 1
        /// </summary>
        public virtual int Version { get; set; }

        /// <summary>
        ///     gets or sets action (create,update,softDelete)
        /// </summary>
        public virtual AuditLogType Action { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     به عنوان آخرین تغییر دهنده
        /// </summary>
        //public virtual User ModifiedBy { get; set; }

        /// <summary>
        ///     به عنوان آخرین تغییر دهنده
        /// </summary>
        //public virtual Guid? ModifiedById { get; set; }

        /// <summary>
        ///     به عنوان ایجاد کننده
        /// </summary>
        //public virtual User CreatedBy { get; set; }

        /// <summary>
        ///     به عنوان ایجاد کننده
        /// </summary>
        //public virtual Guid? CreatedById { get; set; }

        #endregion
    }
}
