using Autofac;
using Notify.Application.Abstract;
using Notify.Application.Concrete;


namespace Notify.Application.Autofac
{
    public class AutofacApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SESMailManager>().As<IMailClient>();
        }
    }
}