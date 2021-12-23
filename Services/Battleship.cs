using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class Battleship
    {
        public  List<Coordinates> fields { get; set; }

        public Battleship(List<Coordinates> fields)
        {
            this.fields = fields;
        }
    }
}
