using System.ComponentModel.DataAnnotations;

namespace Desafio4.Domain.User
{
    public abstract class User
    {
        [Required]
        private string _password;
        [Required]
        [EmailAddress]
        public string Email { get; private set; }
        public RoleType Role { get; private set; }
        [Required]
        public string CPF { get; private set; }
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }
        [Required]
        [Range(18, int.MaxValue)]
        public int Age { get; set; }

        public User(string email, string password, RoleType role, string cpf, string name, int age)
        {
            SetEmail(email);
            SetPassword(password);
            SetRole(role);
            SetCPF(cpf);
            Name = name;
            Age = age;
        }

        public void SetPassword(string passwordValue)
        {
            _password = passwordValue;
        }

        public void SetRole(RoleType roleValue)
        {
            Role = roleValue;
        }

        public void SetCPF(string cpfValue)
        {
            CPF = cpfValue;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public bool authenticatePassword(string password)
        {
            return password == _password;
        }
    }
}
