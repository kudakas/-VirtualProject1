using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReferences;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        // テキストで選択された文字列をクリップボードに保存するプロセスを保存する変数
        Process mouseTraceProcess;

        // Clipboardを常時監視する
        private MyClipboardViewer viewer;

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
            // app.configからData Sourceの階層を取得する 
            ConnectionStringSettingsCollection settings =ConfigurationManager.ConnectionStrings;

           // Data Sourceの階層を取得できた場合は画面に表示する
           if (settings != null)
           {
               // Data Sourceの階層を取得する
               ConnectionStringSettings setting = settings[(settings.Count) - 1];

               // 相対パスになっているので絶対パスへ変更する
               string relativePath = setting.ConnectionString.Remove(0,12);
               string absolutePath  = System.IO.Path.GetFullPath(relativePath);
               // 画面に表示
               this.DBPathtextBox.Text = absolutePath;
           }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // OpenFileDialog1クラスを生成
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // DBパスのtextに何も表示されていなかった場合
            if (this.DBPathtextBox.Text.Length == 0)
            {
                // 現在のディレクトリが表示される
                openFileDialog.InitialDirectory = @"C:\";
            }
            // DBパスのtextに何も表示されている場合
            else
            {
                // DBパスのtextに表示されているDBファイルが表示される
                openFileDialog.FileName =
                  System.IO.Path.GetFileName(this.DBPathtextBox.Text);

                // DBパスのtextに表示されているディレクトリが表示される
                openFileDialog.InitialDirectory =
                  System.IO.Path.GetDirectoryName(this.DBPathtextBox.Text);
            }
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = @"接続するDBファイルを選択してください";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.DBPathtextBox.Text = openFileDialog.FileName;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mouseTraceProcess.Kill();
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void 一覧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show(this);
            //nextForm.Dispose();
        }

    }
}
