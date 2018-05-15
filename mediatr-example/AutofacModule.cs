namespace MediatoRExample {
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    using MediatR.Pipeline;
    using MediatR;
    using System.Reflection;
    using Autofac;
    using MediatoRExample.Repositories;

    internal class AutofacModule : Autofac.Module {
        protected override void Load(ContainerBuilder builder) {

            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

            builder.RegisterType<DataRepository>().SingleInstance();

            var mediatrOpenTypes = new [] {
                typeof(IRequestHandler<,>),
                typeof(INotificationHandler<>),
            };

            foreach (var mediatrOpenType in mediatrOpenTypes) {
                builder
                    .RegisterAssemblyTypes(typeof(GetDataQuery).GetTypeInfo().Assembly)
                    .AsClosedTypesOf(mediatrOpenType)
                    .AsImplementedInterfaces();

                    builder
                    .RegisterAssemblyTypes(typeof(SetDataCommand).GetTypeInfo().Assembly)
                    .AsClosedTypesOf(mediatrOpenType)
                    .AsImplementedInterfaces();
            }

            builder.Register<ServiceFactory>(ctx => {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
        }
    }
}