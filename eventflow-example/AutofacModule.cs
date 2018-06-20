using Autofac;
using EventFlow;
using EventFlow.Autofac.Extensions;
using EventFlow.Extensions;
using EventFlowExample.Commands;
using EventFlowExample.Queries;
using EventFlowExample.Repositories;

namespace EventFlowExample {
    internal class AutofacModule : Autofac.Module {
        protected override void Load(ContainerBuilder builder) {

            var container = EventFlowOptions.New
                .UseAutofacContainerBuilder(builder)
                .AddCommands(typeof(SetDataCommand), typeof(DeleteDataCommand))
                .AddCommandHandlers(typeof(SetDataCommandHandler), typeof(DeleteDataCommandHandler))
                .AddQueryHandler<GetDataQueryHandler, GetDataQuery, string>();

            builder.RegisterType<DataRepository>().SingleInstance();
        }
    }
}