using DbContextInterface.CodeLists.Entities;
using EF.RepositoryPattern;

namespace DbContextInterface.CodeLists.Repositories
{
    public interface ICodeListRepository : IRepository<CodeList>
    {
    }
}