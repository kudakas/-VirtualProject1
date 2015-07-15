using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using WindowsFormsApplication1.ServiceReferences;
using WindowsFormsApplication1.ServiceReferences;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MyClipboardViewer viewer;
        public Process mouseTraceProcess;
        //-------------追加↓↓↓-----------------------------
            private int    WM_SYSCOMMAND = 0x112;
            private IntPtr SC_MINIMIZE   = (IntPtr)0xF020;
            //const int MOD_ALT = 0x0001; 
            const int MOD_CONTROL = 0x0002;
            //const int MOD_SHIFT = 0x0004; 
            const int MOD_WIN = 0x0008;
            const int WM_HOTKEY = 786;
            private int HOTKEY_ID = 786; 


            [DllImport("user32.dll")]
            extern static int RegisterHotKey(IntPtr HWnd, int ID, int MOD_KEY, int KEY);

            [DllImport("user32.dll")]
            extern static int UnregisterHotKey(IntPtr HWnd, int ID); 
        //-------------追加↑↑↑-----------------------------

        public Form1()
        {

            if (mouseTraceProcess == null || !mouseTraceProcess.HasExited)
            {
                mouseTraceProcess = Process.Start(@"..\..\MouseTrace.exe");
            }

            // イベントハンドラを登録
            viewer = new MyClipboardViewer(this);
            viewer.ClipboardHandler += this.OnClipBoardChanged;
            InitializeComponent();

            ShowInTaskbar = false;
            //WindowState = FormWindowState.Normal;
        }

        // クリップボードにテキストがコピーされると呼び出される
        private void OnClipBoardChanged(object sender, ClipboardEventArgs args)
        {
            this.textBox1.Text = args.Text;
        }

        //-------------追加↓↓↓-----------------------------
        protected override void WndProc(ref Message m)
        {
            //最小化されたときにフォームを非表示にする 
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam == SC_MINIMIZE))
            {
                this.Hide();
            }
            //上記以外はデフォルトの処理をおこなう 
            else
            {
                base.WndProc(ref m);

                RegisterHotKey(this.Handle, WM_HOTKEY, MOD_CONTROL | MOD_WIN, (int)Keys.T);

                if (m.Msg == WM_HOTKEY)
                {
                    if ((int)m.WParam == HOTKEY_ID)
                    {
                        //ホットキーが押されたときの処理 
                        Console.WriteLine("HOTキーが押されました");

                        this.Show();
                        this.Activate();
                    }
                }
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //タスクトレイのアイコンダブルクリックでフォームを表示、アクティブ化 
            this.Show();
            this.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //フォームを閉じる時、タスクトレイに表示されている場合は閉じずに非表示 
            if (notifyIcon1.Visible)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            終了ToolStripMenuItem_Click(sender, e);

        }

        //NotifyIconのコンテキストメニューに追加した「終了」メニュークリックイベント 
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NotifyIconのコンテキストメニューで閉じるメニューを実行した場合 
            //NotifyIconを非表示にしてアプリケーションを終了する 
            notifyIcon1.Visible = false;
            Application.Exit();
        }
        //-------------追加↑↑↑-----------------------------

        // データ接続
        private void connect_Click(object sender, EventArgs e) {
            string dbConnectionString = "Data Source=C:\\sqLite\\sample.db";
            using (SQLiteConnection cn = new SQLiteConnection(dbConnectionString)) {
                try {
                    cn.Open();
                    MessageBox.Show("ヽ( ´ー｀)ノつながった～", "タイトル", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message, "タイトル", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
 
        // データの追加
        private void regist_Click(object sender, EventArgs e) {

                    using (var db = new CallEntityService())
                    {
                        var q =
                        from s in db.UserMstEntities
                        where s.UserId == 1
                        select s;

                        UserMstEntity[] a = q.ToArray();

          
                        //db.SaveChanges();

                    }

                    // 登録メッセージを表示
                    MessageBox.Show("ﾄｳﾛｸﾃﾞｷﾀ━━━━(　´∀｀)━━━━!!!!");
                //}
            //}
        }
 
        // データの取得
        private void get_Click(object sender, EventArgs e) {

            using (var ctx = new CallEntityService())
            {
                //sample[] abc = ctx.abc.Where(x => x.Age == 70).ToArray();


            }
        }
    }
}

