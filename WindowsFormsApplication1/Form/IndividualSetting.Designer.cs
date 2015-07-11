namespace WindowsFormsApplication1
{
    partial class IndividualSetting
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
            this.CandidateListHotKeySetting = new System.Windows.Forms.GroupBox();
            this.DisplayRecordSetting = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TenRecord = new System.Windows.Forms.RadioButton();
            this.TwentyRecord = new System.Windows.Forms.RadioButton();
            this.ThirtyRecord = new System.Windows.Forms.RadioButton();
            this.SettingButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CandidateListHotKeySetting.SuspendLayout();
            this.DisplayRecordSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // CandidateListHotKeySetting
            // 
            this.CandidateListHotKeySetting.Controls.Add(this.textBox1);
            this.CandidateListHotKeySetting.Location = new System.Drawing.Point(23, 12);
            this.CandidateListHotKeySetting.Name = "CandidateListHotKeySetting";
            this.CandidateListHotKeySetting.Size = new System.Drawing.Size(200, 59);
            this.CandidateListHotKeySetting.TabIndex = 0;
            this.CandidateListHotKeySetting.TabStop = false;
            this.CandidateListHotKeySetting.Text = "候補一覧 ホットキー設定";
            // 
            // DisplayRecordSetting
            // 
            this.DisplayRecordSetting.Controls.Add(this.ThirtyRecord);
            this.DisplayRecordSetting.Controls.Add(this.TwentyRecord);
            this.DisplayRecordSetting.Controls.Add(this.TenRecord);
            this.DisplayRecordSetting.Location = new System.Drawing.Point(23, 77);
            this.DisplayRecordSetting.Name = "DisplayRecordSetting";
            this.DisplayRecordSetting.Size = new System.Drawing.Size(200, 48);
            this.DisplayRecordSetting.TabIndex = 1;
            this.DisplayRecordSetting.TabStop = false;
            this.DisplayRecordSetting.Text = "表示件数設定";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 19);
            this.textBox1.TabIndex = 0;
            // 
            // TenRecord
            // 
            this.TenRecord.AutoSize = true;
            this.TenRecord.Location = new System.Drawing.Point(6, 18);
            this.TenRecord.Name = "TenRecord";
            this.TenRecord.Size = new System.Drawing.Size(51, 16);
            this.TenRecord.TabIndex = 0;
            this.TenRecord.TabStop = true;
            this.TenRecord.Text = "１０件";
            this.TenRecord.UseVisualStyleBackColor = true;
            // 
            // TwentyRecord
            // 
            this.TwentyRecord.AutoSize = true;
            this.TwentyRecord.Location = new System.Drawing.Point(63, 18);
            this.TwentyRecord.Name = "TwentyRecord";
            this.TwentyRecord.Size = new System.Drawing.Size(51, 16);
            this.TwentyRecord.TabIndex = 1;
            this.TwentyRecord.TabStop = true;
            this.TwentyRecord.Text = "２０件";
            this.TwentyRecord.UseVisualStyleBackColor = true;
            // 
            // ThirtyRecord
            // 
            this.ThirtyRecord.AutoSize = true;
            this.ThirtyRecord.Location = new System.Drawing.Point(120, 18);
            this.ThirtyRecord.Name = "ThirtyRecord";
            this.ThirtyRecord.Size = new System.Drawing.Size(51, 16);
            this.ThirtyRecord.TabIndex = 2;
            this.ThirtyRecord.TabStop = true;
            this.ThirtyRecord.Text = "３０件";
            this.ThirtyRecord.UseVisualStyleBackColor = true;
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(38, 146);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(75, 28);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.Text = "設定";
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(130, 146);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(76, 28);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // IndividualSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 189);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.DisplayRecordSetting);
            this.Controls.Add(this.CandidateListHotKeySetting);
            this.Name = "IndividualSetting";
            this.Text = "個人設定";
            this.CandidateListHotKeySetting.ResumeLayout(false);
            this.CandidateListHotKeySetting.PerformLayout();
            this.DisplayRecordSetting.ResumeLayout(false);
            this.DisplayRecordSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CandidateListHotKeySetting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox DisplayRecordSetting;
        private System.Windows.Forms.RadioButton ThirtyRecord;
        private System.Windows.Forms.RadioButton TwentyRecord;
        private System.Windows.Forms.RadioButton TenRecord;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button CancelButton;

    }
}