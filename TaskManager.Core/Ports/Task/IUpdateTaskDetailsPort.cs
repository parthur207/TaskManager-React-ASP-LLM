using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Core.Ports.Task
{
    public interface IUpdateTaskDetailsPort
    {

        Task<SimpleResponseModel> Execute(TaskEntity entity);
    }
}
