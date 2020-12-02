namespace Withus.Forms
{
    partial class SystemConsole
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
            this.richTextBox_SystemMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_SystemMessage
            // 
            this.richTextBox_SystemMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_SystemMessage.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_SystemMessage.Name = "richTextBox_SystemMessage";
            this.richTextBox_SystemMessage.ReadOnly = true;
            this.richTextBox_SystemMessage.Size = new System.Drawing.Size(494, 82);
            this.richTextBox_SystemMessage.TabIndex = 0;
            this.richTextBox_SystemMessage.TabStop = false;
            this.richTextBox_SystemMessage.Text = "";
            // 
            // SystemConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 82);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox_SystemMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemConsole";
            this.ShowIcon = false;
            this.Text = "시스템 메세지";
            this.Load += new System.EventHandler(this.SystemConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox_SystemMessage;
    }
}