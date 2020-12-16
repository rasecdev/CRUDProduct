using Autofac;
using AutoMapper;
using CRUDCategory.Application;
using CRUDProduct.Application;
using CRUDProduct.Application.Interfaces;
using CRUDProduct.Application.Mappers;
using CRUDProduct.Application.Services;
using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Core.Interfaces.Services;
using CRUDProduct.Infra.Data.Repositories;

namespace CRUDProduct.Infra.CrossCutting
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ApplicationServiceCategory>().As<IApplicationServiceCategory>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<ServiceCategory>().As<IServiceCategory>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryCategory>().As<IRepositoryCategory>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingProduct());
                cfg.AddProfile(new ModelToDtoMappingProduct());
                cfg.AddProfile(new DtoToModelMappingCategory());
                cfg.AddProfile(new ModelToDtoMappingCategory());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}
