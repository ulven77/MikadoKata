using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterCrupt
{
    public class Application
    {
        public void Leet(string message, UI ui, int customerType)
        {
            ui.SetLeeted(Leeter.Leet(message, customerType));
        }

        private static void Main(string[] args)
        {
        }
    }
}
