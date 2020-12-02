using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Withus.Views
{
    interface IInputManagerView
    {
        event EventHandler GameZoneCommitEvent;
        event EventHandler NaverCommitEvent;
        event EventHandler TodayCommitEvent;

    }
}
