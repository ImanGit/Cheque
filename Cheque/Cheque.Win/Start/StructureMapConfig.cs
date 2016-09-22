using Cheque.Common.DependencyResolution;

namespace Cheque.Win.Start
{
    /// <summary>
    /// </summary>
    public static class StructureMapConfig
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return StructureMapObjectFactory.Container.GetInstance<T>();
        }
    }
}