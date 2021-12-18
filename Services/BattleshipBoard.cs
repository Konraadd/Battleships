using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipBoard
    {
        private int boardSize = 10;

        public List<Battleship> battleships;
        public List<Coordinates> occupiedFields;

        public BattleshipBoard()
        {
            battleships = new List<Battleship>();
            occupiedFields = new List<Coordinates>();
            PlaceBattleships();
        }

        private void PlaceBattleships()
        {
            placeBattleship(5);
            placeBattleship(4);
            placeBattleship(3);
            placeBattleship(2);
            placeBattleship(2);
        }

        private void placeBattleship(int size)
        {
            Random random = new Random();

            while (true)
            {
                List<Coordinates> fields = new List<Coordinates>();
                int orientation = random.Next(0, 2);
                Coordinates coordinates = getSuitableRandomField(5, orientation);
                if (orientation == 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        fields.Add(new Coordinates(coordinates.x + i, coordinates.y));
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        fields.Add(new Coordinates(coordinates.x, coordinates.y + i));
                    }
                }

                if (!fields.Intersect(occupiedFields).Any())
                {
                    occupiedFields.AddRange(fields);
                    battleships.Add(new Battleship(fields));
                    break;
                }
            }
        }

        private Coordinates getSuitableRandomField(int shipSize, int orientation)
        {
            Random random = new Random();
            int x, y;
            if (orientation == 0)
            {
                x = random.Next(0, boardSize - shipSize);
                y = random.Next(0, boardSize);
            } 
            else
            {
                x = random.Next(0, boardSize);
                y = random.Next(0, boardSize - shipSize);
            }
            return new Coordinates(x, y);
        }
    }
}
