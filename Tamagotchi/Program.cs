using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGame = new Game();
            Console.WriteLine("Wybierz swoją zabawkę 1-Pies 2-Kot");
            var myAnimal = myGame.SelectToy();
            myAnimal.DrawAnimal();
            myAnimal.DrawMeters();
            myGame.MainMenu(myAnimal);
            
        }
    }
}
