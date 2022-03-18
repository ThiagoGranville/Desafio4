using Desafio4.Domain.User;
using Desafio4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Controllers
{
    public class LoginController
    {
       private LoginServices _loginServices;

        public LoginController()
        {
            _loginServices = new LoginServices();
        }

        public (bool auth, User userInfo) Login(string email, string password)
        {   
            (bool auth, User userInfo) = _loginServices.Login(email, password);

            return (auth, userInfo);
        }
    }
}
