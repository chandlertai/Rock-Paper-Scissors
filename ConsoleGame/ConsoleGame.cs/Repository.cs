using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rock.Repository
{
    public class Repository
    {
        public int computerChoice()
        {
            Random kickRocks = new Random();
            int computerRandom = kickRocks.Next(1, 3);

            //store number in variable and return
            return computerRandom;
        }
    }
}
