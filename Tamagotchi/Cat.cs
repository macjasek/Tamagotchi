using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Cat:Animal
    {

        public Cat()
        {
            
            PicturePath = @".\ascii\cat.txt";
            ReadAnimalPicFromFile();
            
        }

        public override void Play()
        {
            Console.WriteLine("Kot bawi się piłeczką. Szczęście +2, Energia -2, Najedzenie -1");
            HappyMeter += 2;
            EnergyMeter -= 2;
            HungerMeter--;
            
        }

        
    }
}
