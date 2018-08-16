using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(78, 50);
            GameBackground.Logo();
            GameManager.Menu();
        }
    }
}
