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
        SE_NAO = 2,
        LOOP = 3,
        AUX = 4
    }

    //Adicionar a representação do bloco.. imagem, componente, string.. whatever
    public class Block
    {
        public BlockType type;
        private List<Instruction> instructions = new List<Instruction>();
        private List<Block> childBlocks = new List<Block>();
        public Block motherBlock;
        public int id;
        private int loopIt;
        public Guid InstanceID { get; private set; }
        public int blockComplexity;

        public Block(BlockType b_type)
        {
            blockComplexity = 0;
            id = 0;
            type = b_type;

            switch (type)
            {
                case BlockType.LOOP:
                    Console.WriteLine("Bloco LOOP criado");
                    loopIt = 0;
                    break;
                case BlockType.SE:
                    Console.WriteLine("Bloco SE criado");
                    break;
                case BlockType.SE_NAO:
                    Console.WriteLine("Bloco SE NAO criado");
                    break;
            }
        }

        //SE, SE_NAO, ENQUANTO, PARA
        // ( i < j ) ( i != 10 ) ( i )
        public void AddLoopCondition(int n)
        {
            if (type == BlockType.LOOP)
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
