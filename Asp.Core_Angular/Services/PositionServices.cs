using Asp.Core_Angular.Data;
using Asp.Core_Angular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Core_Angular.Services
{
    public class PositionServices : IPositionService
    {
        private readonly FootballDbContext _context;

        public PositionServices(FootballDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _context.Positions
             .OrderBy(x => x.DispalyOrder)
             .ToListAsync();
        }
    }
}
