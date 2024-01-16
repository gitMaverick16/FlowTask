using FlowTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowTask.Context
{
    public class FlowTaskContext : DbContext
    {
        public FlowTaskContext(DbContextOptions<FlowTaskContext> options) : base(options)
        {
        }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Board>()
                .HasMany(x => x.Sections)
                .WithOne(x => x.Board)
                .HasForeignKey(x => x.BoardId)
                .HasPrincipalKey(x => x.Id);

            modelBuilder.Entity<Section>()
                .HasMany(x => x.Cards)
                .WithOne(x => x.Section)
                .HasForeignKey(x => x.SectionId)
                .HasPrincipalKey(x => x.Id);

            modelBuilder.Entity<Card>()
                .HasKey(x => x.Id);
        }
    }
}
