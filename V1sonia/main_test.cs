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
            Console.WriteLine();
            Console.Read();

            /*
            Core core = new Core();

            core.CreateMainBlock();
            Block loop1 = core.CreateLoopBlock(BlockType.ENQUANTO, core.mainBlock, 15);
            Instruction inst = new Instruction("a = b + c");
            Instruction inst2 = new Instruction("b = b + a");
            loop1.AddInstruction(inst); 
            loop1.AddInstruction(inst2);

            Block cond1 = core.CreateBlock(BlockType.SE, loop1);
            cond1.AddInstruction(inst);

            //Show
            Console.WriteLine("[INICIO]");
            var loopBlocks = core.GetLoopBlocks();
            if (loopBlocks.Count > 0)
            {
                foreach(Block b in loopBlocks)
                {
                    Console.WriteLine("\t[ENQUANTO {0}]", b.GetLoopItSize());
                    foreach(Block b2 in b.GetChildBlocks())
                    {
                        //...
                        if(b2.type == BlockType.SE || b2.type == BlockType.SE_NAO)
                        {
                            Console.WriteLine("\t\t[BLOCO DE CONDICAO]");
                            foreach (Instruction instr in b2.GetInstructions())
                            {
                                Console.WriteLine("\t\t\t" + instr.inst);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\t\t[ENQUANTO {0}]", b2.GetLoopItSize());
                            foreach (Instruction instr in b2.GetInstructions())
                            {
                                Console.WriteLine("\t\t\t" + instr.inst);
                            }
                        }
                    }

                    if(b.GetInstructions().Count > 0)
                        foreach(Instruction instr in b.GetInstructions())
                        {
                            Console.WriteLine("\t\t" + instr.inst);
                        }
                }
            }*/
        }
    }
}
