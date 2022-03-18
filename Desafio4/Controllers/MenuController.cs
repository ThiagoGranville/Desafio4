using Desafio4.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Controllers
{
    public class MenuController
    {
        private LoginController _loginController;
        private StudentController _studentController;

        public MenuController()
        {
            _loginController = new LoginController();
            _studentController = new StudentController();
        }

        public void Start()
        {
            //Console.Clear();
            Console.WriteLine("Bem vindo! Escolha a opção desejada: ");
            Console.WriteLine(" 1 -> Logar");
            Console.WriteLine(" 2 -> Registrar novo usuário");

            int MenuSelecao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (MenuSelecao)
            {
                case 1:
                    Console.WriteLine("Você escolheu logar");
                    ShowLoginMenu();
                    break;
                case 2:
                    Console.WriteLine("Você escolheu registrar");
                    //usuarioController.Registrar();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private void ShowLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite a sua senha: ");
            string password = Console.ReadLine();

            Console.Clear();

            (bool auth, User userInfo) = _loginController.Login(email, password);

            if (!auth)
            {
                Console.WriteLine("Email ou senha invalidos!");
                Console.ReadLine();
                ShowLoginMenu();
            }

            ShowLoggedOptions(userInfo);

        }

        private void ShowLoggedOptions(User userInfo)
        {
            Console.Clear();
            Console.WriteLine($"Olá {userInfo.Name}, o que deseja fazer?: ");
            Console.WriteLine(" 1 -> Registrar novo aluno");
            Console.WriteLine(" 2 -> Registrar nova aula");
            Console.WriteLine(" 3 -> Pesquisar alunos existentes");

            int MenuSelecao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (MenuSelecao)
            {
                case 1:
                    Console.WriteLine("Você escolheu registrar novo aluno");
                    ShowStudentRegisterForm(userInfo);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu registrar nova aula");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu pesquisar alunos");
                    ShowSearchStudentOptions(userInfo);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private void ShowSearchStudentOptions(User userInfo)
        {
            Console.Clear();
            Console.WriteLine(" 1 -> Procurar todos os alunos");
            Console.WriteLine(" 2 -> Procurar um aluno especifico");

            int MenuSelecao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (MenuSelecao)
            {
                case 1:
                    Console.WriteLine("Você escolheu procurar todos os alunos:");
                    _studentController.FindAll();
                    break;
                case 2:
                    Console.WriteLine("Você escolheu procurar por aluno especifico");
                    Console.WriteLine("Insira os parametros de busca: ");
                    string name = Console.ReadLine();
                    _studentController.FindByName(name);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.ReadLine();

            ShowLoggedOptions(userInfo);
        }

        private void ShowStudentRegisterForm(User userInfo)
        {
            Console.WriteLine("Quantos alunos deseja adicionar?");

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o email do aluno: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a idade do aluno: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o CPF do aluno: ");
                string cpf = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a senha do aluno: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                _studentController.Register(email, password, cpf, name, age);

            }

            Console.ReadLine();

            ShowLoggedOptions(userInfo);

        }

    }
}
