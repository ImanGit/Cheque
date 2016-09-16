﻿using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Cheque.DataLayer.Conventions;
using Cheque.DomainClasses.Configurations.Common;
using Cheque.DomainClasses.Entities.Common;
using Cheque.Utility.Generators;
using EFSecondLevelCache;

namespace Cheque.DataLayer.Context
{
    /// <summary>
    /// </summary>
    public class BaseDbContext : DbContext
    {
        #region Constrans

        protected const string ConcurrencyMessage =
            "مقادیر در سمت بانک اطلاعاتی تغییر کرده‌اند. لطفا صفحه را ریفرش کنید.";

        #endregion

        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseDbContext(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region OnModelCreating

        /// <summary>
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Conventions.Add(new CustomeConvention());

            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.AddFromAssembly(typeof(BaseConfig).Assembly);
            LoadEntities(typeof(BaseEntity).Assembly, modelBuilder, "Cheque.DomainClasses.Entities");
        }

        #endregion

        #region RejectChanges

        /// <summary>
        /// </summary>
        public void RejectChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        #endregion

        #region UpdateAuditFields

        /// <summary>
        /// </summary>
        /// <param name="auditUserId"></param>
        private void UpdateAuditFields(Guid auditUserId)
        {
            var auditUserIp = "HttpContext.Current.Request.GetIp()";
            var auditUserAgent = "HttpContext.Current.Request.GetBrowser()";
            var auditDate = DateTime.Now;

            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                // Note: You must add a reference to assembly : System.Data.Entity
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Id = SequentialGuidGenerator.NewSequentialGuid();
                        entry.Entity.CreatedOn = auditDate;
                        //entry.Entity.CreatedById = auditUserId;
                        entry.Entity.ModifiedOn = auditDate;
                        entry.Entity.Action = AuditLogType.Create;
                        //entry.Entity.ModifiedById = auditUserId;
                        entry.Entity.CreatorIp = auditUserIp;
                        entry.Entity.ModifierIp = auditUserIp;
                        entry.Entity.CreatorAgent = auditUserAgent;
                        entry.Entity.ModifierAgent = auditUserAgent;
                        entry.Entity.Version = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedOn = auditDate;
                        //entry.Entity.ModifiedById = auditUserId;
                        entry.Entity.ModifierIp = auditUserIp;
                        entry.Entity.ModifierAgent = auditUserAgent;
                        entry.Entity.Version = ++entry.Entity.Version;
                        entry.Entity.Action = entry.Entity.IsDeleted
                            ? AuditLogType.SoftDelete
                            : AuditLogType.Update;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            //فقط تعريف شده تا يك برك پوينت در اينجا قرار داده شود براي آزمايش فراخواني آن
            base.Dispose(disposing);
        }

        #endregion

        #region PrivateMethods

        /// <summary>
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="modelBuilder"></param>
        /// <param name="nameSpace"></param>
        private static void LoadEntities(Assembly asm, DbModelBuilder modelBuilder, string nameSpace)
        {
            var entityTypes = asm.GetTypes()
                .Where(type => type.BaseType != null &&
                               type.Namespace == nameSpace &&
                               type.BaseType == null)
                .ToList();
            entityTypes.ForEach(modelBuilder.RegisterEntityType);
        }

        private string[] GetChangedEntityNames()
        {
            return ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added ||
                            x.State == EntityState.Modified ||
                            x.State == EntityState.Deleted)
                .Select(x => ObjectContext.GetObjectType(x.Entity.GetType()).FullName)
                .Distinct()
                .ToArray();
        }

        #endregion

        #region SaveChanges

        public int SaveAllChanges(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            if (auditUserId.HasValue)
                UpdateAuditFields(auditUserId.Value);
            var result = SaveChanges();
            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }

        public Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            try
            {
                if (auditUserId.HasValue)
                    UpdateAuditFields(auditUserId.Value);
                var result = SaveChangesAsync();
                if (!invalidateCacheDependencies) return result;
                var changedEntityNames = GetChangedEntityNames();
                new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
                return result;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        #endregion

        #region Repository

        // public DbSet<Product> Products { get; set; }

        #endregion
    }
}