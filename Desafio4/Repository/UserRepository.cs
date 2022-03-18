using Desafio4.Domain;
using Desafio4.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Repository
{
    internal class UserRepository
    {
        private static List<User> _registeredUsers;

        static UserRepository()
        {
            _registeredUsers = new List<User>();
        }

        public void Register(User newUser)
        {
            _registeredUsers.Add(newUser);
        }


        public User FindByEmail(string email)
        {
            User foundUser = _registeredUsers.Find(user => user.Email == email);

            if (foundUser == null)
            {
                Console.WriteLine(_registeredUsers.Count);

                Console.WriteLine("TA NULL?");
            }

            return foundUser;
        }

    }
}
