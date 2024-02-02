using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class UpdateBoardValidator : AbstractValidator<UpdateBoardDTO>
    {
        public UpdateBoardValidator()
        {
            RuleFor(board => board.Id).NotNull();
            RuleFor(board => board.Name).NotNull();
            RuleFor(board => board.Description).NotNull();
        }
    }
}
