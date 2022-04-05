using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public char Symbol { get; set; }
        public int ActCount { get; set; }


        public void DisplayPlayer()
        {
            Console.WriteLine($"{DisplayName}: {Name}, Symbol: {Symbol}");
        }



    }
}
