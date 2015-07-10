namespace WindowsFormsApplication1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserId = new System.Windows.Forms.Label();
            this.DBPath = new System.Windows.Forms.Label();
            this.UserIdtextBox = new System.Windows.Forms.TextBox();
            this.DBPathtextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(27, 38);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(56, 12);
            this.UserId.TabIndex = 0;
            this.UserId.Text = "ユーザーID";
            // 
            // DBPath
            // 
            this.DBPath.AutoSize = true;
            this.DBPath.Location = new System.Drawing.Point(27, 84);
            this.DBPath.Name = "DBPath";
            this.DBPath.Size = new System.Drawing.Size(40, 12);
            this.DBPath.TabIndex = 1;
            this.DBPath.Text = "DBパス";
            // 
            // UserIdtextBox
            // 
            this.UserIdtextBox.Location = new System.Drawing.Point(89, 35);
            this.UserIdtextBox.Name = "UserIdtextBox";
            this.UserIdtextBox.Size = new System.Drawing.Size(154, 19);
            this.UserIdtextBox.TabIndex = 2;
            // 
            // DBPathtextBox
            // 
            this.DBPathtextBox.Location = new System.Drawing.Point(89, 81);
            this.DBPathtextBox.Name = "DBPathtextBox";
            this.DBPathtextBox.Size = new System.Drawing.Size(154, 19);
            this.DBPathtextBox.TabIndex = 3;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(249, 75);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(72, 31);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "参照";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(130, 143);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(113, 31);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "ログイン";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem,
            this.一覧ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 一覧ToolStripMenuItem
            // 
            this.一覧ToolStripMenuItem.Name = "一覧ToolStripMenuItem";
            this.一覧ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.一覧ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.一覧ToolStripMenuItem.Text = "一覧";
            this.一覧ToolStripMenuItem.Click += new System.EventHandler(this.一覧ToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 215);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DBPathtextBox);
            this.Controls.Add(this.UserIdtextBox);
            this.Controls.Add(this.DBPath);
            this.Controls.Add(this.UserId);
            this.Name = "Login";
            this.Text = "ログイン";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label DBPath;
        private System.Windows.Forms.TextBox UserIdtextBox;
        private System.Windows.Forms.TextBox DBPathtextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧ToolStripMenuItem;
    }
}