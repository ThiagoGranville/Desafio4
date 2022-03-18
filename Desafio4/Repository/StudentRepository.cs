using Desafio4.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Repository
{
    public class StudentRepository
    {
        private static List<Student> _students;

        static StudentRepository()
        {
            _students = new List<Student>();
        }

        public void Save(Student newStudent)
        {
            _students.Add(newStudent);

            Console.WriteLine($"Aluno {newStudent.Name} criado com sucesso");
        }

        public List<Student> GetAll()
        {
            List<Student> sortedStudents = _students
                .OrderBy(student => student.Name)
                .ToList();

            return sortedStudents;
        }

        public List<Student> FilterByName(string name)
        {
            var foundStudents = _students.FindAll(student => student.Name.Contains(name));

            return foundStudents;
        }
    }
}
