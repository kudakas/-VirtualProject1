using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Mutexクラスの作成
            //"MyName"の部分を適当な文字列に変えてください
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "MyName");
            //ミューテックスの所有権を要求する
            if (mutex.WaitOne(0, false) == false)
            {
                //すでに起動していると判断して終了
                MessageBox.Show("多重起動はできません。");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //ミューテックスを解放する
            mutex.ReleaseMutex();

        }
    }
}
