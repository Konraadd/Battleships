using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class BattleshipBot
    {
        Dictionary<char, int> fields;

        public BattleshipBot(Dictionary<char, int> fields)
        {
            this.fields = fields;
        }
    }
}
