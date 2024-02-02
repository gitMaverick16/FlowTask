using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class CreateSectionValidator : AbstractValidator<CreateSectionDTO>
    {
        public CreateSectionValidator()
        {
            RuleFor(section => section.Description).NotNull();
            RuleFor(section => section.Name).NotNull();
        }
    }
}
