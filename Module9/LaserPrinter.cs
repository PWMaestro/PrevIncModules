using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class LaserPrinter : Printer, IPrinter
    {
        public readonly string name;
        public string Stamp { get; set; }

        public LaserPrinter(string printerName, bool isScanningFunction)
            : base("Laser printer", isScanningFunction)
        {
            this.name = printerName;
        }

        public void Print() => Console.WriteLine(Stamp);

        public void Scan()
        {
            Console.WriteLine(isScanning ? "The scan is completed." : "The scan is impossible.");
        }
    }
}
