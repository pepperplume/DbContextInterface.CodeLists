using DbContextInterface.CodeLists.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbContextInterface.CodeLists
{
    public interface IUnitOfWorkCodeList
    {
        ICodeItemRepository CodeItemRepository { get; set; }
        ICodeListRepository CodeListRepository { get; set; }
    }
}
