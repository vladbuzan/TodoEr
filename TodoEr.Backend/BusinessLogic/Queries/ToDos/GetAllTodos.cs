using Data.Entities;
using Data.Repositories;
using MediatR;

namespace BusinessLogic.Queries.ToDos;

public class GetAllTodos
{
    public class Request : IRequest<IEnumerable<ToDo>> { }

    public class Handler : IRequestHandler<Request, IEnumerable<ToDo>>
    {
        private readonly ToDoRepository _toDoRepository;

        public Handler(ToDoRepository toDoRepository) => _toDoRepository = toDoRepository;

        public Task<IEnumerable<ToDo>> Handle(Request request, CancellationToken cancellationToken) =>
            _toDoRepository.GetAllAsync();
    }
}