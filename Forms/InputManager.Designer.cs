namespace Withus.Forms
{
    partial class InputManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_GameZoneAccount = new System.Windows.Forms.TextBox();
            this.panel_Gamezone = new System.Windows.Forms.Panel();
            this.button_GamezoneCommit = new System.Windows.Forms.Button();
            this.textBox_GameZonePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Naver = new System.Windows.Forms.Panel();
            this.button_CommitNaver = new System.Windows.Forms.Button();
            this.textBox_NaverPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NaverAccount = new System.Windows.Forms.TextBox();
            this.panel_Today = new System.Windows.Forms.Panel();
            this.button_TodayCommit = new System.Windows.Forms.Button();
            this.textbox_TodayPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_TodayAccount = new System.Windows.Forms.TextBox();
            this.panel_Gamezone.SuspendLayout();
            this.panel_Naver.SuspendLayout();
            this.panel_Today.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Type A : 게임존, 투데이서버, 개인 네이버 블로그, 네이버 카페 2곳";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "게임존 계정 :";
            // 
            // textbox_GameZoneAccount
            // 
            this.textbox_GameZoneAccount.Location = new System.Drawing.Point(157, 12);
            this.textbox_GameZoneAccount.Name = "textbox_GameZoneAccount";
            this.textbox_GameZoneAccount.Size = new System.Drawing.Size(151, 21);
            this.textbox_GameZoneAccount.TabIndex = 3;
            // 
            // panel_Gamezone
            // 
            this.panel_Gamezone.Controls.Add(this.button_GamezoneCommit);
            this.panel_Gamezone.Controls.Add(this.textBox_GameZonePassword);
            this.panel_Gamezone.Controls.Add(this.label2);
            this.panel_Gamezone.Controls.Add(this.label3);
            this.panel_Gamezone.Controls.Add(this.textbox_GameZoneAccount);
            this.panel_Gamezone.Location = new System.Drawing.Point(14, 43);
            this.panel_Gamezone.Name = "panel_Gamezone";
            this.panel_Gamezone.Size = new System.Drawing.Size(38, 32);
            this.panel_Gamezone.TabIndex = 4;
            this.panel_Gamezone.Visible = false;
            // 
            // button_GamezoneCommit
            // 
            this.button_GamezoneCommit.Location = new System.Drawing.Point(233, 66);
            this.button_GamezoneCommit.Name = "button_GamezoneCommit";
            this.button_GamezoneCommit.Size = new System.Drawing.Size(75, 23);
            this.button_GamezoneCommit.TabIndex = 6;
            this.button_GamezoneCommit.Text = "확인";
            this.button_GamezoneCommit.UseVisualStyleBackColor = true;
            this.button_GamezoneCommit.Click += new System.EventHandler(this.GamezoneCommit_Click);
            // 
            // textBox_GameZonePassword
            // 
            this.textBox_GameZonePassword.Location = new System.Drawing.Point(157, 39);
            this.textBox_GameZonePassword.Name = "textBox_GameZonePassword";
            this.textBox_GameZonePassword.PasswordChar = '*';
            this.textBox_GameZonePassword.Size = new System.Drawing.Size(151, 21);
            this.textBox_GameZonePassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "게임존 비밀번호 :";
            // 
            // panel_Naver
            // 
            this.panel_Naver.Controls.Add(this.button_CommitNaver);
            this.panel_Naver.Controls.Add(this.textBox_NaverPassword);
            this.panel_Naver.Controls.Add(this.label4);
            this.panel_Naver.Controls.Add(this.label5);
            this.panel_Naver.Controls.Add(this.textBox_NaverAccount);
            this.panel_Naver.Location = new System.Drawing.Point(14, 121);
            this.panel_Naver.Name = "panel_Naver";
            this.panel_Naver.Size = new System.Drawing.Size(38, 21);
            this.panel_Naver.TabIndex = 7;
            this.panel_Naver.Visible = false;
            // 
            // button_CommitNaver
            // 
            this.button_CommitNaver.Location = new System.Drawing.Point(233, 66);
            this.button_CommitNaver.Name = "button_CommitNaver";
            this.button_CommitNaver.Size = new System.Drawing.Size(75, 23);
            this.button_CommitNaver.TabIndex = 6;
            this.button_CommitNaver.Text = "확인";
            this.button_CommitNaver.UseVisualStyleBackColor = true;
            this.button_CommitNaver.Click += new System.EventHandler(this.button_CommitNaver_Click);
            // 
            // textBox_NaverPassword
            // 
            this.textBox_NaverPassword.Location = new System.Drawing.Point(157, 39);
            this.textBox_NaverPassword.Name = "textBox_NaverPassword";
            this.textBox_NaverPassword.PasswordChar = '*';
            this.textBox_NaverPassword.Size = new System.Drawing.Size(151, 21);
            this.textBox_NaverPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "네이버 비밀번호 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "네이버 계정 :";
            // 
            // textBox_NaverAccount
            // 
            this.textBox_NaverAccount.Location = new System.Drawing.Point(157, 12);
            this.textBox_NaverAccount.Name = "textBox_NaverAccount";
            this.textBox_NaverAccount.Size = new System.Drawing.Size(151, 21);
            this.textBox_NaverAccount.TabIndex = 3;
            // 
            // panel_Today
            // 
            this.panel_Today.Controls.Add(this.button_TodayCommit);
            this.panel_Today.Controls.Add(this.textbox_TodayPassword);
            this.panel_Today.Controls.Add(this.label6);
            this.panel_Today.Controls.Add(this.label7);
            this.panel_Today.Controls.Add(this.textbox_TodayAccount);
            this.panel_Today.Location = new System.Drawing.Point(90, 43);
            this.panel_Today.Name = "panel_Today";
            this.panel_Today.Size = new System.Drawing.Size(300, 106);
            this.panel_Today.TabIndex = 8;
            this.panel_Today.Visible = false;
            // 
            // button_TodayCommit
            // 
            this.button_TodayCommit.Location = new System.Drawing.Point(233, 66);
            this.button_TodayCommit.Name = "button_TodayCommit";
            this.button_TodayCommit.Size = new System.Drawing.Size(75, 23);
            this.button_TodayCommit.TabIndex = 6;
            this.button_TodayCommit.Text = "확인";
            this.button_TodayCommit.UseVisualStyleBackColor = true;
            this.button_TodayCommit.Click += new System.EventHandler(this.button_TodayCommit_Click);
            // 
            // textbox_TodayPassword
            // 
            this.textbox_TodayPassword.Location = new System.Drawing.Point(157, 39);
            this.textbox_TodayPassword.Name = "textbox_TodayPassword";
            this.textbox_TodayPassword.PasswordChar = '*';
            this.textbox_TodayPassword.Size = new System.Drawing.Size(151, 21);
            this.textbox_TodayPassword.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "투데이 비밀번호 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "투데이 계정 :";
            // 
            // textbox_TodayAccount
            // 
            this.textbox_TodayAccount.Location = new System.Drawing.Point(157, 12);
            this.textbox_TodayAccount.Name = "textbox_TodayAccount";
            this.textbox_TodayAccount.Size = new System.Drawing.Size(151, 21);
            this.textbox_TodayAccount.TabIndex = 3;
            // 
            // InputManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 154);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Today);
            this.Controls.Add(this.panel_Naver);
            this.Controls.Add(this.panel_Gamezone);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputManager";
            this.ShowIcon = false;
            this.Text = "설정";
            this.Load += new System.EventHandler(this.InputManager_Load);
            this.panel_Gamezone.ResumeLayout(false);
            this.panel_Gamezone.PerformLayout();
            this.panel_Naver.ResumeLayout(false);
            this.panel_Naver.PerformLayout();
            this.panel_Today.ResumeLayout(false);
            this.panel_Today.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Gamezone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GamezoneCommit;
        public System.Windows.Forms.TextBox textbox_GameZoneAccount;
        public System.Windows.Forms.TextBox textBox_GameZonePassword;
        private System.Windows.Forms.Panel panel_Naver;
        private System.Windows.Forms.Button button_CommitNaver;
        public System.Windows.Forms.TextBox textBox_NaverPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_NaverAccount;
        private System.Windows.Forms.Panel panel_Today;
        private System.Windows.Forms.Button button_TodayCommit;
        public System.Windows.Forms.TextBox textbox_TodayPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textbox_TodayAccount;
    }
}