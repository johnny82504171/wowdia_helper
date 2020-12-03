using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Controllers;
using Withus.Forms;
using Withus.Utilitys;
using Withus.Views;

namespace Withus
{
    public partial class MainForm : Form, IMainView
    {
        SystemConsole systemConsole;
        InputManager inputManager;

        public bool isHelperRunning = false;
        public bool needView = false;
        public bool needView1 = false;
        public bool needView2 = false;

        public string gamezoneAccount = string.Empty;
        public string gamezonePassword = string.Empty;
        public string todayAccount = string.Empty;
        public string todayPassword = string.Empty;
        public string naverAccount = string.Empty;
        public string naverPassword = string.Empty;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            this.Text = "Test Version: 게임존,투데이(구글계정x) _ 카톡문의 : InputCode";
            Create_SystemConsole();
            Create_InputManager();
        }

        private void Create_InputManager()
        {
            inputManager = new InputManager();
            new InputManagerController(inputManager);
            inputManager.MdiParent = this;
            inputManager.Show();            
        }

        private void Create_SystemConsole()
        {
            systemConsole = new SystemConsole();
            new SystemConsoleController(systemConsole);
            systemConsole.MdiParent = this;
            systemConsole.Show();
        }

        public void MessageAppender(string message)
        {
            string strDateTime = new Commons().GetDateTime();
            systemConsole.richTextBox_SystemMessage.AppendText($"{strDateTime} - {message}\n");
            systemConsole.richTextBox_SystemMessage.ScrollToCaret();            
        }

        public void ProcessKill() => Process.GetCurrentProcess().Kill();

        private void toolStripMenuItem_ProcessKill_Click(object sender, EventArgs e) => ProcessKill();

        public event EventHandler HelperProcessStart;
        public event EventHandler HelperProcessStop;
        private void toolStripMenuItem_ProcessStart_Click(object sender, EventArgs e) => HelperProcessStart.Invoke(this, new EventArgs());

        private void toolStripMenuItem_ProcessStop_Click(object sender, EventArgs e) => HelperProcessStop.Invoke(this, new EventArgs());        
    }
}
