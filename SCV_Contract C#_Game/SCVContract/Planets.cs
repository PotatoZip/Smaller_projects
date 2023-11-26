using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract {
    internal class Planets {
        public void SelectPlanet() {
        
            Kaldir kaldirPlanet = new Kaldir();
            Char charPlanet = new Char();
            Aiur aiurPlanet = new Aiur();
            Menu menu = new Menu();

            List<string> missionsList = new List<string> {
                "Char",
                "Kaldir",
                "Aiur",
            };

            while (true) {            
                Console.Clear();

                if (missionsList.Count == 0) {
                    menu.TypeText("All of your missions have been completed\n");
                    Thread.Sleep(1000);
                    menu.TypeText("Credits will be send to your account!!!\n");
                    Thread.Sleep(1000);
                    menu.TypeText("We wish we will meet again some sunny day\n");
                    Thread.Sleep(2000);
                    menu.TypeText("... or not");
                    break;
                }

                Console.WriteLine(@"    ███▓▓████		$$$$$$\  $$\							
  ██▓▓▓▓▓▓▓████		$$  __$$\ $$ |						
 ██▓▓▓▓▓▓███████	$$ /  \__|$$$$$$$\   $$$$$$\   $$$$$$\			
 ███▓▓▓▓▓▓███▓██ 	$$ |      $$  __$$\  \____$$\ $$  __$$\		
 ██▓▓▓▓█████████	$$ |      $$ |  $$ | $$$$$$$ |$$ |  \__|		
  ███▓▓████████		$$ |  $$\ $$ |  $$ |$$  __$$ |$$ |    			
    █████████		\$$$$$$  |$$ |  $$ |\$$$$$$$ |$$ |     		
				     	
    ███▓▓████		$$\   $$\          $$\       $$\ $$\           
  ██▓▓▓▓▓▓▓████		$$ | $$  |         $$ |      $$ |\__|          
 ██▓▓▓▓▓▓███████	$$ |$$  / $$$$$$\  $$ | $$$$$$$ |$$\  $$$$$$\  
 ███▓▓▓▓▓▓███▓██	$$$$$  /  \____$$\ $$ |$$  __$$ |$$ |$$  __$$\ 
 ██▓▓▓▓█████████	$$  $$<   $$$$$$$ |$$ |$$ /  $$ |$$ |$$ |  \__|
  ███▓▓████████		$$ |\$$\ $$  __$$ |$$ |$$ |  $$ |$$ |$$ |      
    █████████		$$ | \$$\\$$$$$$$ |$$ |\$$$$$$$ |$$ |$$ |      
				         
    ███▓▓████		$$$$$$\  $$\							
  ██▓▓▓▓▓▓▓████		$$  __$$\ \__|						
 ██▓▓▓▓▓▓███████	$$ /  $$ |$$\ $$\   $$\  $$$$$$\			
 ███▓▓▓▓▓▓███▓██	$$$$$$$$ |$$ |$$ |  $$ |$$  __$$\			
 ██▓▓▓▓█████████	$$  __$$ |$$ |$$ |  $$ |$$ |  \__|			
  ███▓▓████████		$$ |  $$ |$$ |$$ |  $$ |$$ |      			
    █████████		$$ |  $$ |$$ |\$$$$$$  |$$ |      			
				     			
                ");
                Console.WriteLine("Please select the mission:");
                Console.WriteLine("[1] ---> Char\n[2] ---> Kaldir\n[3] ---> Aiur");

                while (true) {
                    try {
                            string ans = Console.ReadLine();
                            if (ans == "1") {
                                if (missionsList.Contains("Char")) {
                                    if (charPlanet.Play() == true) {
                                        missionsList.Remove("Char");
                                        Clear();
                                        menu.TypeText("* Mission Complete *\n\n\nLeft to do:");
                                        foreach (string item in missionsList) {
                                            Console.WriteLine(item);
                                        }
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    else {
                                        Clear();
                                        menu.TypeText("* Mission fail *\nTry again or select other mission");
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    Console.ReadKey();
                                    break;
                                }
                                else {
                                    Console.WriteLine("Already done!");
                                    break;
                                }

                            }
                            if (ans == "2") {
                                if (missionsList.Contains("Kaldir")) {
                                    if (kaldirPlanet.Play() == true) {
                                        missionsList.Remove("Kaldir");
                                        Clear();
                                        menu.TypeText("* Mission Complete *\n\n\nLeft to do:");
                                        foreach (string item in missionsList) {
                                            Console.WriteLine(item);
                                        }
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    else {
                                        Clear();
                                        menu.TypeText("* Mission fail *\nTry again or select other mission");
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    Console.ReadKey();
                                    break;
                                }
                                else {
                                    Console.WriteLine("Already done!");
                                    break;
                                }
                            }
                            if (ans == "3") {
                                if (missionsList.Contains("Aiur")) {
                                    if (aiurPlanet.Play() == true) {
                                        missionsList.Remove("Aiur");
                                        Clear();
                                        menu.TypeText("* Mission Complete *\n\n\nLeft to do:");
                                        foreach (string item in missionsList) {
                                            Console.WriteLine(item);
                                        }
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    else {
                                        Clear();
                                        menu.TypeText("* Mission fail *\nTry again or select other mission");
                                        Console.WriteLine("\n\nPress any key to continue ...");
                                    }
                                    Console.ReadKey();
                                    break;
                                }
                                else {
                                    Console.WriteLine("Already done!");
                                    break;
                                }
                            }
                            else {
                                Console.WriteLine("Wrong input!");
                            }
                        }
                        catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
