using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class AlgorithmAnalysis
    {
        private List<int> complexityList; //lista de complexidades de cada bloco do main
        public Core core;
        public int nInstrTotal; //numero de instruções total
        int nRepeatLoop;
        public AlgorithmAnalysis()
        {
            nRepeatLoop = 0;
            complexityList = new List<int>();
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

        public void DefineGeneralComplexity(Block block) //define a complexidade geral de cada bloco de acordo com seu tipo
        {

            if (block.type == BlockType.INICIO || block.type == BlockType.SE || block.type == BlockType.SE_NAO)
            {
                block.blockComplexity = block.GetInstructions().Count;
            }


            else if (block.type == BlockType.ENQUANTO || block.type == BlockType.PARA)
            {
                block.blockComplexity = block.GetLoopItSize();
                block.blockComplexity *= block.GetInstructions().Count;
            }
        }

        public Block GetBlockMaxComplexity() //pega o bloco de maior complexidade contido no main
        {
            CreateListComplexity(core.mainBlock);
            int max = 0;
            for (int i = 0; i < complexityList.Count(); i++)
            {
                if (complexityList[i] > max)
                    max = i;
            }
            return core.GetBlockChildMainById(max);
        }

        public void CreateListComplexity(Block block) //cria uma lista que contem a complexidade de cada bloco do main
        {

            if (block.GetChildBlocks().Count() > 0)
            {
                foreach (Block b in block.GetChildBlocks())
                {
                    if (block.type == BlockType.INICIO)
                    {
                        complexityList.Add(b.blockComplexity);
                    }

                    else
                    {
                        complexityList[b.id] += b.blockComplexity;
                    }
                    CreateListComplexity(b);
                }

            }
        }

        public void VerifyAlgorithm(Block block) //indenta algoritmo
        {
            DefineGeneralComplexity(block);

            if (block == core.mainBlock) //main block
            {

                foreach (Instruction instr in block.GetInstructions()) //list all instructions inside mainblock
                {
                    nInstrTotal++;
                    Console.WriteLine(instr.inst);
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

                    if (block.type == BlockType.INICIO)
                        Console.Write("\n BlockID: " + b.id.ToString() + " -> ");

                    if (b.type == BlockType.ENQUANTO || b.type == BlockType.PARA) //loop block
                    {
                        Console.WriteLine("[ENQUANTO {0}] hierarch: {1}", b.GetLoopItSize(), core.getHierarchOfBlock(b));

                        if (nRepeatLoop == 0)
                        {
                            nRepeatLoop = b.GetLoopItSize();
                        }
                        else
                        {
                            if (b.GetInstructions().Count > 0)
                            {
                                nRepeatLoop = b.GetLoopItSize() * b.GetInstructions().Count;
                            }
                            else
                            {
                                nRepeatLoop *= b.GetLoopItSize();
                            }
                        }
                    }

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
                            Console.WriteLine(instr.inst);
                        }
                    }


                    nInstrTotal += b.GetInstructions().Count();
                    VerifyAlgorithm(b);
                }

            }
        }
        public int LoopUnderLoop() //função do thômas e seus amigos
        {
            return nRepeatLoop;
        }
    }
}
