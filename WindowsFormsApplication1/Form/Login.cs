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
        //Process mouseTraceProcess;

        // Clipboardを常時監視する
        private MyClipboardViewer viewer;

        public Login()
        {
            InitializeComponent();

            // テキストで選択された文字列をクリップボードに保存するプロセスがない場合は
            // exeを立ち上げる
            //if (mouseTraceProcess == null || !mouseTraceProcess.HasExited)
            //{
            //    mouseTraceProcess = Process.Start(@"..\..\MouseTrace.exe");
            //}

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
                openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            }
            // DBパスのtextに表示されている場合
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
            // ダイアログでOKが押された時
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // DBパスのtextに選択したDBファイルを設定する。
                this.DBPathtextBox.Text = openFileDialog.FileName;

                //if (this.DBPathtextBox.Modified)
                //{
                    DialogResult result = MessageBox.Show("DBファイルを変更した際は再起動が必要です。再起動しますか？", "タイトル", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // app.configのData Sourceに取得したDBファイルを設定する。
                        // app.configからData Sourceの階層を取得する 
                        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
                        ConnectionStringSettings setting = settings[(settings.Count) - 1];
                        string oldRelativePath = setting.ConnectionString;

                        // 絶対パスになっているので相対パスへ変更する
                        // カレントディレクトリを取得する。
                        string stCurrentDir = System.IO.Directory.GetCurrentDirectory()+"\\";
                        Uri stCurrentDirUri = new Uri(stCurrentDir);
                        Uri dbDirUri = new Uri(this.DBPathtextBox.Text);
                        Uri relativeUri = stCurrentDirUri.MakeRelativeUri(dbDirUri);
                        string relativePath = relativeUri.ToString();
                        relativePath = relativePath.Replace('/', '\\');
                       // setting.ConnectionString.Replace(oldRelativePath, "Data Source=" + relativePath);

                        //---追加↓↓↓↓-----------------------------
                        //構成ファイルのパスを取得
                        System.Reflection.Assembly asm =
                            System.Reflection.Assembly.GetExecutingAssembly();
                        string appConfigPath;
                        //ファイル名は適当に変更してください
                        appConfigPath = System.IO.Path.GetDirectoryName(asm.Location) +
                            @"\WindowsFormsApplication1.exe.config";

                        //構成ファイルをXML DOMに読み込む
                        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                        doc.Load(appConfigPath);

                        //ノードを探す
                        foreach (System.Xml.XmlNode n in doc["configuration"]["connectionStrings"])
                        {
                            if (n.Name == "add")
                            {
                                //"key"="Application Name"のとき、"value"を変更する
                                n.Attributes.GetNamedItem("connectionString").Value = "Data Source=" + relativePath;
                            }
                        }
                        doc.Save(appConfigPath);
                        //---追加↑↑↑↑-----------------------------
                        // setting.ConnectionString ="Data Source=" + relativePath;
                        //app.configを保存する。
                        //settings.
                        // アプリを再起動する。
                        Application.Restart();
                    }else if(result == DialogResult.No){
                       this.Close();
                    }
                //}
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           // ログイン対象者の情報を取得する。
            using (var ctx = new CallEntityService())
            {
                int loginId = int.Parse(this.UserIdtextBox.Text);
                var result =
                     from p in ctx.UserMstEntities
                     where p.UserId == loginId
                     select p;
                // リスト型へ変換
                UserMstEntity[] cde = result.ToArray();

                // ロールのコードによりコンテキストメニューの内容を制御する
                if(cde[0].Role==1){
                    // ロールが管理者の場合
                    this.ContextMenuStrip = contextMenuStrip2;

                }else{
                    // ロールが一般ユーザーの場合
                    this.ContextMenuStrip = contextMenuStrip1;
                }

            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mouseTraceProcess.Kill();
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
