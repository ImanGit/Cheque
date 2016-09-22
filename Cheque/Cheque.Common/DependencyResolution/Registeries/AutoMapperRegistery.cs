using System;
using System.Linq;
using AutoMapper;
using Cheque.Mapping.Profiles;
using StructureMap;

namespace Cheque.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class AutoMapperRegistery : Registry
    {
        /// <summary>
        /// </summary>
        public AutoMapperRegistery()
        {
            var profileAssembly = typeof(ChequeProfile).Assembly;
            var profiles =
                profileAssembly.GetTypes()
                    .Where(t => typeof(Profile).IsAssignableFrom(t))
                    .Select(t => (Profile)Activator.CreateInstance(t));

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);

                }
            });

            For<MapperConfiguration>().Use(config);
            For<IMapper>().Use(ctx => ctx.GetInstance<MapperConfiguration>().CreateMapper(ctx.GetInstance));
        }
    }
}