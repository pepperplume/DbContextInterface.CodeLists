using DbContextInterface.CodeLists.Entities;
using EFCore.RepositoryPattern;
using System.Collections.Generic;

namespace DbContextInterface.CodeLists.Repositories
{
    public interface ICodeItemRepository : IRepository<CodeItem>
    {
        IEnumerable<CodeItem> GetAll(int codeListID);
        IEnumerable<CodeItem> GetAllFrozenCodes(int codeListID);
        IEnumerable<CodeItem> GetAllActiveCodes(int codeListID);
    }
}