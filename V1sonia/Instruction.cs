using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class Instruction
    {
        // ex: P = X * Y;
        // ex: J = seila(); 
        public String inst;

        public Instruction(String i)
        {
            inst = i;
        }
    }
}
