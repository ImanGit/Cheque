﻿using System;
using System.Threading;
using AutoMapper;
using Cheque.Common.DependencyResolution.Registeries;
using Cheque.DataLayer.Context;
using StructureMap;

namespace Cheque.Common.DependencyResolution
{
    /// <summary>
    /// </summary>
    public static class StructureMapObjectFactory
    {
        #region Fields

        private static readonly Lazy<Container> ContainerBuilder = new Lazy<Container>(DefaultContainer,
            LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion

        #region Container

        public static IContainer Container => ContainerBuilder.Value;

        #endregion

        #region DefaultContainer

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private static Container DefaultContainer()
        {
            var container = new Container(ioc =>
            {
                ioc.For<IUnitOfWork>().Singleton().Use<ApplicationDbContext>();
                ioc.For<IStructureMapFormFactory>().Use<StructureMapFormFactory>();

                ioc.AddRegistry<ServiceLayerRegistery>();
                ioc.AddRegistry<AutoMapperRegistery>();

                ioc.Scan(scanner => { scanner.WithDefaultConventions(); });
            });

            container.AssertConfigurationIsValid();

            ConfigureAutoMapper(container);

            return container;
        }

        #endregion

        /// <summary>
        /// </summary>
        /// <param name="container"></param>
        private static void ConfigureAutoMapper(IContainer container)
        {
            // Exception - unmapped member
            container.GetInstance<IMapper>().ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}