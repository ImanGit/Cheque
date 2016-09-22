using System.Windows.Forms;

namespace Cheque.Common.DependencyResolution
{
    /// <summary>
    /// </summary>
    public class StructureMapFormFactory : IStructureMapFormFactory
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Create<T>() where T : Form
        {
            return StructureMapObjectFactory.Container.GetInstance<T>();
        }
    }
}