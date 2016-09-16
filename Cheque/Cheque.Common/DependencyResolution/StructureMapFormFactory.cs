using System.Windows.Forms;

namespace Cheque.Common.DependencyResolution
{
    public class StructureMapFormFactory : IStructureMapFormFactory
    {
        public T Create<T>() where T : Form
        {
            return StructureMapObjectFactory.Container.GetInstance<T>();
        }
    }
}