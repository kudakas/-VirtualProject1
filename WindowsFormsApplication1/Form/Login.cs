using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        // テキストで選択された文字列をクリップボードに保存するプロセスを保存する変数
        Process mouseTraceProcess;

        public Login()
        {
            InitializeComponent();

            // テキストで選択された文字列をクリップボードに保存するプロセスがない場合は
            // exeを立ち上げる
            if (mouseTraceProcess == null || !mouseTraceProcess.HasExited)
            {
                mouseTraceProcess = Process.Start(@"..\..\MouseTrace.exe");
            }

            // タスクバーへ表示しない
            ShowInTaskbar = false;
            // ウィンドウのサイズはノーマルにする
            WindowState = FormWindowState.Normal;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            // メール通知メソッド
            SendMailService service = new SendMailService();
            service.SendMail("Hello World!!");
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mouseTraceProcess.Kill();
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Q)) { }

            return true;
        }

        private void 一覧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show(this);
            //nextForm.Dispose();
        }

    }
}
