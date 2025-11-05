using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaIPT101Solution.MacayaFramework.DTOs;

namespace MacayaIPT101Solution.MacayaFramework
{
    public class YouTubeViewersDbContext : DbContext
    {
        public YouTubeViewersDbContext(DbContextOptions options) : base(options) { }

        public DbSet<YouTubeViewerDto> YouTubeViewers { get; set; }
    }
}
