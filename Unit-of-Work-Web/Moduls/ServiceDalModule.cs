using Autofac;
using System.Reflection;
using Unit_of_Work_BusinessLayer.Concrete;
using Unit_of_Work_DataAccessLayer.Concrete;
using Module = Autofac.Module;


namespace Unit_of_Work_Web.Moduls
{
    public class ServiceDalModule:Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            var webAssembly = Assembly.GetExecutingAssembly();
            var dalAssembly = Assembly.GetAssembly(typeof(Context));
            var serviceAssembly = Assembly.GetAssembly(typeof(GenericService<>));

            builder.RegisterAssemblyTypes(webAssembly, dalAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Dal")).AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(webAssembly, dalAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }


    }
}
