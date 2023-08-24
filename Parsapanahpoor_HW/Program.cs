using System;

namespace Parsapanahpoor_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Which project do you want !? ");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("First Project,write 1 ");//Valid Anagram
                Console.WriteLine("Second Project,write 2 ");//Add Digits
                Console.WriteLine("Third Project,write 3 ");//Ugly Number
                Console.WriteLine("the fourth Project,write 4 ");//Move Zeroes
                Console.WriteLine("the fifth Project,write 5 ");//Word Pattern
                Console.ResetColor();
                int Entekhab = Convert.ToInt32(Console.ReadLine());

                if (Entekhab == 1)
                {

                }
                else if (Entekhab == 2)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                                Here we add the digits of the numbers until they become one digit ");
                    Console.WriteLine("Enter your number: ");
                    int SumBer = Convert.ToInt32(Console.ReadLine());
                    int[] SNumber = new int[SumBer];
                    void Sumnum(int SumBer)
                    {
                        int counter = 0;
                        for (int i = SumBer; i > 0; counter++)
                        {
                            i = i / 10;
                        }
                        int Sber = 0;
                        for (int i = 0; i < counter; i++)
                        {
                            int TBer = SumBer % 10;
                            SumBer = (SumBer - TBer) / 10;
                            Sber += TBer;
                        }
                        if (Sber > 10)
                        {
                            Sumnum(Sber);
                        }
                        else
                        {
                            Console.WriteLine(Sber);
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("YOUR SUM IS : ");
                    Sumnum(SumBer);
                }
                else if (Entekhab == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ok baby here we find ugly number XD");
                    Console.WriteLine("Tell me ......... ");
                    Console.WriteLine("Whats your number : ");
                    Console.ResetColor();
                    int SNumber = Convert.ToInt32(Console.ReadLine());
                    int TBaghi = SNumber % 2;
                    int THBaghi = SNumber % 3;
                    int FIBaghi = SNumber % 5;
                    Console.BackgroundColor = ConsoleColor.Green;
                    if ((TBaghi == 0) && ((THBaghi == 0) || (FIBaghi == 0)))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Your number is UGLY");
                        Console.ResetColor();
                    }
                    else if ((THBaghi == 0) && ((TBaghi == 0) || (FIBaghi == 0)))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your number is UGLY");
                        Console.ResetColor();
                    }
                    else if ((FIBaghi == 0) && ((THBaghi == 0) || (TBaghi == 0)))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your number is UGLY");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Your Number Isn't UGLY");
                        Console.ResetColor();
                    }
                }
                else if (Entekhab == 4)
                {

                }
                else if (Entekhab == 5)
                {

                }
                else
                    Console.WriteLine("SORRY ,I cant understand what do you want");
            }
            Console.ReadKey();
        }
    }
}