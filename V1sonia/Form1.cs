using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V1sonia.Front;

namespace V1sonia
{
    public partial class Form1 : Form
    {
        public Point global;

        Graphics g;
        public List<Block_img> blocks;

        public Core core;

        Block selected_block;
        public AlgorithmAnalysis analysis;

        public Panel group_bnts;

        public Form1() {
            InitializeComponent();
            group_bnts = panel1;

            core = new Core();
            global = new Point();
            analysis = new AlgorithmAnalysis(core);

            core.CreateMainBlock();
            selected_block = core.mainBlock;

            g = CreateGraphics();
            blocks = new List<Block_img>();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            bool success_click = false;

            foreach (Block_img b in blocks) {
                bool beer = b.CheckClicks(e.Location);
                if (beer) success_click = true;
            }

            if (!success_click) 
                selected_block = core.mainBlock;

            Render();
        }

        private void if_bnt_Click(object sender, EventArgs e) {
            BlockType t = BlockType.SE;
            blocks.Add(new Block_img(t, CreateBlock(t), this));
            blocks[blocks.Count - 1].SetFather(selected_block);

            Render();
        }

        private void else_bnt_Click(object sender, EventArgs e) {
            BlockType t = BlockType.SE_NAO;
            blocks.Add(new Block_img(t, CreateBlock(t), this));
            blocks[blocks.Count - 1].SetFather(selected_block);

            Render();
        }

        private void while_bnt_Click(object sender, EventArgs e) {
            new InputForm(this, InputBlockType.Loop).Show();
        }

        public void Render() {
            g.Clear(Color.White);
            PreRender(core.mainBlock);

            foreach (Block_img b in blocks)
                b.DrawBlock(g);
        }

        public Block CreateBlock(BlockType type) {
            switch (type) {
                case BlockType.LOOP:
                    return core.CreateLoopBlock(BlockType.LOOP, selected_block, 15);

                case BlockType.SE:
                    return core.CreateCondBlock(BlockType.SE, selected_block);

                case BlockType.SE_NAO:
                    return core.CreateCondBlock(BlockType.SE_NAO, selected_block);
            }

            return null;
        }

        public void setSelect_Block(Block new_select) {
            selected_block = new_select;
        }

        public Block getSelect_Block() {
            return selected_block;
        }

        public Block_img getBlock_img(Block block) {
            int i = core.allBlocks.IndexOf(block);

            if (i == -1)
                return null;

            return blocks[i-1];
        }
        
        void PreRender(Block main) {
            int index = GetIndexBlock(main);
            
            for (int i = 0; i < main.GetChildBlocks().Count; i++) {
                Point pos = new Point(0, 0);
                pos.X = group_bnts.Width + 50;
                pos.Y = (i == 0) ? 120 : 120 + 60 * i + GetYPosition(main.GetChildBlocks()[i]);
                List<Block> bs = core.allBlocks;
                int id = blocks.IndexOf(getBlock_img(main.GetChildBlocks()[i]));
                blocks[id].position = pos;
            }
        }

        public int GetIndexBlock(Block block) {
            return core.allBlocks.IndexOf(block) - 1;
        }

        private void down_Click(object sender, EventArgs e) {
            global.Y -= 10;
            Render();
        }

        private void up_Click(object sender, EventArgs e) {
            global.Y += 10;
            Render();
        }

        private int GetYPosition(Block b) {
            int att = core.mainBlock.GetChildBlocks().IndexOf(b);
            if (att == 0) return 0;

            int prev = core.mainBlock.GetChildBlocks().IndexOf(b) - 1;

            return getBlock_img(core.mainBlock.GetChildBlocks()[prev]).size;
        }

        private void instruction_bnt_Click(object sender, EventArgs e) {
            new InputForm(this, InputBlockType.Instructions).Show();
        }

        private void analys_bnt_Click(object sender, EventArgs e) {
            Block main = core.mainBlock;
            foreach (Block b in main.GetChildBlocks())
                analysis.VerifyAlgorithm(b);

            compx.Text = "Complexidade: "+
            analysis.GetBlockMaxComplexity().blockComplexity.ToString();
        }

        private void remove_bnt_Click(object sender, EventArgs e) {
            if(selected_block != core.mainBlock) {
                blocks.Remove(getBlock_img(selected_block));
                selected_block.motherBlock.GetChildBlocks().Remove(selected_block);
                core.allBlocks.Remove(selected_block);
            }

            selected_block = core.mainBlock;
            Render();
        }
    }
}
