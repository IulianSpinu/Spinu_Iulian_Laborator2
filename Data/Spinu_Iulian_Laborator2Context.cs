using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spinu_Iulian_Laborator2.Models;

namespace Spinu_Iulian_Laborator2.Data
{
    public class Spinu_Iulian_Laborator2Context : DbContext
    {
        public Spinu_Iulian_Laborator2Context (DbContextOptions<Spinu_Iulian_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Spinu_Iulian_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Spinu_Iulian_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Spinu_Iulian_Laborator2.Models.Author>? Author { get; set; }

        public DbSet<Spinu_Iulian_Laborator2.Models.Category>? Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }
        public DbSet<Spinu_Iulian_Laborator2.Models.Member>? Member { get; set; }
        public DbSet<Spinu_Iulian_Laborator2.Models.Borrowing>? Borrowing { get; set; }

    }
}
