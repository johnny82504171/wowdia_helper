namespace Withus
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ProcessStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ProcessStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ProcessKill = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프로그램ToolStripMenuItem
            // 
            this.프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ProcessStart,
            this.toolStripMenuItem_ProcessStop,
            this.toolStripMenuItem_ProcessKill});
            this.프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            this.프로그램ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.프로그램ToolStripMenuItem.Text = "프로그램";
            // 
            // toolStripMenuItem_ProcessStart
            // 
            this.toolStripMenuItem_ProcessStart.Enabled = false;
            this.toolStripMenuItem_ProcessStart.Name = "toolStripMenuItem_ProcessStart";
            this.toolStripMenuItem_ProcessStart.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem_ProcessStart.Text = "프로세스 시작";
            this.toolStripMenuItem_ProcessStart.Click += new System.EventHandler(this.toolStripMenuItem_ProcessStart_Click);
            // 
            // toolStripMenuItem_ProcessStop
            // 
            this.toolStripMenuItem_ProcessStop.Enabled = false;
            this.toolStripMenuItem_ProcessStop.Name = "toolStripMenuItem_ProcessStop";
            this.toolStripMenuItem_ProcessStop.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem_ProcessStop.Text = "프로세스 중단";
            this.toolStripMenuItem_ProcessStop.Click += new System.EventHandler(this.toolStripMenuItem_ProcessStop_Click);
            // 
            // toolStripMenuItem_ProcessKill
            // 
            this.toolStripMenuItem_ProcessKill.Name = "toolStripMenuItem_ProcessKill";
            this.toolStripMenuItem_ProcessKill.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem_ProcessKill.Text = "프로그램 종료";
            this.toolStripMenuItem_ProcessKill.Click += new System.EventHandler(this.toolStripMenuItem_ProcessKill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "테스트 버전이며, 사용자 pc 상태들을 감안하여 액션마다 딜레이 시간이 조금 있습니다.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ProcessStart;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ProcessStop;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ProcessKill;
        private System.Windows.Forms.Label label1;
    }
}

