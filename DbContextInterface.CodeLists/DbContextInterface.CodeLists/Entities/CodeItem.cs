using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbContextInterface.CodeLists.Entities
{
    public class CodeItem
    {
        public int CodeItemID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string UserCreate { get; set; }
        public string? UserLastEdit { get; set; }
        public string? UserRemoved { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public DateTime? DateTimeLastEdit { get; set; }
        public DateTime? DateTimeRemoved { get; set; }
        public bool IsCodeFrozen { get; set; }

        public int CodeListID { get; set; }
        [ForeignKey("CodeListID")]
        public CodeList CodeList { get; set; }
    }
}
