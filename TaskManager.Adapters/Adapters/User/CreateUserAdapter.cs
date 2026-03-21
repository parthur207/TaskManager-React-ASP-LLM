using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Ports.User;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Adapters.Persistence.User
{
    internal class CreateUserAdapter : ICreateUserPort
    {
        public async Task<SimpleResponseModel> ExecuteAsync(UserEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
