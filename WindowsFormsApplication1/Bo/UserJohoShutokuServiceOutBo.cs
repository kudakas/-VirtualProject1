using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Bo;

namespace WindowsFormsApplication1
{
    class UserJohoShutokuServiceOutBo : BaseBo
    {
        // ユーザーID
        private string UserId { get; set; }

        // 名前
        private string UserName { get; set; }

        // ロール
        private Int64 Role { get; set; }

        // メールID
        private string MailId { get; set; }

        // パスワード
        private string PassWord { get; set; }

        // メールアドレス
        private string MailAddress { get; set; }

        // エラーメッセージ
        private string ErrorMessage { get; set; }

    }
}
