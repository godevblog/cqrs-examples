namespace MediatoRExample {
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    using System.Reflection;
    using Autofac;
    using CustomExample.Repositories;
    using CustomExample.Queries;
    using CustomExample.Commands;
    using CustomExample;

    internal class AutofacModule : Autofac.Module {
        protected override void Load(ContainerBuilder builder) {

           // builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

            builder.RegisterType<DataRepository>().SingleInstance();

            var openTypes = new [] {
                typeof(IQueryHandler<,>),
                typeof(ICommandHandler<>),
            };

            foreach (var openType in openTypes) {
                builder
                    .RegisterAssemblyTypes(typeof(GetDataQuery).GetTypeInfo().Assembly)
                    .AsClosedTypesOf(openType)
                    .AsImplementedInterfaces();

                    builder
                    .RegisterAssemblyTypes(typeof(SetDataCommand).GetTypeInfo().Assembly)
                    .AsClosedTypesOf(openType)
                    .AsImplementedInterfaces();
            }
        }
    }
}