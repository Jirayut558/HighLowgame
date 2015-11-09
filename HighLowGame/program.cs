using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class program
    {
        static void Main(string[] args)
        {
            Competition game = new Competition();
            game.start();

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
