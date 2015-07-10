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
        Process mouseTraceProcess;

        public Login()
        {
            InitializeComponent();

            if (mouseTraceProcess == null || !mouseTraceProcess.HasExited)
            {
                mouseTraceProcess = Process.Start(@"..\..\MouseTrace.exe");
            }

            ShowInTaskbar = false;
            WindowState = FormWindowState.Normal;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
