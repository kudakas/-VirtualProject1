using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entity
{
    [Table("WORD_DIC")]
    class WordDicEntity
    {
        public string wordId { get; set; }
        public string ronriName1 { get; set; }
        public string ronriName2 { get; set; }
        public string butsuriName { get; set; }
        public Int64 userId { get; set; }
        public string creDate { get; set; }
    }
}
