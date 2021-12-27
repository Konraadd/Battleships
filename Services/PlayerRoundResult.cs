using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class PlayerRoundResult
    {
        public bool IsHit { get; set; }
        public Coordinates Coordinates { get; set; }

        public PlayerRoundResult(bool isHit, Coordinates coordinates)
        {
            this.IsHit = isHit;
            this.Coordinates = coordinates;
        }
    }
}
