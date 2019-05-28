using System;

namespace Project.CodeSection
{
    public class LoginUserInformationForCodeSection
    {
        public Guid UserId { get; set; }
        public string LoginUserName { get; set; }
        public string LoginUserEmail { get; set; }
        public string AuthenticationToken { get; set; }
        public string RoleName { get; set; }
        public Guid RoleId { get; set; }
    }
}
