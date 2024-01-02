using System.Linq.Expressions;
using ToDo.Domain.Common.Caching;
using ToDo.Domain.Common.Query;
using ToDo.Domain.Entities;
using ToDo.Persistence.Caching.Brokers;
using ToDo.Persistence.DataContexts;
using ToDo.Persistence.Repositories.Interfaces;

namespace ToDo.Persistence.Repositories;

public class TodoRepository(
    AppDbContext dbContext,
    ICacheBroker cacheBroker
) : EntityRepositoryBase<TodoItem, AppDbContext>(dbContext, cacheBroker, new CacheEntryOptions()),
    ITodoRepository
{
    public new IQueryable<TodoItem> Get(Expression<Func<TodoItem, bool>>? predicate = default, bool asNoTracking = false)
        => base.Get(predicate, asNoTracking);

    public new ValueTask<IList<TodoItem>> GetAsync(QuerySpecification<TodoItem> querySpecification, CancellationToken cancellationToken = default)
        => base.GetAsync(querySpecification, cancellationToken);

    public new ValueTask<IList<TodoItem>> GetAsync(QuerySpecification querySpecification, CancellationToken cancellationToken = default)
        => base.GetAsync(querySpecification, cancellationToken);

    public new ValueTask<TodoItem?> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
        => base.GetByIdAsync(id, asNoTracking, cancellationToken);

    public new ValueTask<TodoItem> CreateAsync(TodoItem entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        => base.CreateAsync(entity, saveChanges, cancellationToken);

    public new ValueTask<TodoItem> UpdateAsync(TodoItem entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        => base.UpdateAsync(entity, saveChanges, cancellationToken);

    public new ValueTask<TodoItem?> DeleteByIdAsync(Guid todoId, bool saveChanges = true, CancellationToken cancellationToken = default)
        => base.DeleteByIdAsync(todoId, saveChanges, cancellationToken);
}