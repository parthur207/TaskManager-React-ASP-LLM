using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Ports.ReadServices
{
    public interface ISpaceMembershipPort
    {
        Task<bool> IsUserMemberAsync(Guid userId, Guid spaceId);

    }
}
