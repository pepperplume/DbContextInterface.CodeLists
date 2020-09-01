using DbContextInterface.CodeLists.Entities;
using EF.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbContextInterface.CodeLists.Repositories
{
    public class CodeItemRepository<T> : Repository<T, CodeItem>, ICodeItemRepository where T : DbContext, ICodeListDbContext
    {
        public CodeItemRepository(T context) : base(context)
        {
        }

        public IEnumerable<CodeItem> GetAll(int codeListID)
        {
            return _Context.CodeItems
                .Where(c => c.CodeListID == codeListID)
                .ToList();
        }

        public IEnumerable<CodeItem> GetAllActiveCodes(int codeListID)
        {
            return _Context.CodeItems
                .Where(c => c.CodeListID == codeListID)
                .Where(c => c.IsCodeFrozen == false)
                .ToList();
        }

        public IEnumerable<CodeItem> GetAllFrozenCodes(int codeListID)
        {
            return _Context.CodeItems
                .Where(c => c.CodeListID == codeListID)
                .Where(c => c.IsCodeFrozen == true)
                .ToList();
        }
    }
}
