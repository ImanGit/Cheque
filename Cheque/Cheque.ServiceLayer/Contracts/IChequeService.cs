using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ServiceLayer.Contracts
{
    public interface IChequeService
    {
        void Create(DomainClasses.Entities.Cheque model);

        IList<DomainClasses.Entities.Cheque> GetList();
    }
}
