﻿using System.Data.Entity.Design.PluralizationServices;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Globalization;

namespace Cheque.DataLayer.Conventions
{
    /// <summary>
    /// </summary>
    public class CustomeConvention : Convention
    {
        /// <summary>
        /// </summary>
        public CustomeConvention()
        {
            var pluralization = PluralizationService.CreateService(new CultureInfo("en-US"));

            // FieldName Convention
            Properties()
                .Configure(
                    property =>
                        property.HasColumnName(property.ClrPropertyInfo.ReflectedType.Name + "_" +
                                               property.ClrPropertyInfo.Name));

            // TableName Convention
            Types().Configure(entity => entity.ToTable("CM_" + pluralization.Pluralize(entity.ClrType.Name), "dbo"));
        }
    }
}