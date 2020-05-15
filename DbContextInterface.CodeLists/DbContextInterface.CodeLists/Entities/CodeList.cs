using System;
using System.Collections.Generic;
using System.Text;

namespace DbContextInterface.CodeLists.Entities
{
    public class CodeList
    {
        public int CodeListID { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }

        public ICollection<CodeItem> CodeItems { get; set; }

        public CodeList()
        {
            CodeItems = new List<CodeItem>();
        }
    }
}
