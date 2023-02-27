using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex.BackUp
{
    internal interface IStorage
    {
        string MediaName { get; set; }
        string Model { get; set; }
        int Media { get; set; }

        void FreeMemory() { }
        void Copy() { }
        void PrintDeviceInfo() { }
    }
}
