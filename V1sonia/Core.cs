using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    class Core
    {
        public Block mainBlock;
        public List<Block> allBlocks;
        public int nBlocks;

        public Core()
        {
            nBlocks = 0;
            allBlocks = new List<Block>();
        }

        public Block CreateCondBlock(BlockType type, Block parent)
        {
            nBlocks++;
            Block b = new Block(type);
            if (parent.type == BlockType.INICIO)
            {
                b.id = this.mainBlock.GetChildBlocks().Count;
            }
            else
            {
                b.id = parent.id;
            }
            parent.AddChildBlock(b);
            b.motherBlock = parent; //cria bloco mae
            allBlocks.Add(b);
            return b;
        }
        public Block CreateLoopBlock(BlockType type, Block parent, int itControl)
        {
            nBlocks++;
            Block b = new Block(type);

            if (parent.type == BlockType.INICIO)
            {
                b.id = this.mainBlock.GetChildBlocks().Count;
            }
            else
            {
                b.id = parent.id;
            }

            b.motherBlock = parent; //cria bloco mae
            b.AddLoopCondition(itControl);
            allBlocks.Add(b);
            parent.AddChildBlock(b);
            return b;
        }

        public void CreateMainBlock()
        {
            Block b = new Block(BlockType.INICIO);
            mainBlock = b;
            allBlocks.Add(b);
        }

        public List<Block> GetLoopBlocks(List<Block> blocks)
        {
            List<Block> loopBlocks = new List<Block>();
            foreach (Block b in blocks)
            {
                if (b.type == BlockType.LOOP)
                {
                    loopBlocks.Add(b);
                }
            }
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

        public List<Block> GetCondBlocks()
        {
            List<Block> condBlocks = new List<Block>();
            foreach (Block b in allBlocks)
            {
                if (b.type == BlockType.SE || b.type == BlockType.SE_NAO)
                {
                    condBlocks.Add(b);
                }
            }
            if (condBlocks.Count() > 0)
                return condBlocks;
            return new List<Block>();
        }

        public int getHierarchOfBlock(Block parent)
        {
            Block b = parent;
            int contHierarch = 0;
            while (true)
            {
                if (parent.type != BlockType.INICIO)
                    parent = parent.motherBlock;

                else if (parent.type == BlockType.INICIO)
                    break;
                contHierarch++;
            }
            return contHierarch;
        }

        public Block GetBlockChildMainById(int id)
        {
            if(this.mainBlock.GetChildBlocks().Count > 0)
            {
                foreach(Block b in this.mainBlock.GetChildBlocks())
                {
                    if (b.id == id)
                        return b;
                }
            }

            return new Block(BlockType.AUX);
        }
    }
}
