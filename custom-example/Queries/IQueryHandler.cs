using System.Threading.Tasks;

namespace CustomExample.Queries
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery<TResult>
    {
         Task<TResult> Handle(TQuery query);
    }
}