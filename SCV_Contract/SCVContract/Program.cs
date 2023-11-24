using System;

namespace SCVContract {
    internal class Program {
        static void Main(string[] args) {
            Menu menu = new Menu();
            menu.StartGame(menu);
        }
    }
}
