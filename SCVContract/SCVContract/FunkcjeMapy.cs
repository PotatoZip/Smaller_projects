using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class FunkcjeMapy
    {
        //Klasa do rysowania mapy
        private string[,] Mapa;
        private int Rows;
        private int Cols;

        public string Koordynaty(int x, int y)
        {
            return Mapa[y, x];
        }

        public FunkcjeMapy(string[,] mapa)
        {
            Mapa = mapa;
            Rows = Mapa.GetLength(0);
            Cols = Mapa.GetLength(1);
        }

        //Rysuje podaną mapę
        public void Rysuj()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Mapa[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
        }
        //Sprawdza czy ruch jest możliwy
        public bool czyWolnoIsc(int x, int y)
        {
            if(x <0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }
            return Mapa[y, x] == " " || Mapa[y, x] == "*" || Mapa[y, x] == "h" || Mapa[y, x] == "j" || Mapa[y, x] == "b" || Mapa[y, x] == "q" || Mapa[y, x] == "z" || Mapa[y, x] == "w" || Mapa[y, x] == "p" || Mapa[y, x] == "u" || Mapa[y, x] == "f" || Mapa[y, x] == "g" || Mapa[y, x] == "d" || Mapa[y, x] == "l" || Mapa[y, x] == "r" || Mapa[y, x] == "e" || Mapa[y, x] == "s" || Mapa[y, x] == "k" || Mapa[y, x] == "y" || Mapa[y, x] == "i" || Mapa[y, x] == "m" || Mapa[y, x] == "v" || Mapa[y, x] == "n" || Mapa[y,x] == "t";

        }
    }
}
