using Autofac;
using MontaditosAMS.Core.Services;
using MontaditosAMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontaditosForms.ViewModels.Base
{
    public class VMLocator
    {
        private static IContainer container;

        public VMLocator()
        {
        }

        public static T Resolve<T>()
        {
            if (container == null)
                BuildContainer();

            return container.Resolve<T>();
        }

        private static void BuildContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<MontaditosService>().As<IMontaditosService>();
            builder.RegisterType<FirstViewModel>();

            container = builder.Build();
        }
    }
}
