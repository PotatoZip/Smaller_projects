using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV_Contract {
    internal class ConsoleManager {
        public static char ReadCharAt(int x, int y) {
            Console.SetCursorPosition(x, y);
            return Console.ReadKey().KeyChar;
        }

        public static void SetCharAt(char c, int x, int y) {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
