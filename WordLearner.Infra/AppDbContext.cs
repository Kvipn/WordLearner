using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WordLearner.Domain.Entities;

namespace WordLearner.Infra
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<Word> Words { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Настройка связи "один-ко-многим" между User и Dictionary
            builder.Entity<Dictionary>()
                .HasOne(d => d.User)
                .WithMany(u => u.Dictionaries)
                .HasForeignKey(d => d.UserId);
        }
    }
}
