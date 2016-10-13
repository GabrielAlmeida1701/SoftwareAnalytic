using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class Core
    {
        private int totalBlocksLength;
        private Block mainBlock;

        public Core()
        {
        }

        public void CreateBlock(BlockType type)
        {
            Block b = new Block(type);
            mainBlock.AddChildBlock(b);
        }
        public void CreateBlock(BlockType type, int itControl)
        {
            Block b = new Block(type);
            b.AddLoopCondition(itControl);
            mainBlock.AddChildBlock(b);
        }

        public void InsertInstruction(Block b, Instruction inst)
        {
            Block block = mainBlock.GetChildBlocks().Find(x => x == b);
            block.AddInstruction(inst);
        }
        public void CreateMainBlock()
        {
            Block b = new Block(BlockType.INICIO);
            mainBlock = b;
        }

        public List<Block> GetLoopBlocks()
        {
            List<Block> loopBlocks = new List<Block>();

            //Separa os blocos
            foreach(Block b in mainBlock.GetChildBlocks())
            {
                if(b.type == BlockType.ENQUANTO || b.type == BlockType.PARA)
                {
                    loopBlocks.Add(b);
                }
            }

            //Analista os dois tipos de blocos..
            if (loopBlocks.Count > 0)
            {
                return loopBlocks;
            }
            else
            {
                return new List<Block>();
            }
        }

        public int GetInstrSize(Block b)
        {
            return b.GetInstructions().Count;
        }
    }
}
