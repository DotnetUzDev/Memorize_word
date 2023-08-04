using Memorize_word_.Entities.WordEntities;
using System.Threading.Tasks;

namespace Memorize_word_.Interfase.WordRep;

public interface IWordRepositories : IRepository<Words,Words>
{
    public Task<int> CountAsync();
}
