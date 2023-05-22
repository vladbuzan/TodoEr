using API.Views.ToDo;
using BusinessLogic.Queries.ToDos;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController
{
    private readonly IMediator _mediatr;

    public ToDoController(IMediator mediatr) => _mediatr = mediatr;

    [HttpGet]
    public async Task<IEnumerable<ToDoSimpleView>> GetAllAsync()
    {
        var response = await _mediatr.Send(new GetAllTodos.Request());

        return response.Adapt<IEnumerable<ToDoSimpleView>>();
    }
}