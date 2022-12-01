using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Core.Utilities
{
    public static class ConsoleUtility
    {
      
        public static void WriteLine(string message)
        {
            Debug.WriteLine(message);
            Console.WriteLine(message);
        }
    }
}
