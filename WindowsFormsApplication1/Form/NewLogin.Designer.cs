namespace WindowsFormsApplication1
{
    partial class NewLogin
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
            this.UserId = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DBPath = new System.Windows.Forms.Label();
            this.DBPathTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(33, 43);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(56, 12);
            this.UserId.TabIndex = 0;
            this.UserId.Text = "ユーザーID";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(95, 40);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(293, 19);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(390, 79);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(74, 31);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "参照";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DBPath
            // 
            this.DBPath.AutoSize = true;
            this.DBPath.Location = new System.Drawing.Point(33, 88);
            this.DBPath.Name = "DBPath";
            this.DBPath.Size = new System.Drawing.Size(40, 12);
            this.DBPath.TabIndex = 3;
            this.DBPath.Text = "DBパス";
            // 
            // DBPathTextBox
            // 
            this.DBPathTextBox.Location = new System.Drawing.Point(95, 85);
            this.DBPathTextBox.Name = "DBPathTextBox";
            this.DBPathTextBox.Size = new System.Drawing.Size(293, 19);
            this.DBPathTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(188, 133);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(113, 31);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "ログイン";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 192);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DBPathTextBox);
            this.Controls.Add(this.DBPath);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserId);
            this.Name = "NewLogin";
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.NewLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label DBPath;
        private System.Windows.Forms.TextBox DBPathTextBox;
        private System.Windows.Forms.Button LoginButton;
    }
}