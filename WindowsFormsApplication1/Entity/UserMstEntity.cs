using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entity
{
    [Table("USER_MST")]
    class UserMstEntity
    {
        public Int64 userId { get; set; }
        public string userName { get; set; }
        public string role { get; set; }
        public Int64 sankaKahi { get; set; }
    }
}
