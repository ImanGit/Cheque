using System;

namespace Cheque.ViewModel.Models
{
    /// <summary>
    /// </summary>
    public class ChequeViewModel
    {
        #region Properties

        /// <summary>
        ///     شناسه یکتای موجودیت
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        ///     gets or sets date that this entity was created
        /// </summary>
        public virtual string CreatedOn { get; set; }

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
        public virtual string ReceivedOn { get; set; }

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
        public virtual string AssignmentedOn { get; set; }

        /// <summary>
        ///     نام واگذار کننده
        /// </summary>
        public virtual string AssignorName { get; set; }

        /// <summary>
        ///     تاریخ وصول
        /// </summary>
        public virtual string ReceiptedOn { get; set; }

        /// <summary>
        ///     تاریخ عودت
        /// </summary>
        public virtual string DeliveredOn { get; set; }

        /// <summary>
        ///     تاریخ برگشت
        /// </summary>
        public virtual string ReturnedOn { get; set; }

        /// <summary>
        ///     تاریخ تسویه برگشتی
        /// </summary>
        public virtual string SettlementedOn { get; set; }

        /// <summary>
        ///     مدت تسویه برگشتی (روز) ها
        /// </summary>
        public virtual string SettlementDay { get; set; }

        /// <summary>
        ///     خرج شده به
        /// </summary>
        public virtual string SpentTo { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Guid BankId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid StatusId { get; set; }

        #endregion
    }
}