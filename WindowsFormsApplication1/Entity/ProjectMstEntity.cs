using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entity
{
    [Table("PROJECT_MST")]
    class ProjectMstEntity
    {
        public string projectName { get; set; }
        public string mailAddress { get; set; }
    }
}
