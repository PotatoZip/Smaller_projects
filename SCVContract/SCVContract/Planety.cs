using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class Planety
    {
        

        public void WyborPlanety()
        {
            //Obiekty Planet
            Kaldir planetaKaldir = new Kaldir();
            Char planetaChar = new Char();
            Aiur planetaAiur = new Aiur();

            //Lista Planet do przejścia
            List<string> aktualnePlanety = new List<string>
            {
                "Char",
                "Kaldir",
                "Aiur",
            };

            //Pętla Pisząca Menu wyboru planet
            while(true)
            {
                

                Console.Clear();

                //Zakończenie gry
                if (aktualnePlanety.Count == 0)
                {
                    Console.WriteLine("Wszystkie twoje kontrakty został zrealizowane");
                    Thread.Sleep(1000);
                    Console.WriteLine("Kredyty już trafiły na twoje konto!!!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Mamy nadzieję na ponowną współpracę w przyszłości");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\n\n\nWiktor Zmiendak  2022");
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

                Console.WriteLine("Na którą planetę chciałbyś się udać?");
                Console.WriteLine("1. ---> Char\n2. --->Kaldir\n3. ---> Aiur");

                //Pętla do wyboru Planety
                while (true)
                {
                    
                    try
                    {
                        string wybor = Console.ReadLine();
                        if (wybor == "1")
                        {
                            if (aktualnePlanety.Contains("Char"))
                            {
                                if (planetaChar.Play() == true)
                                {
                                    aktualnePlanety.Remove("Char");
                                    Clear();
                                    Console.WriteLine("Udało ci się ukończyć ten poziom\nDo wykonania postały nastepujące kontrakty:");
                                    foreach (string item in aktualnePlanety)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("\nNaciśnij dowolny przycisk, aby kontynuować");
                                }
                                else
                                {
                                    Clear();
                                    Console.WriteLine("Nie udało ci się przejść poziomu, spróbuj jeszcze raz lub idź na inną planetę");
                                }
                                Console.ReadKey();
                                
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Twoja misja na tej planecie została już wykonana!");
                                break;
                            }

                        }
                        if (wybor == "2")
                        {
                            if (aktualnePlanety.Contains("Kaldir"))
                            {
                                
                                if (planetaKaldir.Play() == true)
                                {
                                    aktualnePlanety.Remove("Kaldir");
                                    Clear();
                                    Console.WriteLine("Udało ci się ukończyć ten poziom\nDo wykonania postały nastepujące kontrakty:");
                                    foreach(string item in aktualnePlanety)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("\nNaciśnij dowolny przycisk, aby kontynuować");
                                }
                                else
                                {
                                    Clear();
                                    Console.WriteLine("Nie udało ci się przejść poziomu, spróbuj jeszcze raz lub idź na inną planetę");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nNaciśnij dowolny przycisk, aby kontynuować");
                                    Console.ReadKey();
                                }
                                Console.ReadKey();
                                
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Twoja misja na tej planecie została już wykonana!");
                                break;
                            }
                        }
                        if (wybor == "3")
                        {
                            if (aktualnePlanety.Contains("Aiur"))
                            {
                                if (planetaAiur.Play() == true)
                                {
                                    aktualnePlanety.Remove("Aiur");
                                    Clear();
                                    Console.WriteLine("Udało ci się ukończyć ten poziom\nDo wykonania postały nastepujące kontrakty:");
                                    foreach (string item in aktualnePlanety)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("\nNaciśnij dowolny przycisk, aby kontynuować");
                                }
                            }
                            else
                            {
                                Clear();
                                Console.WriteLine("Twoja misja na tej planecie została już wykonana!");
                                break;
                            }
                            Console.ReadKey();
                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Błędne dane");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


                }

            }
            Console.ReadKey();



        }
        
    }
}
