using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Game
    {
        public Game()
        {

        }

        public Animal SelectToy()
        {
            do
            {

                var option = 0;
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        return new Dog(); 
                    case 2:  
                        return new Cat();
                    default:
                        Console.WriteLine("Wybierz 1 lub 2");
                        break;
                }
            } while (true);
        }

        public void MainMenu(Animal myAnimal)
        {
            do
            {
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1 - Karmienie");
                Console.WriteLine("2 - Zabawa");
                Console.WriteLine("3 - Sen");
                Console.WriteLine("4 - Koniec gry");
                var option = 0;
                int.TryParse(Console.ReadLine(), out option);
                
                if (option == 4)
                {
                    break;
                }

                switch (option)
                {
                    case 1:
                        Redraw(myAnimal);
                        myAnimal.Feed();
                        ContinuePrompt();
                        break;
                    case 2:
                        Redraw(myAnimal);
                        myAnimal.Play();
                        ContinuePrompt();
                        break;
                    case 3:
                        Redraw(myAnimal);
                        myAnimal.Sleep();
                        ContinuePrompt();
                        break;
                    default:
                        break;
                }
                
                Redraw(myAnimal);

            } while (true);
        }

        public void Redraw(Animal myAnimal)
        {
            Console.Clear();
            myAnimal.DrawAnimal();
            myAnimal.DrawMeters();
        }

        public void ContinuePrompt()
        {
            Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować");
            Console.ReadKey();
        }
    }
}
