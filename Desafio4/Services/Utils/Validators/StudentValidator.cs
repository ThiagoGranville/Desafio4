using Desafio4.Domain.User;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Desafio4.Services.Utils.Validators
{
    public static class StudentValidator
    {
        public static bool isValid(Student student)
        {
            ValidationContext context = new ValidationContext(student, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool validation = Validator.TryValidateObject(student, context, results, true);

            return validation;
        }
    }
}
