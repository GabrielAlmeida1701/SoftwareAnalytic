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
         Type C = loop e instruções;
         Type D = loop dentro de condição;
         Type E = loop e condição;
         Type F = loop dentro de loop;
         Type G = loop dentro de loop dentro de uma condição; 
             */
        private String complexity;

        public Complexity()
        {
            complexity = "";
        }

        public String ComplexiTypeA(int ammountInst) // Quantidade de instruções
        {
            complexity = "O(" + Convert.ToString(ammountInst) + ")";

            return complexity;
        }

        public String ComplexityTypeB(int amntInstUnderCondition, int amntInstOutCondition) //quantidade de instruções dentro da condição e quantidade de instruções fora da condição
        {
            complexity = "O(" + Convert.ToString(amntInstOutCondition + amntInstUnderCondition) + ")";

            return complexity;
        }

        public String ComplexityTypeC(int amntInstOutLoop, int amntInstInLoop, int controlOfLoop)
        {
            if ((amntInstInLoop * controlOfLoop) > amntInstOutLoop)
            {
                complexity = "O(" + Convert.ToString(amntInstInLoop * controlOfLoop) + ")";
                return complexity;
            }
            else
            {
                complexity = "O(" + Convert.ToString(amntInstInLoop * controlOfLoop + amntInstOutLoop) + ")";

                return complexity;
            }
        }

        public String ComplexityTypeD(int instUnderCondition, int instUnderLoop, int controlOfLoop)
        {
            if (instUnderCondition > instUnderLoop)
            {
                complexity = "O(" + Convert.ToString(instUnderLoop * controlOfLoop + instUnderCondition) + ")";
                return complexity;
            }
            else
            {
                complexity = "O(" + Convert.ToString(instUnderLoop * controlOfLoop) + ")";

                return complexity;
            }
        }
        public String ComplexityTypeE(int controlOfLoop, int amntInstUnderLoop, int amntInstUnderCondition, int instOutConditionAndLoop)
        {
            if (instOutConditionAndLoop + amntInstUnderCondition > amntInstUnderLoop * controlOfLoop)
            {
                complexity = "O(" + Convert.ToString(instOutConditionAndLoop + amntInstUnderCondition) + ")";

                return complexity;
            }
            else
            {
                complexity = "O(" + Convert.ToString(amntInstUnderLoop * controlOfLoop) + ")";

                return complexity;
            }
        }

        public String ComplexityTypeF(int resultLoop)
        {
            complexity = "O(" + Convert.ToString(resultLoop) + ")";

            return complexity;
        }

        public String ComplexityTypeG(int resultLoop, int amntInstOutCondition)
        {
            if (resultLoop > amntInstOutCondition)
            {
                complexity = "O(" + Convert.ToString(resultLoop) + ")";

                return complexity;
            }
            else
            {
                complexity = "O(" + Convert.ToString(amntInstOutCondition + resultLoop);

                return complexity;
            }
        }
    }
}