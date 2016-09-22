using System.Windows.Forms;

namespace Cheque.Common.DependencyResolution
{
    /// <summary>
    /// </summary>
    public interface IStructureMapFormFactory
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Create<T>() where T : Form;
    }
}