using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipGameManager
    {
        public BattleshipBot Bot1;
        public BattleshipBot Bot2;
        public BattleshipBoard Board1;
        public BattleshipBoard Board2;

        public int gameRound;

        public BattleshipGameManager()
        {
            Board1 = new BattleshipBoard();
            //Bot1 = new BattleshipBot();
            Board2 = new BattleshipBoard();
            //Board1 = new BattleshipBoard();
            //Board2 = new BattleshipBoard();
        }
    }
}
