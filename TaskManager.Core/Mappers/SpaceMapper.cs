using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.DTOs;
using TaskManager.Core.Entities;
using TaskManager.Core.Models.Space;

namespace TaskManager.Adapters.Mappers
{
    public class SpaceMapper
    {

        public static SpaceEntity ModelToEntity(CreateSpaceModel model, Guid userId)
        {
            return new SpaceEntity
            {
                Name = model.Name,
                OwnerId = userId,
                Members = model.MembersEmails?.Select(email => new SpaceMemberEntity
                {
                    UserId = Guid.Empty, // Será resolvido pelo fluxo de criação, placeholder
                }).ToList() ?? new List<SpaceMemberEntity>()
            };
        }

        public static SpaceDTO EntityToDTO(SpaceEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
