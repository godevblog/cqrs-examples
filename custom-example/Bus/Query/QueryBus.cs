using System;
using System.Threading.Tasks;
using Autofac;
using CustomExample.Bus.Query;
using CustomExample.Queries;

namespace v.Bus.Query {
    public class QueryBus : IQueryBus {
        private readonly ILifetimeScope _container;

        public QueryBus(ILifetimeScope container) {
            _container = container;
        }

        public async Task<TResult> Process<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult> {
            var queryHandle = _container.Resolve<IQueryHandler<TQuery, TResult>>();

            if (queryHandle == null) {
                throw new Exception($"Not found handler for Query: '{query.GetType().FullName}'");
            }

            TResult result = default(TResult);

            try {
                result =  await queryHandle.Execute(query);
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}