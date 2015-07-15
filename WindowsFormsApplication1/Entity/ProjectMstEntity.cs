using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApplication1.ServiceReferences
{
    [Table("PROJECT_MST")]
    class ProjectMstEntity
    {
        // プロジェクト名
        [Key]
        [Column("PROJECT_NAME")]
        public string ProjectName { get; set; }

        // メールアドレス
        [Column("MAIL_ADDRESS")]
        public string MailAddress { get; set; }
    }
}
