using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Dog:Animal
    {
        public Dog()
        {
            
            PicturePath = @".\ascii\dog.txt";
            ReadAnimalPicFromFile();
        }

        public override void Play()
        {
            Console.WriteLine("Pies gryzie gumową kość. Szczęście +1. Energia -1. Najedzenie -2.");
            EnergyMeter--;
            HappyMeter++;
            HungerMeter -= 2;
        }
    }
}
