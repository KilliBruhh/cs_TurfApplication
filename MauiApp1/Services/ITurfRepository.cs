using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal interface ITurfRepository
    {
        Task<bool> AddUpdateTurfAsync(TurfInfo turf);
        Task<bool> DeleteTurfAsync(int id);
        Task<TurfInfo> GetTurfAsync(int id);
        Task<IEnumerable<TurfInfo>> GetTurfAsync();
    }
}
