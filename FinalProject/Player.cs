using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Player
    {
        public string PlayerName { get; set; }
        public char Simbol { get; set; }
       

        public void DisplayPlayer(string NumPlayer)
        {
            Console.WriteLine($"{NumPlayer}: {PlayerName}");
        }



    }
}
