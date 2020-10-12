using System;

namespace Quizquiz
{
    class Program
    {
        class FireArms
        {
            public string Type { get; set; }
            public string Sound { get; set; }
            public string Round { get; set; }

            private static int Count = 0;
            public FireArms(string type, string sound, string round)
            {
                round = Round;
                type = Type;
                sound = Sound;
                Count++;
            }

            public void Fire(string type, string sound, string round)
            {
                Console.WriteLine($"I am a {type}, and I go {sound} with a {round} round, and we have {Count} firearms");
            }
        }
        public static void Main(string[] args)
        {
            FireArms P = new FireArms("pistol", "pop", "9 mm");
            P.Fire("pistol", "pop", "9 mm");

            FireArms R = new FireArms("rifle", "bang", "7.62 mm");
            R.Fire("rifle", "bang", "7.62 mm");

            FireArms S = new FireArms("shotgun", "bang", "12 gauge");
            S.Fire("shotgun", "bang", "12 gauge");
        }
    }
}
