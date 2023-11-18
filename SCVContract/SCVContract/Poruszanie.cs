using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class Poruszanie
    {
        //Klasa do ustawiania i rysowania SCV
        public int X { get; set; }
        public int Y { get; set; }
        private string symbolSCV;
        private ConsoleColor KolorSCV;
        public Poruszanie(int startoweX, int startoweY)
        {
            X = startoweX;
            Y = startoweY;
            symbolSCV = "¤";
            KolorSCV = ConsoleColor.Blue;
        }

        public void Rysuj()
        {
            ForegroundColor = KolorSCV;
            SetCursorPosition(X, Y);
            Write(symbolSCV);
            ResetColor();
        }
    }
}
