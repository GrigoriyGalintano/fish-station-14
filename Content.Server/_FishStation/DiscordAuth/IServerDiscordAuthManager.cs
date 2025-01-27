using System.Threading;
using System.Threading.Tasks;
using Content.Corvax.Interfaces.Shared;
using Content.Server._FishStation.DiscordAuth;
using Robust.Server.Player;
using Robust.Shared.Network;
using Robust.Shared.Player;

namespace Content._FishStation.DiscordAuth;

public interface IServerDiscordAuthManager : ISharedDiscordAuthManager
{
    public event EventHandler<ICommonSession>? PlayerVerified;
    public Task<DiscordAuthManager.DiscordGenerateLinkResponse> GenerateAuthLink(NetUserId userId, CancellationToken cancel);
    public Task<bool> IsVerified(NetUserId userId, CancellationToken cancel);
}
