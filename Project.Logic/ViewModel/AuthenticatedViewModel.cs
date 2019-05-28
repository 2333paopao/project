using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logic.ViewModel
{
    public class AuthenticatedViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string AuthenticationToken { get; set; }
        public string RoleName { get; set; }
        public Guid RoleId { get; set; }
    }
}
