using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex.BackUp
{
    internal class HDD : IStorage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }
        public int Media { get; set; }

        double Speed { get; set; }
        double Memory { get; set; }

        public HDD(string mediaName, string model, int media, double speed, double memory)
        {
            MediaName = mediaName;
            Model = model;
            Media = media;
            Speed = speed;
            Memory = memory;
        }
        public void FreeMemory()
        {
            Console.Clear();
            Console.WriteLine("\t\tMemory:");
            Console.WriteLine($"Remaining memory: {(float)(((Memory) * 1000) - (Media)) / 1000}GB");
        }
        public void Copy()
        {
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine("\t\t\tHDD");
            Console.WriteLine($"Name of media: {MediaName}");
            Console.WriteLine($"Size of media: {Media}mb");
            Console.WriteLine($"HDD size: {Memory}GB");
            Console.WriteLine($"Speed: {Speed} ");
            Console.WriteLine($"Remaining time: {(double)(Memory) / (Speed)} sec");
            Console.Write("Sending");
            string waiting = ".";
            for (int i = 3; i > 0; i--)
            {
                Console.Write(waiting);
                Thread.Sleep(1800);
            }
        }
        public void PrintDeviceInfo()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tDevice Information: ");
            Console.WriteLine($"Media name: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Device speed: {Speed} ");
            Console.WriteLine($"Device memory: {Memory}GB");
        }
    }
}
