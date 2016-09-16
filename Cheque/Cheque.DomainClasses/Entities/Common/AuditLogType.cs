namespace Cheque.DomainClasses.Entities.Common
{
    /// <summary>
    ///     نشان دهنده انواع علمیاتی است که میتواند انجام شود
    /// </summary>
    public enum AuditLogType
    {
        /// <summary>
        ///     درج رکود
        /// </summary>
        
        Create,

        /// <summary>
        ///     ویرایش
        /// </summary>
       
        Update,

        /// <summary>
        ///     حذف فیزیکی
        /// </summary>
        
        Delete,

        /// <summary>
        ///     حذف نرم
        /// </summary>
        
        SoftDelete
    }
}