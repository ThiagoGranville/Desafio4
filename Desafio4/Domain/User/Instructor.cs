using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Domain.User
{
    internal class Instructor : User
    {
        public Guid idInstructor { get; private set; }

        public Instructor(string email, string password, string cpf, string name, int age, RoleType role = RoleType.INSTRUCTOR) : base(email, password, role, cpf, name, age)
        {
            idInstructor = Guid.NewGuid();
        }
    }
}
