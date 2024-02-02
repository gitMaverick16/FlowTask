using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class UpdateCardValidator : AbstractValidator<UpdateCardDTO>
    {
        public UpdateCardValidator()
        {
            RuleFor(card => card.Id).NotNull();
            RuleFor(card => card.Title).NotNull();
            RuleFor(card => card.Description).NotNull();
        }
    }
}
