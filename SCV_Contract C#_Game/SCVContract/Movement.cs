using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract {
    internal class Movement {
        public int X { get; set; }
        public int Y { get; set; }
        private string symbolSCV;
        private ConsoleColor ColorSCV;
        public Movement(int startX, int startY) {
            X = startX;
            Y = startY;
            symbolSCV = "¤";
            ColorSCV = ConsoleColor.Blue;
        }
        public void Draw() {
            ForegroundColor = ColorSCV;
            SetCursorPosition(X, Y);
            Write(symbolSCV);
            ResetColor();
        }
    }
}
