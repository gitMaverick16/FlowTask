using FlowTask.DTOs;
using FluentValidation;

namespace FlowTask.Validators
{
    public class UpdateSectionValidator : AbstractValidator<UpdateSectionDTO>
    {
        public UpdateSectionValidator()
        {
            RuleFor(section => section.Id).NotNull();
            RuleFor(section => section.Description).NotNull();
            RuleFor(section => section.Name).NotNull();
        }
    }
}
