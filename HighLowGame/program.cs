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
            game.process();
            Console.WriteLine("\t\t The Winner is "+game.getwinner());          
            Console.ReadLine();
        }
    }
}
