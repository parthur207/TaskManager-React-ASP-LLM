using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Core.Ports.TaskCategory
{
    public interface IUpdateTaskCategoryPort
    {
        Task<SimpleResponseModel> ExecuteAsync();
    }
}
