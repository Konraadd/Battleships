using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class ShootingBoard
    {
        private int boardSize = 10;

        public List<Coordinates> availableSpots { get; set; }
        public List<Coordinates> hits { get; set; }
        public List<Coordinates> misses { get; set; }


        public ShootingBoard()
        {
            availableSpots = new List<Coordinates>();
            for (int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 10; j++)
                {
                    availableSpots.Add(new Coordinates(i, j));
                }
            }
            hits = new List<Coordinates>();
            misses = new List<Coordinates>();
        }

        /// <summary>
        /// Shoots a random available spot, if it hits adds it to list of hits
        /// otherwise adds it to list of misses
        /// </summary>
        /// <returns></returns>
        public void Shoot(BattleshipBoard battleshipBoard)
        {
            Random random = new Random();
            int index = random.Next(availableSpots.Count);
            Coordinates spot = availableSpots.ElementAt(index);
            if (battleshipBoard.occupiedFields.Contains(spot))
            {
                availableSpots.Remove(spot);
                hits.Add(spot);
            } 
            else
            {
                availableSpots.Remove(spot);
                misses.Add(spot);
            }     
        }
    }
}
