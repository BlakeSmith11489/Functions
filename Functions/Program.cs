using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Below code says make new object from the Game class template
            Game game = new Game();
            // Below says I want to use the Start() function inside my instance of the Game class
            game.Start();
        }
    }
}
