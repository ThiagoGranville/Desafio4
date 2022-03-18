using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Domain.User
{
    public class Student : User
    {
        public Guid idAluno { get; private set; }

        public Student(string email, string password, string cpf, string name, int age, RoleType role = RoleType.STUDENT) : base(email, password, role, cpf, name, age)
        {
            idAluno= Guid.NewGuid();
        }
    }
}
