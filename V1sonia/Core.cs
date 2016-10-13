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
        public Block mainBlock;
        public List<Block> allBlocks;

        public Core()
        {
            allBlocks = new List<Block>();
        }

        public Block CreateBlock(BlockType type, Block parent)
        {
            Block b = new Block(type);
            parent.AddChildBlock(b);
            allBlocks.Add(b);
            return b;
        }
        public void CreateLoopBlock(BlockType type, Block parent, int itControl)
        {
            Block b = new Block(type);
            b.AddLoopCondition(itControl);
            allBlocks.Add(b);
            parent.AddChildBlock(b);
        }

        public void CreateMainBlock()
        {
            Block b = new Block(BlockType.INICIO);
            mainBlock = b;
            allBlocks.Add(b);
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

        public int GetInstrCount(Block b)
        {
            return b.GetInstructions().Count;
        }
    }
}
