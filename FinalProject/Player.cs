using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public abstract class Gamer
    {
        public abstract void DisplayPlayer();
    }
    class Player:Gamer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public char Symbol { get; set; }
        public int ActCount { get; set; }


        public override void DisplayPlayer()
        {
            Console.WriteLine($"{DisplayName}: {Name}, Symbol: {Symbol}");
        }



    }
}
