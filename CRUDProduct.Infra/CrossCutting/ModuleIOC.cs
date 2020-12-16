using Autofac;
using Module = Autofac.Module;

namespace CRUDProduct.Infra.CrossCutting
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}