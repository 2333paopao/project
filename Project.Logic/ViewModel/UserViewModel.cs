using System;

namespace Project.Logic.ViewModel
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string TeamName { get; set; }
        public string TeamId { get; set; }
    }
}
