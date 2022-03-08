using Asp.Core_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Core_Angular.Services
{
     public interface IPositionService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
