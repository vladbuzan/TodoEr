using FluentValidation;

namespace API.Requests.ToDo;

public record CreateToDoRequest(string Title, string Description);

public class CreateToDoRequestValidator : AbstractValidator<CreateToDoRequest>
{
    public CreateToDoRequestValidator() => _ = RuleFor(x => x.Title).NotEmpty();
}