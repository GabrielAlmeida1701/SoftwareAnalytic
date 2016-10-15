using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class AlgorithmAnalysis
    {
        public Core core;
        int nInstrTotal; //numero de instruções total
        Block atualMotherBlock;

        public AlgorithmAnalysis()
        {
            nInstrTotal = 0;
            core = new Core();
            core.CreateMainBlock();
            
            Instruction inst = new Instruction("a = 1");
            Instruction inst2 = new Instruction("b = 3");
            core.mainBlock.AddInstruction(inst);
            core.mainBlock.AddInstruction(inst2);
            core.CreateCondBlock(BlockType.SE, core.mainBlock);
            core.CreateCondBlock(BlockType.SE, core.mainBlock);
            core.CreateLoopBlock(BlockType.PARA, core.allBlocks[2], 10);
            core.allBlocks[2].GetChildBlocks()[0].AddInstruction(inst2);
            core.CreateCondBlock(BlockType.SE, core.allBlocks[2].GetChildBlocks()[0]);
            core.CreateCondBlock(BlockType.SE, core.allBlocks[2].GetChildBlocks()[0].GetChildBlocks()[0]);
            core.allBlocks[2].GetChildBlocks()[0].GetChildBlocks()[0].AddInstruction(inst);

            core.CreateCondBlock(BlockType.SE, core.mainBlock);



        }
        int contIdent = 0;
        public void VerifyAlgorithm(Block block)
        {


            if (block == core.mainBlock) //main block
            {
                atualMotherBlock = new Block(BlockType.AUX);
                foreach (Instruction instr in block.GetInstructions()) //list all instructions inside mainblock
                {
                    Console.WriteLine(instr.inst);
                }
            }

            else
            {
                if(atualMotherBlock != block.motherBlock)
                {
                    contIdent++;
                }
                    
            }
            

            if (block.GetChildBlocks().Count() > 0)
            {
                foreach (Block b in block.GetChildBlocks())
                {
                    for (int i = 1; i <= core.getHierarchOfBlock(block); i++)
                    {
                        Console.Write("\t");
                    }
                    if (b.type == BlockType.ENQUANTO || b.type == BlockType.PARA) //loop block
                        Console.WriteLine("[ENQUANTO {0}] hierarch: {1}", b.GetLoopItSize(), core.getHierarchOfBlock(b));

                    else //condition block
                        Console.WriteLine("[BLOCO DE CONDICAO] hierarch: {0}", core.getHierarchOfBlock(b));

                    if (b.GetInstructions().Count > 0)
                    {
                        foreach (Instruction instr in b.GetInstructions())
                        {
                            for (int i = 1; i <= core.getHierarchOfBlock(block); i++)
                            {
                                Console.Write("\t");
                            }
                            Console.WriteLine( instr.inst);
                        }
                    }


                    nInstrTotal += b.GetInstructions().Count();
                    VerifyAlgorithm(b);
                }

            }
        }
    }
}
