using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        public Double Add(Double value1,Double value2)
        {
            return value1 + value2;
        }

        public Double Sub(Double value1, Double value2)
        {
            return value1 - value2;
        }

        public Double Mul(Double value1, Double value2)
        {
            return value1 * value2;
        }

        public Double Div(Double value1, Double value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("Can't divide by 0");
            }
              return value1 / value2;
            
        }
       
    }
}
