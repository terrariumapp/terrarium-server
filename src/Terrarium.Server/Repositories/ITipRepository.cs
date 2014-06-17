using Terrarium.Server.Models;

namespace Terrarium.Server.Repositories
{
    public interface ITipRepository
    {
        RandomTip GetRandomTip();
    }
}