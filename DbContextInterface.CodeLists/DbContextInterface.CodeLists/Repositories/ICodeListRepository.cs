using DbContextInterface.CodeLists.Entities;
using EFCore.RepositoryPattern;

namespace DbContextInterface.CodeLists.Repositories
{
    public interface ICodeListRepository : IRepository<CodeList>
    {
    }
}