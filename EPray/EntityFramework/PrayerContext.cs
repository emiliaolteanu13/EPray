using EPray.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.EntityFramework
{
    public class PrayerContext : DbContext
    {
        public PrayerContext()
        {

        }
        public PrayerContext(DbContextOptions<PrayerContext> options): base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PrayerModel> Prayers { get; set; }
    }
}
