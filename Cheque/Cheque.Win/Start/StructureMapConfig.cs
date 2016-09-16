using Cheque.Common.DependencyResolution;

namespace Cheque.Win.Start
{
    public static class StructureMapConfig
    {
        public static T Resolve<T>()
        {
            return StructureMapObjectFactory.Container.GetInstance<T>();
        }
    }
}