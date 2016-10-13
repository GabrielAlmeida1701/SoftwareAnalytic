﻿using System;
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
        SE_NAO = 2,
        ENQUANTO = 3,
        PARA = 4 //for(;;){}
    }

    //Adicionar a representação do bloco.. imagem, componente, string.. whatever
    class Block
    {
        public BlockType type;
        private List<Instruction> instructions;
        private List<Block> childBlocks;
        private int loopIt;

        public Block(BlockType b_type)
        {
            type = b_type;

            if (type != BlockType.ENQUANTO || type != BlockType.PARA)
                loopIt = 0;
        }

        //SE, SE_NAO, ENQUANTO, PARA
        // ( i < j ) ( i != 10 ) ( i )
        public void AddLoopCondition(int n)
        {
            if(type == BlockType.ENQUANTO || type == BlockType.PARA)
            {
                loopIt = n;
            }
        }

        public int GetLoopItSize() { return loopIt; }

        //Add new "line operation"
        public void AddInstruction(Instruction op)
        {
            instructions.Add(op);
        }

        //Remove line operation
        public void RemoveInstruction(Instruction op)
        {
            instructions.Remove(op);
        }
        
        //Attach
        public void AddChildBlock(Block n_block)
        {
            childBlocks.Add(n_block);
        }

        //Detach
        public void RemoveChildBlock(Block b_toBeRemoved)
        {
            childBlocks.Remove(b_toBeRemoved);
        }

        public List<Block> GetChildBlocks()
        {
            return childBlocks;
        }

        public List<Instruction> GetInstructions()
        {
            return instructions;
        }
    }
}
