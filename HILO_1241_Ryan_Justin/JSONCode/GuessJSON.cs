using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONCode
{
    public class GuessJSON
    {
        public enum GuessResponse
        {
            Low = -1,
            Correct = 0,
            High = 1,
            BadJSON = -2
        }
        public int guess { get; set; }
        public int response { get; set; }

    }
}
