using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Withus.Views
{
    interface IMainView
    {
        event EventHandler HelperProcessStart;
        event EventHandler HelperProcessStop;
    }
}
