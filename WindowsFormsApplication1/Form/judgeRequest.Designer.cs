namespace WindowsFormsApplication1
{
    partial class judgeRequest
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
            this.InputRequestData = new System.Windows.Forms.GroupBox();
            this.RequestingWordList = new System.Windows.Forms.GroupBox();
            this.TextBoxLogicalName = new System.Windows.Forms.TextBox();
            this.TextBoxLogicalNameKana = new System.Windows.Forms.TextBox();
            this.TextBoxPhysicalName = new System.Windows.Forms.TextBox();
            this.LabelLogicalName = new System.Windows.Forms.Label();
            this.LabelLogicalNameKana = new System.Windows.Forms.Label();
            this.LabelPhysicalName = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LogicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogicalName_Kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approval = new System.Windows.Forms.Button();
            this.Rejection = new System.Windows.Forms.Button();
            this.InputRequestData.SuspendLayout();
            this.RequestingWordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputRequestData
            // 
            this.InputRequestData.Controls.Add(this.Clear);
            this.InputRequestData.Controls.Add(this.Request);
            this.InputRequestData.Controls.Add(this.LabelPhysicalName);
            this.InputRequestData.Controls.Add(this.LabelLogicalNameKana);
            this.InputRequestData.Controls.Add(this.LabelLogicalName);
            this.InputRequestData.Controls.Add(this.TextBoxPhysicalName);
            this.InputRequestData.Controls.Add(this.TextBoxLogicalNameKana);
            this.InputRequestData.Controls.Add(this.TextBoxLogicalName);
            this.InputRequestData.Location = new System.Drawing.Point(37, 21);
            this.InputRequestData.Name = "InputRequestData";
            this.InputRequestData.Size = new System.Drawing.Size(707, 110);
            this.InputRequestData.TabIndex = 0;
            this.InputRequestData.TabStop = false;
            this.InputRequestData.Text = "申請データの入力";
            // 
            // RequestingWordList
            // 
            this.RequestingWordList.Controls.Add(this.Rejection);
            this.RequestingWordList.Controls.Add(this.Approval);
            this.RequestingWordList.Controls.Add(this.dataGridView1);
            this.RequestingWordList.Location = new System.Drawing.Point(37, 137);
            this.RequestingWordList.Name = "RequestingWordList";
            this.RequestingWordList.Size = new System.Drawing.Size(707, 315);
            this.RequestingWordList.TabIndex = 1;
            this.RequestingWordList.TabStop = false;
            this.RequestingWordList.Text = "申請中の単語一覧";
            // 
            // TextBoxLogicalName
            // 
            this.TextBoxLogicalName.Location = new System.Drawing.Point(113, 24);
            this.TextBoxLogicalName.Name = "TextBoxLogicalName";
            this.TextBoxLogicalName.Size = new System.Drawing.Size(300, 19);
            this.TextBoxLogicalName.TabIndex = 0;
            // 
            // TextBoxLogicalNameKana
            // 
            this.TextBoxLogicalNameKana.Location = new System.Drawing.Point(113, 51);
            this.TextBoxLogicalNameKana.Name = "TextBoxLogicalNameKana";
            this.TextBoxLogicalNameKana.Size = new System.Drawing.Size(300, 19);
            this.TextBoxLogicalNameKana.TabIndex = 1;
            // 
            // TextBoxPhysicalName
            // 
            this.TextBoxPhysicalName.Location = new System.Drawing.Point(113, 78);
            this.TextBoxPhysicalName.Name = "TextBoxPhysicalName";
            this.TextBoxPhysicalName.Size = new System.Drawing.Size(300, 19);
            this.TextBoxPhysicalName.TabIndex = 2;
            // 
            // LabelLogicalName
            // 
            this.LabelLogicalName.AutoSize = true;
            this.LabelLogicalName.Location = new System.Drawing.Point(23, 27);
            this.LabelLogicalName.Name = "LabelLogicalName";
            this.LabelLogicalName.Size = new System.Drawing.Size(41, 12);
            this.LabelLogicalName.TabIndex = 3;
            this.LabelLogicalName.Text = "論理名";
            // 
            // LabelLogicalNameKana
            // 
            this.LabelLogicalNameKana.AutoSize = true;
            this.LabelLogicalNameKana.Location = new System.Drawing.Point(23, 54);
            this.LabelLogicalNameKana.Name = "LabelLogicalNameKana";
            this.LabelLogicalNameKana.Size = new System.Drawing.Size(69, 12);
            this.LabelLogicalNameKana.TabIndex = 4;
            this.LabelLogicalNameKana.Text = "論理名(かな)";
            // 
            // LabelPhysicalName
            // 
            this.LabelPhysicalName.AutoSize = true;
            this.LabelPhysicalName.Location = new System.Drawing.Point(23, 81);
            this.LabelPhysicalName.Name = "LabelPhysicalName";
            this.LabelPhysicalName.Size = new System.Drawing.Size(41, 12);
            this.LabelPhysicalName.TabIndex = 5;
            this.LabelPhysicalName.Text = "物理名";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(466, 28);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(78, 23);
            this.Request.TabIndex = 6;
            this.Request.Text = "申請";
            this.Request.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(466, 70);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(78, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "クリア";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.LogicalName,
            this.LogicalName_Kana,
            this.PhysicalName});
            this.dataGridView1.Location = new System.Drawing.Point(24, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(665, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "選択";
            this.Select.Name = "Select";
            this.Select.Width = 70;
            // 
            // LogicalName
            // 
            this.LogicalName.HeaderText = "論理名";
            this.LogicalName.Name = "LogicalName";
            this.LogicalName.Width = 150;
            // 
            // LogicalName_Kana
            // 
            this.LogicalName_Kana.HeaderText = "論理名(かな)";
            this.LogicalName_Kana.Name = "LogicalName_Kana";
            this.LogicalName_Kana.Width = 200;
            // 
            // PhysicalName
            // 
            this.PhysicalName.HeaderText = "物理名";
            this.PhysicalName.Name = "PhysicalName";
            this.PhysicalName.Width = 200;
            // 
            // Approval
            // 
            this.Approval.Location = new System.Drawing.Point(507, 273);
            this.Approval.Name = "Approval";
            this.Approval.Size = new System.Drawing.Size(78, 36);
            this.Approval.TabIndex = 8;
            this.Approval.Text = "承認";
            this.Approval.UseVisualStyleBackColor = true;
            // 
            // Rejection
            // 
            this.Rejection.Location = new System.Drawing.Point(611, 273);
            this.Rejection.Name = "Rejection";
            this.Rejection.Size = new System.Drawing.Size(78, 36);
            this.Rejection.TabIndex = 9;
            this.Rejection.Text = "却下";
            this.Rejection.UseVisualStyleBackColor = true;
            // 
            // judgeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 464);
            this.Controls.Add(this.RequestingWordList);
            this.Controls.Add(this.InputRequestData);
            this.Name = "judgeRequest";
            this.Text = "登録申請・承認";
            this.InputRequestData.ResumeLayout(false);
            this.InputRequestData.PerformLayout();
            this.RequestingWordList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputRequestData;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Label LabelPhysicalName;
        private System.Windows.Forms.Label LabelLogicalNameKana;
        private System.Windows.Forms.Label LabelLogicalName;
        private System.Windows.Forms.TextBox TextBoxPhysicalName;
        private System.Windows.Forms.TextBox TextBoxLogicalNameKana;
        private System.Windows.Forms.TextBox TextBoxLogicalName;
        private System.Windows.Forms.GroupBox RequestingWordList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName_Kana;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalName;
        private System.Windows.Forms.Button Rejection;
        private System.Windows.Forms.Button Approval;
    }
}