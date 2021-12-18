using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipBot
    {
        public BattleshipBoard battleshipBoard;
        public BattleshipBoard enemyBattleshipBoard;
        public ShootingBoard shootingBoard;

        public BattleshipBot()
        {
            battleshipBoard = new BattleshipBoard();
            battleshipBoard.PlaceBattleship(5);
            battleshipBoard.PlaceBattleship(4);
            battleshipBoard.PlaceBattleship(3);
            battleshipBoard.PlaceBattleship(2);
            battleshipBoard.PlaceBattleship(2);
            shootingBoard = new ShootingBoard();
        }

        public void addEnemyBoard(BattleshipBoard enemyBoard)
        {
            enemyBattleshipBoard = enemyBoard;
        }
        public void doRound()
        {
            shootingBoard.Shoot(enemyBattleshipBoard);
        }

        public bool checkWon()
        {
            if (shootingBoard.hits.Count == enemyBattleshipBoard.occupiedFields.Count)
                return true;
            else
                return false;
        }
    }
}
