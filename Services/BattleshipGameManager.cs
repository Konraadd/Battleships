using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipGameManager
    {
        public BattleshipBot Bot1 { get; set; }
        public BattleshipBot Bot2 { get; set; }

        public string WhoWon { get; set; } = null;

        public BattleshipGameManager(BattleshipBot bot1, BattleshipBot bot2)
        {
            this.Bot1 = bot1;
            this.Bot2 = bot2;
            Bot1.addEnemyBoard(bot2.battleshipBoard);
            Bot2.addEnemyBoard(bot1.battleshipBoard);
        }

        public GameRoundResult nextRound()
        {
            PlayerRoundResult result1 = null;
            PlayerRoundResult result2 = null;
            // if game isn't finished, proceed with making rounds
            if (WhoWon == null)
            {
                result1 = Bot1.doRound();
                result2 = Bot2.doRound();
            }
            // check end of game conditions
            if (Bot1.checkWon())
            {
                WhoWon = "BOT1";
            }
            if (Bot2.checkWon())
            {
                WhoWon = "BOT2";
            }
            return new GameRoundResult(result1, result2, WhoWon);
        }
    }
}
