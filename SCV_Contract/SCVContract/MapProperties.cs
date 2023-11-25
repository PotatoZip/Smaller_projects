using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract {
    internal class MapProperties {

        private string[,] mapp;
        private int rows;
        private int cols;
        public string Coords(int x, int y) {
            return mapp[y, x];
        }
        public MapProperties(string[,] map) {
            mapp = map;
            rows = mapp.GetLength(0);
            cols = mapp.GetLength(1);
        }
        public void Draw() {
            for (int y = 0; y < rows; y++) {
                for (int x = 0; x < cols; x++) {
                    string element = mapp[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
        }
        public bool CanGo(int x, int y) {
            if(x <0 || y < 0 || x >= cols || y >= rows) {
                return false;
            }
            return mapp[y, x] == " " || mapp[y, x] == "*" || mapp[y, x] == "h" || mapp[y, x] == "j" || mapp[y, x] == "b" || mapp[y, x] == "q" || mapp[y, x] == "z" || mapp[y, x] == "w" || mapp[y, x] == "p" || mapp[y, x] == "u" || mapp[y, x] == "f" || mapp[y, x] == "g" || mapp[y, x] == "d" || mapp[y, x] == "l" || mapp[y, x] == "r" || mapp[y, x] == "e" || mapp[y, x] == "s" || mapp[y, x] == "k" || mapp[y, x] == "y" || mapp[y, x] == "i" || mapp[y, x] == "m" || mapp[y, x] == "v" || mapp[y, x] == "n" || mapp[y,x] == "t";
        }
    }
}
