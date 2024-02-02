using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Bad
{
    public class Logger
    {
        private readonly DatabaseLog _databaseLog= new DatabaseLog();

        public void Log()
        {
            _databaseLog.Log();
        }
    }
}
