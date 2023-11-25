using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract {
    internal class Char {
        private MapProperties mapFunc;
        private Movement movement;
        PlanetInfo planetInfo = new PlanetInfo();
        public bool Play() {
            planetInfo.InfoChar();

            string[,] mapa =
            {
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓","q", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", "▓", "▓","▓", "▓", "▓","*", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","p", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", " ", "w","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓"," ", " ", " "," ", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "h", "▓","z", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "y", " ","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "i", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "u", "▓","f", " ", " "," ", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ", " "," ", " ", "▓"},
               {"▓", " ", " ","b", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " "," ", " ", "▓","▓", "▓", "▓","t", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "▓", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " ", " ","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "g", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " "," ", "▓", "▓", "v","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", " "," ", " ", " "," ", " ", "▓"," ", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", "▓", "▓", "▓","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " ","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", " "," ", "▓", " ", " "," ", " ", "▓"},
               {"▓", " ", " "," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", "e", " ","▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", "▓", "▓"," ", "▓", " ", "▓","▓", "▓", "▓"},
               {"▓", "j", " "," ", "▓", "d","▓", "l", "▓","▓", "r", "▓","▓", "▓", " "," ", " ", "▓","▓", "▓", "▓","▓", "s", "▓"," ", " ", " ","▓", " ", " "," ", "k", "▓","m", "▓", " ", " "," ", "n", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
            };
            
            
            mapFunc = new MapProperties(mapa);
            movement = new Movement(1, 1);

            return Loop();
            Clear();
            Console.WriteLine("You nailed it!");
            Console.ReadKey();
        }
        private bool Loop() {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (true) {
                if (watch.ElapsedMilliseconds > 1200000000) {
                    return false;
                }
                Clear();
                mapFunc.Draw();
                movement.Draw();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                switch (key) {
                    case ConsoleKey.UpArrow:
                        if (mapFunc.CanGo(movement.X, movement.Y - 1)) {
                            movement.Y -= 1;
                        }
                        break;
                    case ConsoleKey.W:
                        if (mapFunc.CanGo(movement.X, movement.Y - 1)) {
                            movement.Y -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (mapFunc.CanGo(movement.X, movement.Y + 1)) {
                            movement.Y += 1;
                        }
                        break;
                    case ConsoleKey.S:
                        if (mapFunc.CanGo(movement.X, movement.Y + 1)) {
                            movement.Y += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (mapFunc.CanGo(movement.X - 1, movement.Y)) {
                            movement.X -= 1;
                        }
                        break;
                    case ConsoleKey.A:
                        if (mapFunc.CanGo(movement.X - 1, movement.Y)) {
                            movement.X -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (mapFunc.CanGo(movement.X + 1, movement.Y)) {
                            movement.X += 1;
                        }
                        break;
                    case ConsoleKey.D:
                        if (mapFunc.CanGo(movement.X + 1, movement.Y)) {
                            movement.X += 1;
                        }
                        break;
                    default:
                        break;
                };

                string coordsSCV = mapFunc.Coords(movement.X, movement.Y);
                if (coordsSCV == "h") {
                    movement.X = 1;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "j") {
                    movement.X = 1;
                    movement.Y = 4;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "b") {
                    movement.X = 3;
                    movement.Y = 1;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "q") {
                    movement.X = 3;
                    movement.Y = 11;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "w") {
                    movement.X = 8;
                    movement.Y = 12;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "g") {
                    movement.X = 4;
                    movement.Y = 3;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "z"){
                    movement.X = 37;
                    movement.Y = 16;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "n") {
                    movement.X = 3;
                    movement.Y = 4;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "v") {
                    movement.X = 34;
                    movement.Y = 6;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "i") {
                    movement.X = 36;
                    movement.Y = 11;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "m") {
                    movement.X = 13;
                    movement.Y = 9;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "u") {
                    movement.X = 33;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "p") {
                    movement.X = 22;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "s") {
                    movement.X = 15;
                    movement.Y = 3;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "t") {
                    movement.X = 10;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "r") {
                    movement.X = 27;
                    movement.Y = 11;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "e") {
                    movement.X = 5;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "d") {
                    movement.X = 14;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "l") {
                    movement.X = 31;
                    movement.Y = 4;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "y") {
                    movement.X = 7;
                    movement.Y = 15;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "k") {
                    movement.X = 16;
                    movement.Y = 8;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "f") {
                    movement.X = 30;
                    movement.Y = 16;
                    Clear();
                    mapFunc.Draw();
                    movement.Draw();
                }
                if (coordsSCV == "*") {
                    break;
                }
                Thread.Sleep(30);
            }
            return true;
        }
    }
}
