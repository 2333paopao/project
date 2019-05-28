using System;
using Project.Entities.Enums;


namespace Project.Entities
{
    public class User : Entity
    {
        private const int AuthTokenValidDays = 7;

        public string Email { get; private set; }
        public bool IsActive { get; private set; }
        public string PasswordHash { get; private set; }
        public string Name { get; private set; }
        public DateTime? LastLoginDate { get; private set; }
        public string AuthenticationToken { get; private set; }
        public DateTime? AuthenticationTokenValidTo { get; private set; }



        public static User Create(string name, string password, string email, UserStatus userStatus)
        {

            return new User
            {
                Name = name,
                IsActive = Convert.ToBoolean(userStatus),
                PasswordHash = PasswordHasher.CreateHash(password),
                Email = email,
                LastLoginDate = null,
            };

        }
    }



}
