using Desafio4.Domain.User;
using Desafio4.Repository;
using Desafio4.Services.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Services
{
    internal class StudentServices
    {
        private StudentRepository _studentRepository;

        public StudentServices()
        {
            _studentRepository = new StudentRepository();
        }

        public void ValidateAndSave(Student newStudent)
        {
            bool validation = StudentValidator.isValid(newStudent);

            if (!validation)
            {
                Console.WriteLine("erro de validação");
                return;
            }

            _studentRepository.Save(newStudent);
        }

        public List<Student> FindAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> FindByName(string name)
        {
            return _studentRepository.FilterByName(name);
        }
    }
}
