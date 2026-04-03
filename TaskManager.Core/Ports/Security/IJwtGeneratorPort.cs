using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Enums;

namespace TaskManager.Core.Ports.Security
{
    public interface IJwtGeneratorPort
    {
        string GenerateToken(Guid userId, string email, RoleUserEnum role);
    }
}
