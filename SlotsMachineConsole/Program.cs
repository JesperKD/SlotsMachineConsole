using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            bool gamedone = false;
            while(gamedone == false)
            {
                logic.Pull();
            }
        }
    }
}
