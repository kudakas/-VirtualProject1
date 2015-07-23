using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReferences;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class NewLogin : Form
    {
        // Clipboardを常時監視する
        private MyClipboardViewer viewer;

        public NewLogin()
        {
            InitializeComponent();
        }

        private void NewLogin_Load(object sender, EventArgs e)
        {
            // app.configからData Sourceの階層を取得する 
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            // app.configへアクセスできる場合
            if (settings != null)
            {
                // Data Sourceの階層を取得する
                ConnectionStringSettings setting = settings[(settings.Count) - 1];

                // 相対パスになっているので絶対パスへ変更する
                string relativePath = setting.ConnectionString.Remove(0, 12);
                string absolutePath = System.IO.Path.GetFullPath(relativePath);
                // 画面に表示
                this.DBPathTextBox.Text = absolutePath;
            }
            else
            // app.configへアクセスできない場合
            {
                // メッセージダイアログを表示。
                DialogResult result =　MessageBox.Show("設定ファイルが存在しません。");
                // OKボタンを押下された場合
                if (result == DialogResult.OK)
                {
                    // ダイアログとログイン画面を閉じ、処理を終了する。
                    Application.Exit();
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // OpenFileDialog1クラスを生成
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // DBパスのtextに何も表示されていなかった場合
            if (this.DBPathTextBox.Text.Length == 0)
            {
                // C直下のディレクトリが表示される
                openFileDialog.InitialDirectory = @"C:\";
            }
            // DBパスのtextに表示されている場合
            else
            {
                // [画面項目].[DBパス]に入力されたディレクトリが存在するかを判定する。
                if (File.Exists(this.DBPathTextBox.Text))
                {
                    // DBパスのtextに表示されているDBファイルが表示される
                    openFileDialog.FileName =
                      System.IO.Path.GetFileName(this.DBPathTextBox.Text);

                    // DBパスのtextに表示されているディレクトリが表示される
                    openFileDialog.InitialDirectory =
                      System.IO.Path.GetDirectoryName(this.DBPathTextBox.Text);
                }
                else
                // ディレクトリが存在しない場合
                {
                    // C直下のディレクトリが表示される
                    openFileDialog.InitialDirectory = @"C:\";
                }
            }
            openFileDialog.Title = @"接続するDBファイルを選択してください";
            // ダイアログでOKが押された時
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // DBパスのtextに選択したDBファイルを設定する。
                this.DBPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //エラーメッセージを格納する変数を宣言する。
            string MSG_E = null;

            // 入力チェック(存在チェック)　ログイン画面の入力項目に対して入力確認を行う。
            // [画面項目].[ユーザID]に入力がされていない場合
            if(this.UserIdTextBox.Text == ""){
                MSG_E = "ユーザーIDを入力してください。";
                MessageBox.Show(MSG_E);
                return;
            }

            // [画面項目].[DBパス]に入力がされていない場合
            if (this.DBPathTextBox.Text == "")
            {
                MSG_E = "DBパスを入力してください。";
                MessageBox.Show(MSG_E);
                return;
            }

            // 入力チェック(単項目チェック)[画面項目].[ユーザID]への入力文字種別が下記の入力規則に沿うか判定を行う。
            // [画面項目].[ユーザID]に半角英数字または半角記号以外が入力されている場合
            if (!Regex.IsMatch(this.DBPathTextBox.Text, "^[a-zA-Z0-9!-/:-@¥[-`{-~]+$"))
            {
                MSG_E = "ユーザIDには半角英数字または半角記号を入力してください。";
                MessageBox.Show(MSG_E);
                return;
            }

            // ユーザ情報取得サービス呼び出し
            // 下記の受け渡し情報をもとにユーザ情報取得サービスを呼び出す。



        }
    }
}
