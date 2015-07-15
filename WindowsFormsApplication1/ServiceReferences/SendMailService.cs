using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ServiceReferences
{
    class SendMailService
    {
        // メール送信
        public void SendMail(string message)
        {
            // Configファイルの読み込み
            var conf = ReadConfig();
            var enc = Encoding.GetEncoding("shift_jis");

            using (var smtp = new SmtpClient())
            using (var msg = new MailMessage())
            {
                msg.SubjectEncoding = enc;
                msg.BodyEncoding = enc;

                // 件名
                msg.Subject = conf["subject"]
                                      + DateTime.Now.ToString("yyyyMMdd");

                // 本文
                using (var sr = new StreamReader(conf["body"], enc))
                {
                    // パラメータ（%～%）の置換
                    msg.Body = sr.ReadToEnd()
                           .Replace("%DATE%", DateTime.Now.ToString("yyyy/MM/dd"))
                           .Replace("%MESSAGE%", message);
                }

                // 差出人（From）
                msg.From = new MailAddress(conf["from"]);

                // 宛先（To）を複数登録する
                foreach (var to in conf["to"].Split(';'))
                {
                    msg.To.Add(new MailAddress(to));
                }

                // SMTPサーバの設定
                smtp.Host = conf["smtp"];
                smtp.Port = Convert.ToInt32(conf["port"]);

                // SMTP認証
                if (!String.IsNullOrEmpty(conf["user"])
                    && !String.IsNullOrEmpty(conf["pass"]))
                {
                    smtp.Credentials = new NetworkCredential(conf["user"]
                                                           , conf["pass"]);
                }
                // メール送信
                smtp.Send(msg);
            }
        }


        // Configファイルの読み込み
        private Dictionary<string, string> ReadConfig()
        {
            var configs = new Dictionary<string, string>();

            ConfigurationManager.OpenExeConfiguration(@Process.GetCurrentProcess().MainModule.FileName);

            foreach (var key in ConfigurationManager.AppSettings.AllKeys)
            {
                configs[key] = ConfigurationManager.AppSettings[key];
            }

            return configs;
        }
    }
}
