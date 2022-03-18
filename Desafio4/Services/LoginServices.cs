using Desafio4.Domain.User;
using Desafio4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Services
{
    public class LoginServices
    {
        private UserRepository _userRepository;
        public bool authResult { get; private set; }

        public LoginServices()
        {
            _userRepository = new UserRepository();
            GenerateAdmin();
        }


        public (bool, User) Login(string email, string password)
        {
            User userInfo = _userRepository.FindByEmail(email);

            if (userInfo == null)
            {
                return (false, null);
            }

            if (email != userInfo.Email || userInfo.authenticatePassword(password))
            {
                authResult = false;
            }

            authResult = true;

            (bool, User) result = (authResult, userInfo);

            return result;
        }
        public void GenerateAdmin()
        {

            Instructor admin = new Instructor("rogerio@cedro.com", "12345", "12345678910", "Rogério", 28);

            _userRepository.Register(admin);

            User firstAdmin = _userRepository.FindByEmail("rogerio@cedro.com");

            if (firstAdmin != null)
            {
                return;
            }
        }
    }
}
