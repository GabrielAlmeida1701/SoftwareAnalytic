using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class Engine
    {
        private int totalBlocksLength;
        private Block mainBlock;

        public Engine()
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

        public List<Block> GetRelevantBlocks()
        {
            List<Block> loopBlocks = new List<Block>();
            List<Block> condBlocks = new List<Block>();

            //Separa os blocos
            foreach(Block b in mainBlock.GetChildBlocks())
            {
                if(b.type == BlockType.ENQUANTO || b.type == BlockType.PARA)
                {
                    loopBlocks.Add(b);
                }
                else if(b.type != BlockType.INICIO)
                {
                    condBlocks.Add(b);
                }
            }

            //Analista os dois tipos de blocos..
            if(loopBlocks.Count > 0)
            {

            }

            return new Block(0); //Retornar o bloco encontrado
        }

        public int GetInstrSize(Block b)
        {
            return b.GetInstructions().Count;
        }
    }
}
