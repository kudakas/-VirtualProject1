using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApplication1.ServiceReferences
{
    [Table("USER_MST")]
    class UserMstEntity
    {
        // ユーザーID
        [Key]
        [Column("USER_ID")]
        public Int64 UserId { get; set; }

        // 名前
        [Column("USER_NAME")]
        public string UserName { get; set; }

        // ロール
        [Column("ROLE")]
        public Int64 Role { get; set; }

        // プロジェクト参加可否
        [Column("SANKA_KAHI")]
        public Int64 SankaKahi { get; set; }

        // 削除フラグ
        [Column("DELETE_FLG")]
        public Int64 DeleteFlg { get; set; }
    }
}
