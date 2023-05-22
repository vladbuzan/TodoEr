using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public abstract class BaseRepository<TEntity> where TEntity : class, IEntity
{
    private readonly TodoErContext _context;

    protected BaseRepository(TodoErContext context) => _context = context;

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _context.Set<TEntity>().ToListAsync();
}