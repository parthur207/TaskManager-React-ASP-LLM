using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.Persistence;
using TaskManager.Core.Entities;
using TaskManager.Core.Enums;
using TaskManager.Core.Ports.ReadServices;
using TaskManager.Core.ResposePattern;
using TaskManager.Core.ValueObjects;

namespace TaskManager.Adapters.Adapters.ReadServices
{
    public class UserQueryAdapter : IUserQueryPort
    {
        private readonly DbContextTaskManager _context;
        public UserQueryAdapter(DbContextTaskManager context)
        {
            _context = context;
        }

        public async Task<ResponseModel<UserEntity?>> GetByEmailAsync(string email)
        {
            var Response = new ResponseModel<UserEntity?>();
            try
            {

                if (string.IsNullOrWhiteSpace(email)) 
                {
                    Response.Status = ResponseStatusEnum.Error;
                    Response.Message = "O email é obrigatório.";
                    return Response;
                }
                var emailVo = new EmailVO(email);

                var user= await _context.User.Where(x=>x.Status.Equals(UserStatusEnum.Active))
                    .FirstOrDefaultAsync(u => u.Email == emailVo);

                if (user is null)
                {
                    Response.Status= ResponseStatusEnum.NotFound;
                    Response.Message = "Nenhum usuario encontrado com o email informado.";
                    return Response;
                }

                Response.Status = ResponseStatusEnum.Success;
                Response.Content = user;
            }
            catch (Exception ex)
            {

            }
            return Response;
        }
    }
}
