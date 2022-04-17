using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
     class Control : BoardConnect4
    {
              
        public void SetPlayerInfo(Player objPlayer,int ID, string Name ,string DisplayName, char PlayerSymbol)
        {
            objPlayer.ID = ID;
            objPlayer.DisplayName = DisplayName;
            objPlayer.Name = Name;
            objPlayer.Symbol = PlayerSymbol;
        }
       
    }
}
