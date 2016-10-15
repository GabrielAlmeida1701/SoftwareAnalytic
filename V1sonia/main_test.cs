using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class main_test
    {
        public static void Main()
        {
            AlgorithmAnalysis teste1 = new AlgorithmAnalysis();
            Console.WriteLine("Iniciando verificacao... ");
            teste1.VerifyAlgorithm(teste1.core.mainBlock);
            Console.WriteLine("\n Numero de instrucoes total: " + teste1.nInstrTotal.ToString());
            Console.WriteLine("\nMAX (BlockID) = " + (teste1.GetBlockMaxComplexity()).id); //pega bloco de complexidade maxima do main
            Console.WriteLine();
            Console.Read();
        }
    }
}
