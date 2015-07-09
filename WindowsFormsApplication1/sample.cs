using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Table("sample")]
    class sample
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public Int64 Age { get; set; }
    }
}
