using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    public class Complexity
    {
        /*
         Type A = Apenas instruções;
         Type B = Condições e instruções;
         Type C = Condições, loops e instruções;
             */
        private int result;
        private String complexity;

        public Complexity()
        {
            complexity = "";
            result = 0;
        }

        public String ComplexiTypeA(int ammountInst) // Quantidade de instruções
        {
            complexity = "O(" + Convert.ToString(ammountInst) + ")";

            return complexity;
        }

        public String ComplexityTypeB(int amntInstUnderCondition, int amntInstOutCondition) //quantidade de instruções dentro da condição e quantidade de instruções fora da condição
        {
            result = amntInstOutCondition + amntInstUnderCondition;
            complexity = "O(" + Convert.ToString(result) + ")";

            return complexity;
        }

        public int ComplexityTypeC(int amntInstConditionMoreRelevant)
        {
            

            return 0;
        }
    }
}
