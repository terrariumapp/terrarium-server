using System;
using System.Linq;
using Terrarium.Server.DataModels;
using Terrarium.Server.Models;

namespace Terrarium.Server.Repositories
{
    public class TipRepository : ITipRepository
    {
        private readonly ITerrariumDbContext _context;

        public TipRepository(ITerrariumDbContext context)
        {
            _context = context;
        }

        public RandomTip GetRandomTip()
        {
            return !_context.Tips.Any() ? new RandomTip { Tip = "No tips in database yet!" } : _context.Tips.OrderBy(x => Guid.NewGuid()).Take(1).First();
        }
    }
}