using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Bad
{
    public class Printer
    {
        private readonly BasePrinter _sonyPrinter = new SonyPrinter();
        private readonly BasePrinter _razorPrinter = new RazerPrinter();

        public void Print()
        {
            _razorPrinter.Printer();
            _razorPrinter.Scan();//Error

            _sonyPrinter.Printer();
            _sonyPrinter.Scan();
        }
    }
}
