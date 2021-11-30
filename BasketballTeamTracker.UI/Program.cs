using System;
using BasketballTeamTracker.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.UI
{
    class Program
    {
        // This is the control center..... we don't want ANY LOGIC IN HERE....
        static void Main(string[] args)
        {
            ProgramUI UI = new ProgramUI();
            UI.Run();
        }
    }
}
