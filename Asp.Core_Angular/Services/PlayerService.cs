using Asp.Core_Angular.Data;
using Asp.Core_Angular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Core_Angular.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly FootballDbContext _context;

        public PlayerService(FootballDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Player>> GetPlayersList()
        {
            return await _context.Players
                //.Include(x => x.Id)
                .ToListAsync();
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _context.Players
               // .Include(x => x.Id)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Player> CreatePlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }
        public async Task UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlayer(Player player)
        {
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
        }
    }
}
