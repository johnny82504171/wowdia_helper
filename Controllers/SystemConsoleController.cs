using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Withus.Views;

namespace Withus.Controllers
{    
    class SystemConsoleController
    {
        ISystemConsoleView systemConsoleView { get; set; }

        public SystemConsoleController(ISystemConsoleView systemConsoleView)
        {
            this.systemConsoleView = systemConsoleView;            
        }
    }
}
