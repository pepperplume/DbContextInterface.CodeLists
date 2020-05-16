using DbContextInterface.CodeLists.Entities;
using EFCore.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbContextInterface.CodeLists.Repositories
{
    public class CodeListRepository<T> : Repository<T, CodeList>, ICodeListRepository where T : DbContext
    {
        public CodeListRepository(T context) : base(context)
        {
        }
    }
}
