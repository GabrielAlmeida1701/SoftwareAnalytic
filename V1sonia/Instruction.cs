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

        /*
         *AMILSON O QUE VOCE ACHA DESSA FUNÇÃO PRA ACHAR QUANTAS INSTRUÇÕES TEM EM QUALQUER LAÇO
         * O RETORNO VAI DIRETO PARA AS CLASSES DE ANÁLISE QUE FICA COM EU E O RHANYEL
         *  
        public int InstructionsInLoop(String instr)
        {
            int contInstruction = 0;

            char[] instructionInArray = instr.ToCharArray();

            for(int i = 0; i < instr.Length; i++)
            {
                if(instructionInArray[i] == '\n')
                {
                    contInstruction++;
                }
            }

            return contInstruction;
        }
         */
    }
}
