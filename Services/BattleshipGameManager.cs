using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipGameManager
    {
        public BattleshipBot bot1;
        public BattleshipBot bot2;

        public int gameRound;
        private bool gameFinished = false;

        public BattleshipGameManager()
        {
            bot1 = new BattleshipBot();
            bot2 = new BattleshipBot();
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
