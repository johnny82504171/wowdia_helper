using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Controllers;
using Withus.Utilitys;
using Withus.Views;

namespace Withus.Forms
{
    public partial class SystemConsole : Form, ISystemConsoleView
    {
        public SystemConsole()
        {
            InitializeComponent();
        }        

        private void OutSystemMessage(string message)
        {
            MainForm main = (MainForm)MdiParent;
            main.MessageAppender(message);
        }

        private void SystemConsole_Load(object sender, EventArgs e)
        {            
            this.Location = new Point(0, 383);
            OutSystemMessage("SystemConsole Initialized");
        }         
    }
}
