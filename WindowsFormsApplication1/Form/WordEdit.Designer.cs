namespace WindowsFormsApplication1
{
    partial class WordEdit
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
            this.WordSearch = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LabelPhysicalName = new System.Windows.Forms.Label();
            this.LabelLogicalNameKana = new System.Windows.Forms.Label();
            this.LabelLogicalName = new System.Windows.Forms.Label();
            this.TextBoxPhysicalName = new System.Windows.Forms.TextBox();
            this.TextBoxLogicalNameKana = new System.Windows.Forms.TextBox();
            this.TextBoxLogicalName = new System.Windows.Forms.TextBox();
            this.BulkRegist = new System.Windows.Forms.GroupBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.BrowserButton = new System.Windows.Forms.Button();
            this.FileSelectTextBox = new System.Windows.Forms.TextBox();
            this.LabelFileSelect = new System.Windows.Forms.Label();
            this.WordList = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RegistButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LogicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogicalName_Kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordSearch.SuspendLayout();
            this.BulkRegist.SuspendLayout();
            this.WordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordSearch
            // 
            this.WordSearch.Controls.Add(this.SearchButton);
            this.WordSearch.Controls.Add(this.LabelPhysicalName);
            this.WordSearch.Controls.Add(this.LabelLogicalNameKana);
            this.WordSearch.Controls.Add(this.LabelLogicalName);
            this.WordSearch.Controls.Add(this.TextBoxPhysicalName);
            this.WordSearch.Controls.Add(this.TextBoxLogicalNameKana);
            this.WordSearch.Controls.Add(this.TextBoxLogicalName);
            this.WordSearch.Location = new System.Drawing.Point(24, 13);
            this.WordSearch.Name = "WordSearch";
            this.WordSearch.Size = new System.Drawing.Size(530, 126);
            this.WordSearch.TabIndex = 0;
            this.WordSearch.TabStop = false;
            this.WordSearch.Text = "単語検索";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(435, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // LabelPhysicalName
            // 
            this.LabelPhysicalName.AutoSize = true;
            this.LabelPhysicalName.Location = new System.Drawing.Point(20, 89);
            this.LabelPhysicalName.Name = "LabelPhysicalName";
            this.LabelPhysicalName.Size = new System.Drawing.Size(41, 12);
            this.LabelPhysicalName.TabIndex = 5;
            this.LabelPhysicalName.Text = "物理名";
            // 
            // LabelLogicalNameKana
            // 
            this.LabelLogicalNameKana.AutoSize = true;
            this.LabelLogicalNameKana.Location = new System.Drawing.Point(20, 55);
            this.LabelLogicalNameKana.Name = "LabelLogicalNameKana";
            this.LabelLogicalNameKana.Size = new System.Drawing.Size(69, 12);
            this.LabelLogicalNameKana.TabIndex = 4;
            this.LabelLogicalNameKana.Text = "論理名(かな)";
            // 
            // LabelLogicalName
            // 
            this.LabelLogicalName.AutoSize = true;
            this.LabelLogicalName.Location = new System.Drawing.Point(20, 24);
            this.LabelLogicalName.Name = "LabelLogicalName";
            this.LabelLogicalName.Size = new System.Drawing.Size(41, 12);
            this.LabelLogicalName.TabIndex = 3;
            this.LabelLogicalName.Text = "論理名";
            // 
            // TextBoxPhysicalName
            // 
            this.TextBoxPhysicalName.Location = new System.Drawing.Point(96, 86);
            this.TextBoxPhysicalName.Name = "TextBoxPhysicalName";
            this.TextBoxPhysicalName.Size = new System.Drawing.Size(264, 19);
            this.TextBoxPhysicalName.TabIndex = 2;
            // 
            // TextBoxLogicalNameKana
            // 
            this.TextBoxLogicalNameKana.Location = new System.Drawing.Point(96, 52);
            this.TextBoxLogicalNameKana.Name = "TextBoxLogicalNameKana";
            this.TextBoxLogicalNameKana.Size = new System.Drawing.Size(264, 19);
            this.TextBoxLogicalNameKana.TabIndex = 1;
            // 
            // TextBoxLogicalName
            // 
            this.TextBoxLogicalName.Location = new System.Drawing.Point(96, 21);
            this.TextBoxLogicalName.Name = "TextBoxLogicalName";
            this.TextBoxLogicalName.Size = new System.Drawing.Size(264, 19);
            this.TextBoxLogicalName.TabIndex = 0;
            // 
            // BulkRegist
            // 
            this.BulkRegist.Controls.Add(this.ReadButton);
            this.BulkRegist.Controls.Add(this.BrowserButton);
            this.BulkRegist.Controls.Add(this.FileSelectTextBox);
            this.BulkRegist.Controls.Add(this.LabelFileSelect);
            this.BulkRegist.Location = new System.Drawing.Point(24, 145);
            this.BulkRegist.Name = "BulkRegist";
            this.BulkRegist.Size = new System.Drawing.Size(530, 96);
            this.BulkRegist.TabIndex = 1;
            this.BulkRegist.TabStop = false;
            this.BulkRegist.Text = "一括登録";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(435, 30);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(80, 36);
            this.ReadButton.TabIndex = 9;
            this.ReadButton.Text = "読込";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // BrowserButton
            // 
            this.BrowserButton.Location = new System.Drawing.Point(360, 35);
            this.BrowserButton.Name = "BrowserButton";
            this.BrowserButton.Size = new System.Drawing.Size(59, 27);
            this.BrowserButton.TabIndex = 8;
            this.BrowserButton.Text = "参照";
            this.BrowserButton.UseVisualStyleBackColor = true;
            // 
            // FileSelectTextBox
            // 
            this.FileSelectTextBox.Location = new System.Drawing.Point(96, 39);
            this.FileSelectTextBox.Name = "FileSelectTextBox";
            this.FileSelectTextBox.Size = new System.Drawing.Size(264, 19);
            this.FileSelectTextBox.TabIndex = 7;
            // 
            // LabelFileSelect
            // 
            this.LabelFileSelect.AutoSize = true;
            this.LabelFileSelect.Location = new System.Drawing.Point(20, 42);
            this.LabelFileSelect.Name = "LabelFileSelect";
            this.LabelFileSelect.Size = new System.Drawing.Size(63, 12);
            this.LabelFileSelect.TabIndex = 6;
            this.LabelFileSelect.Text = "ファイル指定";
            // 
            // WordList
            // 
            this.WordList.Controls.Add(this.DeleteButton);
            this.WordList.Controls.Add(this.UpdateButton);
            this.WordList.Controls.Add(this.RegistButton);
            this.WordList.Controls.Add(this.dataGridView1);
            this.WordList.Location = new System.Drawing.Point(24, 247);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(836, 265);
            this.WordList.TabIndex = 1;
            this.WordList.TabStop = false;
            this.WordList.Text = "単語一覧";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(747, 231);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 28);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(646, 231);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(80, 28);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // RegistButton
            // 
            this.RegistButton.Location = new System.Drawing.Point(543, 231);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(80, 28);
            this.RegistButton.TabIndex = 7;
            this.RegistButton.Text = "登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.LogicalName,
            this.LogicalName_Kana,
            this.PhysicalName,
            this.RegisterName});
            this.dataGridView1.Location = new System.Drawing.Point(10, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(817, 205);
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
            this.LogicalName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LogicalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // RegisterName
            // 
            this.RegisterName.HeaderText = "登録者";
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.Width = 150;
            // 
            // WordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 524);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.BulkRegist);
            this.Controls.Add(this.WordSearch);
            this.Name = "WordEdit";
            this.Text = "登録・更新・削除";
            this.WordSearch.ResumeLayout(false);
            this.WordSearch.PerformLayout();
            this.BulkRegist.ResumeLayout(false);
            this.BulkRegist.PerformLayout();
            this.WordList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WordSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LabelPhysicalName;
        private System.Windows.Forms.Label LabelLogicalNameKana;
        private System.Windows.Forms.Label LabelLogicalName;
        private System.Windows.Forms.TextBox TextBoxPhysicalName;
        private System.Windows.Forms.TextBox TextBoxLogicalNameKana;
        private System.Windows.Forms.TextBox TextBoxLogicalName;
        private System.Windows.Forms.GroupBox BulkRegist;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button BrowserButton;
        private System.Windows.Forms.TextBox FileSelectTextBox;
        private System.Windows.Forms.Label LabelFileSelect;
        private System.Windows.Forms.GroupBox WordList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName_Kana;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterName;
    }
}