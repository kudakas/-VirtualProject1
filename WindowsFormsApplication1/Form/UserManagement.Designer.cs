namespace WindowsFormsApplication1
{
    partial class UserManagement
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
            this.UserInfo = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PjSankaKahi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Authority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.dataGridView1);
            this.UserInfo.Location = new System.Drawing.Point(12, 12);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(664, 272);
            this.UserInfo.TabIndex = 0;
            this.UserInfo.TabStop = false;
            this.UserInfo.Text = "ユーザー情報";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(610, 290);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(66, 24);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "実行";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.UserID,
            this.UserName,
            this.PjSankaKahi,
            this.Authority});
            this.dataGridView1.Location = new System.Drawing.Point(26, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(613, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "編集";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 70;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "ユーザーID";
            this.UserID.Name = "UserID";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "ユーザー名";
            this.UserName.Name = "UserName";
            this.UserName.Width = 200;
            // 
            // PjSankaKahi
            // 
            this.PjSankaKahi.HeaderText = "PJ参加可否";
            this.PjSankaKahi.Name = "PjSankaKahi";
            this.PjSankaKahi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PjSankaKahi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Authority
            // 
            this.Authority.HeaderText = "権限";
            this.Authority.Items.AddRange(new object[] {
            "管理者",
            "一般"});
            this.Authority.Name = "Authority";
            this.Authority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Authority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 324);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.UserInfo);
            this.Name = "UserManagement";
            this.Text = "ユーザー管理";
            this.UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PjSankaKahi;
        private System.Windows.Forms.DataGridViewComboBoxColumn Authority;
    }
}