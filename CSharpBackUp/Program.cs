using ex.BackUp;

Flash flash = new("Flash", "USB", 512, 700, 32);

HDD hdd = new("HDD", "Toshiba", 645, 500, 64);

DVD dvd = new("DVD", "Sony", 65, 600, 8);

flash.Copy();
flash.PrintDeviceInfo();
flash.FreeMemory();


Console.WriteLine("Press any key for next....");
Console.ReadKey();

hdd.Copy();
hdd.PrintDeviceInfo();
hdd.FreeMemory();

Console.WriteLine("Press any key for next....");
Console.ReadKey();

dvd.Copy();
dvd.PrintDeviceInfo();
dvd.FreeMemory();