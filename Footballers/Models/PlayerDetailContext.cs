using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Models
{
    public class PlayerDetailContext : DbContext
    {
        public PlayerDetailContext(DbContextOptions<PlayerDetailContext> options) : base(options)
        {

        }

        public DbSet<PlayerDetail> PlayerDetails { get; set; }
    }
}
