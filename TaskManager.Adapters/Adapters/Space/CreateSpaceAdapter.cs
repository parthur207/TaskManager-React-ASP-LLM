using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.Persistence;
using TaskManager.Core.Entities;
using TaskManager.Core.Models.Space;
using TaskManager.Core.Ports.Persistence.Space;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Adapters.Adapters.Space
{
    public class CreateSpaceAdapter : ICreateSpacePort
    {
        private readonly DbContextTaskManager _context;
        public CreateSpaceAdapter(DbContextTaskManager context)
        {
            _context = context;
        }

        public async Task<SimpleResponseModel> ExecuteAsync(SpaceEntity entity, Guid UserId)
        {
            var Response= new SimpleResponseModel();
            try
            {
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                Debug.Assert(false, ex.Message);
            }
        }
    }
}
