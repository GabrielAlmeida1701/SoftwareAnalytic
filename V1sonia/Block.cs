using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1sonia
{
    public enum BlockType
    {
        INICIO = 0, //main
        SE = 1,
        RETORNAR = 2,
        SE_NAO = 3,
        PARA = 4 //for(;;){}
    }

    class Block
    {
        public BlockType type;
        public List<Operation> operations;
        public List<Block> childBlocks;

        public Block(BlockType b_type)
        {
            type = b_type;
        }

        public void AddOperations(Operation op)
        {
            operations.Add(op);
        }

        public void RemoveOperation(Operation op)
        {
            operations.Remove(op);
        }

        public void AddChildBlock(Block n_block)
        {
            childBlocks.Add(n_block);
        }

        public void RemoveChildBlock(Block b_toBeRemoved)
        {
            childBlocks.Remove(b_toBeRemoved);
        }
    }
}
