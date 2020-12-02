using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Forms;
using Withus.Views;

namespace Withus.Controllers
{
    class InputManagerController
    {
        IInputManagerView inputManagerView { get; set; }
        InputManager inputManager;        

        public InputManagerController(IInputManagerView inputManagerView)
        {
            this.inputManagerView = inputManagerView;
            inputManager = (InputManager)inputManagerView;
            inputManagerView.GameZoneCommitEvent += GamezoneProcess;
            inputManagerView.NaverCommitEvent += NaverProcess;
            inputManagerView.TodayCommitEvent += TodayProcess;
        }

        private void TodayProcess(object sender, EventArgs e)
        {
            //TODO textbox_TodayAccount
            string account = inputManager.textbox_TodayAccount.Text;
            string password = inputManager.textbox_TodayPassword.Text;

            bool result = InputValid(account, password);
            if (result)
            {
                inputManager.ManagerProcess(InputManager.InfoTypes.Today, account, password);
            }
            else
            {
                MessageBox.Show("Input Data Error");
                return;
            }

        }
        private void NaverProcess(object sender, EventArgs e)
        {
            string account = inputManager.textBox_NaverAccount.Text;
            string password = inputManager.textBox_NaverPassword.Text;

            bool result = InputValid(account, password);
            if (result)
            {
                inputManager.ManagerProcess(InputManager.InfoTypes.Naver, account, password);
            }
            else
            {
                MessageBox.Show("Input Data Error");
                return;
            }
        }


        private void GamezoneProcess(object sender, EventArgs e)
        {
            string account = inputManager.textbox_GameZoneAccount.Text;
            string password = inputManager.textBox_GameZonePassword.Text;
            bool result = InputValid(account, password);
            if (result)
            {
                inputManager.ManagerProcess(InputManager.InfoTypes.Gamezone, account, password);
            }
            else
            {
                MessageBox.Show("Input Data Error");
                return;
            }
        }

        private bool InputValid(string account, string password)
        {
            if (!string.IsNullOrWhiteSpace(account) && !string.IsNullOrWhiteSpace(password))
            {
                if (account.Contains(" ") || account.Length < 4 || password.Length <= 4) return false;
                else return true;                
            }
            else return false;
        }
    }
}
