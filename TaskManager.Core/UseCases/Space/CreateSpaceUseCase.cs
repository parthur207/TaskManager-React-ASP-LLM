using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.Mappers;
using TaskManager.Core.Enums;
using TaskManager.Core.Models.Space;
using TaskManager.Core.Ports.Persistence.Space;
using TaskManager.Core.Ports.Security;
using TaskManager.Core.ResposePattern;
using TaskManager.Core.UseCases.Space.Interfaces;

namespace TaskManager.Core.UseCases.Space
{
    public class CreateSpaceUseCase : ICreateSpaceUseCase
    {
        private readonly ICreateSpacePort _createSpacePort;
        private readonly ICurrentUserPort _currentUserPort;
        public CreateSpaceUseCase(ICreateSpacePort createSpacePort, ICurrentUserPort currentUserPort)
        {
            _createSpacePort = createSpacePort;
            _currentUserPort = currentUserPort;
        }

        public async Task<SimpleResponseModel> ExecuteAsync(CreateSpaceModel model)
        {
            var Response = new SimpleResponseModel();

            if (!_currentUserPort.IsAuthenticated)
            {
                Response.Message = "Operação inválida.";
                Response.Status = ResponseStatusEnum.Unauthorized;
                return Response;
            }

            var mapped= SpaceMapper.ModelToEntity(model);

            var result = await _createSpacePort.ExecuteAsync(model, _currentUserPort.UserId);
        }
    }
}
