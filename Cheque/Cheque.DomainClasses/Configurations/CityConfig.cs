using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheque.DomainClasses.Configurations.Common;
using Cheque.DomainClasses.Entities;

namespace Cheque.DomainClasses.Configurations
{
    public class CityConfig : EntityTypeConfiguration<City>
    {
    }
}
