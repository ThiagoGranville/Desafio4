using Desafio4.Domain.User;
using Desafio4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Controllers
{
    internal class StudentController
    {
        private StudentServices _studentServices;

        public StudentController()
        {
            _studentServices = new StudentServices();
        }

        public void Register(string email, string password, string cpf, string name, int age)
        {
            Student newStudent = new Student(email, password, cpf, name, age);

            _studentServices.ValidateAndSave(newStudent);
        }

        public void FindAll()
        {
            List<Student> registeredStudents = _studentServices.FindAll();

            foreach (Student student in registeredStudents)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void FindByName(string name)
        {
            List<Student> foundStudents = _studentServices.FindByName(name);

            foreach (Student student in foundStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
