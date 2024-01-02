using System.Linq.Expressions;
using ToDo.Domain.Common.Query;
using ToDo.Domain.Entities;

namespace ToDo.Persistence.Repositories.Interfaces;

public interface ITodoRepository
{
    IQueryable<TodoItem> Get(Expression<Func<TodoItem, bool>>? predicate = default, bool asNoTracking = false);
    
    ValueTask<IList<TodoItem>> GetAsync(QuerySpecification<TodoItem> querySpecification, CancellationToken cancellationToken = default);
    
    ValueTask<IList<TodoItem>> GetAsync(QuerySpecification querySpecification,
        CancellationToken cancellationToken = default);
    
    ValueTask<TodoItem?> GetByIdAsync(Guid todoId, bool asNoTracking = false, CancellationToken cancellationToken = default);
    
    ValueTask<TodoItem> CreateAsync(TodoItem todoItem, bool saveChanges = true, CancellationToken cancellationToken = default);
    
    ValueTask<TodoItem> UpdateAsync(TodoItem todoItem, bool saveChanges = true, CancellationToken cancellationToken = default);
    
    ValueTask<TodoItem> DeleteByIdAsync(Guid todoId, bool saveChanges = true, CancellationToken cancellationToken = default);
}
