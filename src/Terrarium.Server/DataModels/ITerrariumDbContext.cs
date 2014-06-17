using System.Linq;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public interface ITerrariumDbContext
    {
        IQueryable<RandomTip> Tips { get; }
    }
}