using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipGameManager
    {
        public BattleshipBot bot1 { get; set; }
        public BattleshipBot bot2 { get; set; }

        public int gameRound { get; set; }
        public bool gameFinished { get; set; } = false;

        public BattleshipGameManager(BattleshipBot bot1, BattleshipBot bot2)
        {
            this.bot1 = bot1;
            this.bot2 = bot2;
            bot1.addEnemyBoard(bot2.battleshipBoard);
            bot2.addEnemyBoard(bot1.battleshipBoard);
        }

        public void nextRound()
        {
            // if game isn't finished, proceed with making rounds
            if (!gameFinished)
            {
                bot1.doRound();
                bot2.doRound();
            }
            // check end of game conditions
            if (bot1.checkWon() || bot2.checkWon())
            {
                gameFinished = true;
            }
        }
    }
}
