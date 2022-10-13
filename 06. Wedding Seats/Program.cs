using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sector = char.Parse(Console.ReadLine());
            var redoveSectorA = int.Parse(Console.ReadLine());
            var mestaNechetenRed = int.Parse(Console.ReadLine());
            var count = 0;
            for (int sektor = 'A'; sektor <= sector; sektor++)
            {
                for (int red = 1; red <= redoveSectorA; red++)
                { //да напиша редовете че се качват с 1 
                    if (red % 2 != 0)
                    {
                        for (char mqsto = 'a'; mqsto < 'a' +mestaNechetenRed; mqsto++)
                        {
                            Console.WriteLine($"{(char)sektor}{red}{mqsto}");
                            count++;
                        }
                    }
                    else
                    {
                        for (char mqsto = 'a'; mqsto < 'a' + mestaNechetenRed +2; mqsto++)
                        {
                            Console.WriteLine($"{(char)sektor}{red}{mqsto}");
                            count++;
                        }

                    }
                }
                redoveSectorA++;
            }
            Console.WriteLine(count);






        }
    }
}
