using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            LaserPrinter laserPrinter = new LaserPrinter("Samsung", true);
            InkjetPrinter inkjetPrinter = new InkjetPrinter("Canon", false);

            laserPrinter.Stamp = "Let's print this text!";
            laserPrinter.Print();
            laserPrinter.Scan();

            inkjetPrinter.Stamp = "Let's print this text in colors!";
            inkjetPrinter.Print();
            inkjetPrinter.Scan();
        }
    }
}
