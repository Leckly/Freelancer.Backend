using FluentValidation;
using FluentValidation.Results;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Freelancer.Backend.Business.Validators
{
    public class RegisterValidator: AbstractValidator<RegisterDTO>
    {
        private const string RequiredMessage = "{PropertyName} is required";
        private const string EmailMessage = "It is not an email";
        private const string PasswordRegexMessage = "Password must contain 8 letters, one big letter, one number and one special letter";
        private const string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        private const string MaxLengthMessage = "{PropertyName} max length is {MaxLength}";
        private const string MaxLengthOfTagsMessage = "Tags max length is 20";
        private const int MaxLengthTypical = 255;
        private const int MaxLengthTypical2 = 512;
        private const int MaxLengthOfTags = 20;
        private const int MaxLengthOfKRSAndNIP = 10;

        public RegisterValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(RequiredMessage)
                .EmailAddress().WithMessage(EmailMessage);

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(RequiredMessage)
                .Must(IsMatchedWithRegex).WithMessage(PasswordRegexMessage);

            RuleFor(x => x.Address)
                .MaximumLength(MaxLengthTypical).WithMessage(MaxLengthMessage);

            RuleFor(x => x.NIP)
                .MaximumLength(MaxLengthOfKRSAndNIP).WithMessage(MaxLengthMessage);

            RuleFor(x => x.KRS)
                .MaximumLength(MaxLengthOfKRSAndNIP).WithMessage(MaxLengthMessage);

            RuleFor(x => x.CompanyName)
                .MaximumLength(MaxLengthTypical).WithMessage(MaxLengthMessage);

            RuleFor(x => x.Description)
                .MaximumLength(MaxLengthTypical2).WithMessage(MaxLengthMessage);

            RuleFor(x => x.Tags)
                .Must(IsLessThanMaxLength).WithMessage(MaxLengthOfTagsMessage);

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage(RequiredMessage)
                .MaximumLength(MaxLengthTypical).WithMessage(MaxLengthMessage);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage(RequiredMessage)
                .MaximumLength(MaxLengthTypical).WithMessage(MaxLengthMessage);
        }

        protected override void RaiseValidationException(ValidationContext<RegisterDTO> context, ValidationResult result)
        {
            throw new ValidationApiException(result.ToString());
        }

        private bool IsMatchedWithRegex(string password) => Regex.IsMatch(password, PasswordRegex);

        private bool IsLessThanMaxLength(string[] tags) => tags.Length <= MaxLengthOfTags;
    }
}
