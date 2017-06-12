using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tamagotchi
{
    class Animal
    {
        //public string Name { get; set; }
        public int HungerMeter { get; set; }
        public int HappyMeter { get; set; }
        public int EnergyMeter { get; set; }
        public List<string> Picture { get; set; }
        public string PicturePath { get; set; }
     

        public Animal()
        {
            HungerMeter = 10;
            HappyMeter = 10;
            EnergyMeter = 10;
            Picture = new List<string>();
            
        }

        public void DrawAnimal()
        {
            Console.Clear();
            foreach (var item in Picture)
            {
                Console.WriteLine(item);
            }
        }

        public void ReadAnimalPicFromFile()
        {
            using (var reader = new StreamReader(PicturePath))
            {
                while (!reader.EndOfStream)
                {
                    Picture.Add(reader.ReadLine());
                }
            }
        }

        public void DrawMeters()
        {
            Console.WriteLine();
            Console.WriteLine($"Poziom najedzenia : {Indicator(HungerMeter)}");
            Console.WriteLine($"Poziom szczęścia  : {Indicator(HappyMeter)}");
            Console.WriteLine($"Poziom energii    : {Indicator(EnergyMeter)}");
            Console.WriteLine();
        }

        public string Indicator(int value)
        {
            var result = "";
            for (int i = 1; i < value; i++)
            {
                result += "#";
            }
            return result;
        }

        public void Feed()
        {
            Console.WriteLine();
            Console.WriteLine("Karmienie zwierzątka (Poziom najedzenia +2, Poziom energii -1)");
            HungerMeter += 2;
            EnergyMeter--;
            Console.WriteLine();

        }

        public virtual void Play()
        {
            Console.WriteLine();
            Console.WriteLine("Zabawa ze zwierzątkiem (Poziom szczęścia +2, Poziom energii -1, Poziom najedzenia -1)");
            HungerMeter--;
            EnergyMeter--;
            HappyMeter += 2;
        }

        public void Sleep()
        {
            Console.WriteLine();
            Console.WriteLine("Zwierzątko śpi(Poziom energii +2, Poziom szczęścia +1, Poziom najedzenia -2)");
            HungerMeter -= 2;
            EnergyMeter += 2;
            HappyMeter++;
        }
    }
}
