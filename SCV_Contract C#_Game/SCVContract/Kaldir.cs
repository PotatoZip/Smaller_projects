﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;
using SCV_Contract;

namespace SCVContract {
    internal class Kaldir {
        private MapProperties mapFunc;
        private Movement movement;
        private ConsoleKeyInfo keyInfo;
        PlanetInfo planetInfo = new PlanetInfo();
        public bool Play() {
            planetInfo.InfoKaldir();

            string[,] mapa =
            {
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
                {"▓", " ", "▓"," ", " ", " "," ", " ", " "," ", " ", "▓"," ", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " "," ", "▓", "▓","▓", " ", " ","▓", "▓", " "," ", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", " ", "▓"," ", " ", "▓","▓", " ", " "," ", "▓", " ","▓", " ", " ", " ","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", "▓","▓", " ", "▓"," ", " ", "▓"," ", "▓", " ","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", " ", " ","▓", " ", "▓","▓", "▓", "▓"," ", "▓", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", " "," ", "▓", " ","▓", " ", "▓","▓", "▓", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", "▓", " ","▓", " ", "▓"," ", " ", " "," ", "▓", " ","▓", " ", "▓", " ","▓", "▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", " ","▓", " ", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", "▓"," ", "▓", " ","▓", " ", "▓", "*","▓", "▓", "▓"},
                {"▓", " ", " "," ", " ", " ","▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " "," ", " ", "▓"," ", "▓", " ","▓", "▓", "▓"," ", " ", "▓","▓", "▓", " ","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", " ", "▓"," ", " ", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", " "," ", " ", "▓"," ", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", " ", " ","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓"," ", "▓", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", " ","▓", " ", "▓"," ", " ", " ","▓", "▓", " "," ", " ", " "," ", " ", "▓"," ", " ", " ", " ","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", "▓"," ", "▓", "▓"," ", " ", " ","▓", "▓", "▓","▓", "▓", " ","▓", " ", "▓"," ", "▓", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", " "," ", "▓", "▓"," ", "▓", "▓","▓", "▓", " ","▓", " ", " "," ", "▓", " ","▓", " ", " "," ", "▓", "▓"," ", " ", " "," ", " ", " "," ", " ", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓"," ", "▓", "▓"," ", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓"," ", "▓", "▓"},
                {"▓", " ", "▓"," ", " ", " "," ", "▓", "▓"," ", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", " ", " ","▓", " ", " "," ", "▓", " "," ", " ", "▓"," ", " ", " ", "▓"," ", "▓", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " ", "▓"," ", "▓", "▓"},
                {"▓", " ", " "," ", " ", " "," ", "▓", "▓"," ", " ", " ","▓", "▓", "▓"," ", " ", " "," ", " ", " "," ", "▓", " "," ", " ", "▓"," ", " ", " ","▓", " ", " "," ", "▓", " ", " "," ", " ", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
            };

            mapFunc = new MapProperties(mapa);
            movement = new Movement(1,1);

            return Loop();
        }
        private bool Loop() {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (true) {
                if(watch.ElapsedMilliseconds > 60000) {
                    return false;
                }
                Thread.Sleep(30);
                ProcessInput();
                
                string coordsSCV = mapFunc.Coords(movement.X, movement.Y);
                if (coordsSCV == "*"){
                    break;
                }
                Clear();
                mapFunc.Draw();
                movement.Draw();
                Console.WriteLine("\n{0} [s]", (watch.ElapsedMilliseconds)/1000);
            }
            return true;
        }
        private void ProcessInput() {
            if (Console.KeyAvailable) {
                keyInfo = ReadKey(true);
                ConsoleKey key = keyInfo.Key;

                switch (key) {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (mapFunc.CanGo(movement.X, movement.Y - 1)) {
                            movement.Y -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (mapFunc.CanGo(movement.X, movement.Y + 1)) {
                            movement.Y += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (mapFunc.CanGo(movement.X - 1, movement.Y)) {
                            movement.X -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (mapFunc.CanGo(movement.X + 1, movement.Y)) {
                            movement.X += 1;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
 