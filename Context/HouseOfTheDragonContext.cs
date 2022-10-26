using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using house_of_the_dragon_api.models;

namespace house_of_the_dragon_api.Context
{
    public class HouseOfTheDragonContext : DbContext
    {
        public HouseOfTheDragonContext(DbContextOptions<HouseOfTheDragonContext> options) : base(options)
        {
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Dragon> Dragons { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCharacter> BooksCaracters { get; set; }

    }
}