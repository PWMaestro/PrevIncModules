using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public abstract class Printer
    {
        protected readonly string type;
        protected readonly bool isScanning;

        public Printer(string type, bool isScanning)
        {
            this.type = type;
            this.isScanning = isScanning;
        }
    }
}
