using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class PlayerRoundResult
    {
        public bool isHit { get; set; }
        public Coordinates coordinates { get; set; }

        public PlayerRoundResult(bool isHit, Coordinates coordinates)
        {
            this.isHit = isHit;
            this.coordinates = coordinates;
        }
    }
}
