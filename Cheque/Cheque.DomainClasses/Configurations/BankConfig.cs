using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cheque.DomainClasses.Configurations.Common;
using System.Data.Entity.ModelConfiguration;
using Cheque.DomainClasses.Entities;

namespace Cheque.DomainClasses.Configurations
{
    public class BankConfig: EntityTypeConfiguration<Bank>
    {
    }
}
