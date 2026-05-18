using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace TaskManager.API.Hubs
{
    [Authorize]
    public class TaskHub : Hub
    {
        // Cliente entra no grupo do Space ao abrir a página
        public async Task JoinSpace(string spaceId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"space-{spaceId}");
        }

        // Cliente sai do grupo ao fechar a página
        public async Task LeaveSpace(string spaceId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"space-{spaceId}");
        }
    }
}