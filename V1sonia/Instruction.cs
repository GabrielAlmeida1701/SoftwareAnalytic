using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    public class Instruction
    {
        // ex: P = X * Y;
        // ex: J = seila(); 
        public String inst;
        public Block block; //Bloco aonde esta instrução está
        public int id;

        public Instruction()
        {
        }

        public Instruction(String i)
        {
            inst = i;
        }

        public void Set(String i)
        {
            inst = i;
        }

        public Block getParent() { return block; }
    }
}
