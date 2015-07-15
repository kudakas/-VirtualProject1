using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApplication1.ServiceReferences
{
    [Table("WORD_SHINSEI")]
    class WordShinseiEntity
    {
        // 申請ID
        [Key]
        [Column("SHINSEI_ID")]
        public Int64 ShinseiId { get; set; }

        // 論理名1
        [Column("RONRI_NAME1")]
        public string RonriName1 { get; set; }

        // 論理名2
        [Column("RONRI_NAME2")]
        public string RonriName2 { get; set; }

        // 物理名
        [Column("BUTSURI_NAME")]
        public string ButsuriName { get; set; }

        // 単語ID
        [Column("WORD_ID")]
        public Int64 WordId { get; set; }

        // ステータス
        [Column("STATUS")]
        public Int64 Status { get; set; }

        // ユーザID
        [Column("USER_ID")]
        public Int64 UserId { get; set; }

        // 作成日付
        [Column("CRE_DATE")]
        public string creDate { get; set; }
    }
}
