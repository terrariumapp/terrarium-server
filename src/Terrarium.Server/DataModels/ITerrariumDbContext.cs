using System.Linq;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public interface ITerrariumDbContext
    {
        IQueryable<RandomTip> Tips { get; }
        IQueryable<Usage> Usages { get; }
        IQueryable<Watson> Errors { get; }
        IQueryable<UserRegister> Users { get; }
        void AddError(Watson data);
        void AddUsage(Usage data);
        void AddUser(UserRegister data);
    }
}