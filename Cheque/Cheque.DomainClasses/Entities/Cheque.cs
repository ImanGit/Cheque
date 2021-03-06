﻿using System;
using Cheque.DomainClasses.Entities.Common;

namespace Cheque.DomainClasses.Entities
{
    public class Cheque : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کد شعبه
        /// </summary>
        public virtual int BranchCode { get; set; }

        /// <summary>
        ///     شماره حساب چک
        /// </summary>
        public virtual string AccountNumber { get; set; }

        /// <summary>
        ///     نام صاحب حساب
        /// </summary>
        public virtual string AccountOwner { get; set; }

        /// <summary>
        ///     تاریخ چک
        /// </summary>
        public virtual DateTime ReceivedOn { get; set; }

        /// <summary>
        ///     مبلغ چک
        /// </summary>
        public virtual int CostValue { get; set; }

        /// <summary>
        ///     شماره چک
        /// </summary>
        public virtual string CodeNumber { get; set; }

        /// <summary>
        ///     سری چک
        /// </summary>
        public virtual string SerialNumber { get; set; }

        /// <summary>
        ///     نام مشتری
        /// </summary>
        public virtual string CustomerName { get; set; }

        /// <summary>
        ///     شماره پیگیری
        /// </summary>
        public virtual string TrackingNumber { get; set; }

        /// <summary>
        ///     تاریخ واگذاری
        /// </summary>
        public virtual DateTime AssignmentedOn { get; set; }

        /// <summary>
        ///     نام واگذار کننده
        /// </summary>
        public virtual string AssignorName { get; set; }

        /// <summary>
        ///     تاریخ وصول
        /// </summary>
        public virtual DateTime ReceiptedOn { get; set; }

        /// <summary>
        ///     تاریخ عودت
        /// </summary>
        public virtual DateTime DeliveredOn { get; set; }

        /// <summary>
        ///     تاریخ برگشت
        /// </summary>
        public virtual DateTime ReturnedOn { get; set; }

        /// <summary>
        ///     تاریخ تسویه برگشتی
        /// </summary>
        public virtual DateTime SettlementedOn { get; set; }

        /// <summary>
        ///     مدت تسویه برگشتی (روز) ها
        /// </summary>
        public virtual DateTime SettlementDay { get; set; }

        /// <summary>
        ///     خرج شده به
        /// </summary>
        public virtual string SpentTo { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     بانک
        /// </summary>
        public virtual Bank Bank { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid BankId { get; set; }

        /// <summary>
        ///     شهر
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }

        /// <summary>
        ///     وضعیت
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid StatusId { get; set; }

        #endregion
    }
}