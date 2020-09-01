using DbContextInterface.CodeLists.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DbContextInterface.CodeLists
{
    public interface ICodeListDbContext
    {
        DbSet<CodeItem> CodeItems { get; set; }
        DbSet<CodeList> CodeLists { get; set; }
    }
}
