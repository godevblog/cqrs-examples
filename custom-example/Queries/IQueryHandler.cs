using System.Threading.Tasks;

namespace CustomExample.Queries {
    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult> 
    {
        Task<TResult> Execute(TQuery query);
    }
}