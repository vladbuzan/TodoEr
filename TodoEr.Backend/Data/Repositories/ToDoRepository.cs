using Data.Entities;

namespace Data.Repositories;

public class ToDoRepository : BaseRepository<ToDo>
{
    public ToDoRepository(TodoErContext context) : base(context) { }
}
