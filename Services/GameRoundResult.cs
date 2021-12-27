using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class GameRoundResult
    {
        public PlayerRoundResult PlayerRoundResult1 { get; set; }
        public PlayerRoundResult PlayerRoundResult2 { get; set; }
        public string WhoWon{ get; set; }

        public GameRoundResult(PlayerRoundResult result1, PlayerRoundResult result2, string whoWon)
        {
            this.PlayerRoundResult1 = result1;
            this.PlayerRoundResult2 = result2;
            this.WhoWon = whoWon;
        }
    }
}
