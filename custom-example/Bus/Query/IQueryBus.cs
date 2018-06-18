using System.Threading.Tasks;
using CustomExample.Queries;

namespace CustomExample.Bus.Query
{
    public interface IQueryBus
    {
         Task<TResult> Process<TQuery, TResult>(TQuery query) where TQuery: IQuery<TResult>;
    }
}