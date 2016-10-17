using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    public class AlgorithmAnalysis
    {
        private List<int> complexityList; //lista de complexidades de cada bloco do main
        public Core core;
        public int nInstrTotal; //numero de instruções total
        int nRepeatLoop;
        int complexityBlock = 0;
        int complexityAll = 0;

        public AlgorithmAnalysis(Core core)
        {
            nRepeatLoop = 0;
            complexityList = new List<int>();
            nInstrTotal = 0;
            this.core = core;
        }

        public void DefineGeneralComplexity(Block block) //define a complexidade geral de cada bloco de acordo com seu tipo
        {
            if (block.type == BlockType.INICIO || block.type == BlockType.SE || block.type == BlockType.SE_NAO)
            {
                block.blockComplexity += block.GetInstructions().Count;

                if (block.GetChildBlocks().Count > 0)
                {
                    foreach (Block b in block.GetChildBlocks())
                    {
                        block.blockComplexity += Complexity(b);
                    }
                }
            }

            else if (block.type == BlockType.LOOP)
            {
                Complexity(block);
            }
        }

        public int Complexity(Block b)
        {
            complexityBlock = 0;

            if (b.type == BlockType.LOOP) //LOOP INSIDE LOOP
            {
                if (b.GetInstructions().Count > 0 && b.GetChildBlocks().Count == 0)
                {
                    return b.GetInstructions().Count * b.GetLoopItSize();
                }
                else
                {
                    if (b.GetInstructions().Count > 0)
                    {
                        complexityBlock += b.GetInstructions().Count * b.GetLoopItSize();
                    }

                    foreach (Block child in b.GetChildBlocks())
                    {
                        complexityBlock += Complexity(child);
                    }
                    return complexityBlock;
                }
            }
            else // SE 
            {
                b.blockComplexity += b.GetInstructions().Count;

                if (b.GetChildBlocks().Count > 0)
                {
                    foreach (Block child in b.GetChildBlocks())
                    {
                        complexityBlock += Complexity(b);
                    }
                }

                return complexityBlock;
            }

        }

        public Block GetBlockMaxComplexity() //pega o bloco de maior complexidade contido no main
        {
            int max = 0;

            CreateListComplexity(core.mainBlock);

            for (int i = 0; i < complexityList.Count(); i++)
            {
                if (complexityList[i] > max)
                    max = i;
            }

            return core.GetBlockChildMainById(max);
        }
        /*
         public int GetBlockMaxComplexity1() //pega o bloco de maior complexidade contido no main
         {
             int max = 0;

             CreateListComplexity(core.mainBlock);

             if(core.mainBlock.GetChildBlocks().Count > 0)
             {
                 for (int i = 0; i < complexityList.Count(); i++)
                 {
                     if (complexityList[i] > max)
                         max = i;
                 }

                 return core.GetBlockChildMainById(max).blockComplexity;
             }
             else
             {
                 return nInstrTotal;
             }
         }
        */

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
                }
            }

            if (block.GetChildBlocks().Count() > 0)
            {
                foreach (Block b in block.GetChildBlocks())
                {
                    //nInstrTotal += b.GetInstructions().Count();
                    VerifyAlgorithm(b);
                }
            }
        }
    }
}
