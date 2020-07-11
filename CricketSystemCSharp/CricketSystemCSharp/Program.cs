using System;

namespace CricketSystemCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScorecardController controller = new ScorecardController();
        label:

            Console.Clear();
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\t\t           Welcome to Cricket Scoreboard System        ");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t1. Six Run \t 2. Four Run \t\t 3. Three Run \t\t 4. Two Run");
            Console.WriteLine("\t\t5. One Run \t 6. No Run \t\t 7. Catch Out \t\t 8. Run Out");
            Console.WriteLine("\t\t9. Bold Out \t 10. LBW \t\t 11. Wide  \t\t 12.No Ball ");
            Console.WriteLine("\t\t13.Stumping");

            try
            {
                Console.Write("\n\nPlease Give the Input - ");
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                

                switch (input)
                {
                    case 1:
                        controller.CalculateScorecard(6);
                        break;
                    case 2:
                        controller.CalculateScorecard(4);
                        break;
                    case 3:
                        controller.CalculateScorecard(3);
                        break;
                    case 4:
                        controller.CalculateScorecard(2);
                        break;
                    case 5:
                        controller.CalculateScorecard(1);
                        break;
                    case 6:
                        controller.CalculateScorecard(0);
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

/*
Console.WriteLine($"Commentry : {commentry} \nRun = {run}\nWicket = {wicket}");
Console.WriteLine($"Total Score : {run}/{wicket} {totalOver} Overs"); 
 
6 RUN -> WOW !!! What a Shot !! It's Maximum And Six
4 Run -> What a boundry !! It's Four , Supeeer Shot !!
3 RUN -> Quick 3 Run !! Great running Between the wickets
2 RUN -> Good Running , Hurry Up For the double and it does !!
1 RUN -> Taken a Single
0 RUN -> Good Bowling ! no Runs from that ball
Catch -> Plays a shot but Taken !! Whatta Catch !! 
Run Out -> Running between the Wicket But Run Out !
Bold -> Bold ! Stumps Flying Up !!  Whatta Delivery !
Wide -> It's a Wide !
Single & Run out -> Single Run But Run out !
No Ball -> NO ball ! Free hit !!

No ball - 3 Condition : 

1. Runout Hole Out othoba jodi noball na hoy ebong kono wicket zay taile out
2. (Jodi Noball hoy) othoba (Noball jodi thake + wide hoy) 
3. Jodi ager ball Noball na Hoy ebong ei ball Wide ba no ball na hoy taile noball false hobe

     
*/
