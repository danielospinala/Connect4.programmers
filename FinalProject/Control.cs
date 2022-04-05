using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Control : BoardConnect4
    {
        public bool myTurn { get; set; } = true;
       
        public void SetPlayerName(Player name, string PlayerName)
        {
            name.PlayerName = PlayerName;

        }
        public void SetSimbol(Player name, char simbol)
        {
            name.Simbol = simbol;
        }

        public bool changeTurn()
        {
            return !myTurn;
        }

        public void whoIsThePlayer() { 
            if(myTurn == true)
            {
                Console.WriteLine("Player 1");
            } else
            {
                Console.WriteLine("Player 2");
            }
        }

       
    }
}
