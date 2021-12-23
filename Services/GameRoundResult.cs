using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class GameRoundResult
    {
        public PlayerRoundResult playerRoundResult1 { get; set; }
        public PlayerRoundResult playerRoundResult2 { get; set; }
        public bool gameOver { get; set; }

        public GameRoundResult(PlayerRoundResult result1, PlayerRoundResult result2, bool gameOver)
        {
            this.playerRoundResult1 = result1;
            this.playerRoundResult2 = result2;
            this.gameOver = gameOver;
        }
    }
}
