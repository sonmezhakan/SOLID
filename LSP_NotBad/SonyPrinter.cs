using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_NotBad
{
    public class SonyPrinter : BasePrinter, IScan
    {
        public override void Print()
        {
            //Sony Printer
        }

        public void Scan()
        {
            //Sony Scan
        }
    }
}
