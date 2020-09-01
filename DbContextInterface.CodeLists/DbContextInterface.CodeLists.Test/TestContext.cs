using DbContextInterface.CodeLists;
using DbContextInterface.CodeLists.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbContextInterface.CodeLists.Test
{
    public class TestContext : DbContext, ICodeListDbContext
    {
        public DbSet<CodeItem> CodeItems { get; set; }
        public DbSet<CodeList> CodeLists { get; set; }

        public TestContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("test");
        }
    }
}
