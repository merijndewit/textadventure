using System;

namespace Zuul
{
    class Program
    {
        /**
		 * Create and play the Game.
		 */
        public static void Main(string[] args)
        {
            Game game = new Game();
            Player player = new Player();
            Items items = new Items();
            Inventory inventory = new Inventory();
            game.play();

            // close the window with 'enter'
            Console.ReadLine();
        }
    }
}
