using System;

namespace CricketSystemCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

        label:

            Console.Clear();
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\t\t           Welcome to Cricket Scoreboard System        ");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t1. Six Run \t 2. Four Run \t\t 3. Three Run \t\t 4. Two Run");
            Console.WriteLine("\t\t5. One Run \t 6. No Run \t\t 7. Catch Out \t\t 8. Run Out");
            Console.WriteLine("\t\t9. Bold Out \t 10.Wide \t\t 11. LBW \t\t 12.No Ball ");
            Console.WriteLine("\t\t13.Stumping");

            try
            {
                Console.Write("\n\nPlease Give the Input - ");
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (input)
                {
                    case 1:
                        
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    case 11:

                        break;
                    case 12:

                        break;
                    case 13:
                        break;

                    default:
                        Console.WriteLine("Wrong Input Given . Please try again");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n\nPlease Enter any key to Continue......");
            Console.ReadKey();
            goto label;
        }
    }
}

