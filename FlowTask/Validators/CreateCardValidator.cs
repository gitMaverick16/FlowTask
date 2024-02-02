using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class CreateCardValidator : AbstractValidator<CreateCardDTO>
    {
        public CreateCardValidator()
        {
            RuleFor(card => card.Description).NotNull();
            RuleFor(card => card.Title).NotNull();
        }
    }
}
