using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class CreateBoardValidator : AbstractValidator<CreateBoardDTO>
    {
        public CreateBoardValidator()
        {
            RuleFor(board => board.Description).NotNull();
            RuleFor(board => board.Name).NotNull();
        }
    }
}
