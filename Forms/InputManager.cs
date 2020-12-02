using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Utilitys;
using Withus.Views;

namespace Withus.Forms
{
    public partial class InputManager : Form, IInputManagerView
    {
        public enum InfoTypes
        {
            Gamezone,
            Today,
            Naver
        }

        MainForm main;        

        public InputManager()
        {
            InitializeComponent();
        }

        private void OutSystemMessage(string message)
        {
            main.MessageAppender(message);
        }

        private void GamezonePanel_Initialize()
        {
            panel_Gamezone.Visible = true;
            panel_Gamezone.Size = new Size(376, 99);
            panel_Gamezone.Location = new Point(14, 43);
        }
        private void NaverPanel_Initialize()
        {
            panel_Naver.Visible = true;
            panel_Naver.Size = new Size(376, 99);
            panel_Naver.Location = new Point(14, 43);
        }

        private void TodayPanel_Initialize()
        {
            panel_Today.Visible = true;
            panel_Today.Size = new Size(376, 99);
            panel_Today.Location = new Point(14, 43);
        }

        private void InputManager_Load(object sender, EventArgs e)
        {
            main = (MainForm)MdiParent;
            this.Location = new Point(195, 65);
            GamezonePanel_Initialize();
            OutSystemMessage("Password Information Is Encrypted And Used Only in Memory");
        }

        public void ManagerProcess(InfoTypes types, string account, string password)
        {
            string encryptPassword = new AES256().AESEncrypt256(password);
            switch (types)
            {
                case InfoTypes.Gamezone:
                    main.gamezoneAccount = account;
                    main.gamezonePassword = encryptPassword;
                    panel_Gamezone.Visible = false;
                    OutSystemMessage($"{main.gamezoneAccount}, {password} => {main.gamezonePassword}");
                    TodayPanel_Initialize();
                    break;
                case InfoTypes.Today:
                    main.todayAccount = account;
                    main.todayPassword = encryptPassword;
                    panel_Today.Visible = false;
                    OutSystemMessage($"{main.todayAccount}, {password} => {main.todayPassword}");
                    NaverPanel_Initialize();
                    break;
                case InfoTypes.Naver:
                    main.naverAccount = account;
                    main.naverPassword = encryptPassword;
                    OutSystemMessage($"{main.naverAccount}, {password} => {main.naverPassword}");
                    main.toolStripMenuItem_ProcessStart.Enabled = true;                          
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Exec Error");                    
                    break;
            }
        }

        public event EventHandler GameZoneCommitEvent;
        public event EventHandler TodayCommitEvent;
        public event EventHandler NaverCommitEvent;
        private void GamezoneCommit_Click(object sender, EventArgs e) => GameZoneCommitEvent.Invoke(this, new EventArgs());

        private void button_CommitNaver_Click(object sender, EventArgs e) => NaverCommitEvent.Invoke(this, new EventArgs());

        private void button_TodayCommit_Click(object sender, EventArgs e) => TodayCommitEvent.Invoke(this, new EventArgs());
    }
}
