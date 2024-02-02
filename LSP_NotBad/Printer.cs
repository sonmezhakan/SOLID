using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_NotBad
{
    public class Printer
    {
        private readonly BasePrinter _razerPrinter = new RazerPrinter();
        private readonly BasePrinter _sonyPrinter = new SonyPrinter();
        private readonly SonyPrinter _sonyPrinterScan = new SonyPrinter();

        public void Print()
        {
            _sonyPrinter.Print();
            _sonyPrinterScan.Scan();

            _razerPrinter.Print();
        }
    }
}
