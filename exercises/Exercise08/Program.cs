using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Thousand = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                Thousand.Add(i);
            }
            Console.WriteLine($"For Player Guess select (1), For Computer Guess select (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Guess Iplay = new Player();
                Iplay.HighLow(Thousand);
            }
            else if (select == 2)
            {
                Guess Uplay = new computer();
                Uplay.HighLow(Thousand);
            }
        }
    }

    interface Guess
    {
        void HighLow(List<int> Thousand);
    }
    class Player : Guess
    {
        void Guess.HighLow(List<int> Thousand)
        {
            int repeat = 0;
            Random No = new Random();
            int ComGuess = No.Next(Thousand.Count);
            Console.WriteLine($"Enter a number between 1 - {Thousand.Count}");
            int PGuess = int.Parse(Console.ReadLine());

            while (PGuess != ComGuess)
            {
                if (PGuess < ComGuess)
                {
                    Console.WriteLine($"{PGuess} Too Low...Guess Again!");
                    PGuess = int.Parse(Console.ReadLine());
                }
                else if (PGuess > ComGuess)
                {
                    Console.WriteLine($"{PGuess} Too High...Guess Again!");
                    PGuess = int.Parse(Console.ReadLine());
                }
                repeat++;
            }
            if (PGuess == ComGuess)
            {
                Console.WriteLine($"{PGuess} Congratulations...You Guessed Correctly!");
                Console.WriteLine($"It took you {repeat + 1 } Guesses");
            }
        }
    }
    class computer : Guess
{
    void Guess.HighLow(List<int> Thousand)
    {
        Console.WriteLine("Select a number from 1 - 1000 and let the Computer Guess it: ");
        int CG = Thousand[(Thousand.Count - 1) / 2];
        int min = 1;
        int max = 1000;
        int count = 0;

        while (true)
        {
            count++;
            Console.WriteLine($"Enter (1) if Too Low, (2) if Too High, or (3) if Correct");
            Console.WriteLine($"Computer guessed {CG}. Is that correct?");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                min = CG;
                CG += (max - CG) / 2;
            }
            else if (input == 2)
            {
                max = CG;
                CG -= (CG - min) / 2;
            }
            else if (input == 3)
            {
                Console.WriteLine($"It took the Computer {count} Guesses to guess your Number");
                break;
            }
        }
    }
}

