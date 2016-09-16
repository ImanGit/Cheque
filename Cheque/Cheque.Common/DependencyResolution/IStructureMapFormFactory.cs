using System.Windows.Forms;

namespace Cheque.Common.DependencyResolution
{
    public interface IStructureMapFormFactory
    {
        T Create<T>() where T : Form;
    }
}