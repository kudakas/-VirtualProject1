﻿using System;
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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }


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

                    using (var ctx = new dbconnect())
                    {
                        sample sample = new sample
                        {
                            Name = "やまのは",
                            Age = 10,
                        };
                        ctx.abc.Add(sample);
                        int recordAffected = ctx.SaveChanges();

          
                        ctx.SaveChanges();

                    }

                    // 登録メッセージを表示
                    MessageBox.Show("ﾄｳﾛｸﾃﾞｷﾀ━━━━(　´∀｀)━━━━!!!!");
                //}
            //}
        }
 
        // データの取得
        private void get_Click(object sender, EventArgs e) {

            using (var ctx = new dbconnect())
            {
                sample[] abc = ctx.abc.Where(x => x.Age == 70).ToArray();


            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
