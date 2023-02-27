using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex.BackUp
{
    internal class DVD : IStorage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }
        public int Media { get; set; }

        double WriteSpeed { get; set; }
        double Memory { get; set; }

        public DVD(string mediaName, string model, int media, double writespeed, double memory)
        {
            MediaName = mediaName;
            Model = model;
            Media = media;
            WriteSpeed = writespeed;
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
            Console.WriteLine("\t\t\tDVD");
            Console.WriteLine($"Name of media: {MediaName}");
            Console.WriteLine($"Size of media: {Media}mb");
            Console.WriteLine($"DVD size: {Memory}Gb");
            Console.WriteLine($"Speed: {WriteSpeed}");
            Console.WriteLine($"Remaining time: {(double)(Memory) / (WriteSpeed)} sec");
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
            Console.WriteLine($"Device speed: {WriteSpeed}");
            Console.WriteLine($"Device memory: {Memory}GB");
        }
    }
}
