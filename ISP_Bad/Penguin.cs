using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bad
{
    public class Penguin : IBird
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            //Eagle Walk
        }
    }
}
