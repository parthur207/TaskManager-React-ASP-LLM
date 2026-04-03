using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Enums;

namespace TaskManager.Core.Ports.Security
{
    public interface ICurrentUserPort
    {
        bool IsAuthenticated { get; }
        Guid UserId { get; }
        string Email { get; }
        RoleUserEnum Role { get; }
    }
}
