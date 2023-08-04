
using Memorize_word_.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Memorize_word_.Interfase;

public interface IRepository<TEntity, TViewModel>
{
    public Task<int> CreateAsync(TEntity editedObj);

    public Task<int> UpdateAsync(long id, TEntity editedObj);

    public Task<int> DeleteAsync(long id);

    public Task<IList<TViewModel>> GetAllAsync(PaginationParams @params);

    public Task<TViewModel> GetAsync(long id);
}
