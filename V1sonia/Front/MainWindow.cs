using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1sonia.Front
{
    public partial class MainWindow : Form
    {
        Graphics g;
        public List<Block_img> blocks;

        public Core core;

        Block selected_block;

        public MainWindow() {
            InitializeComponent();
            core = new Core();

            core.CreateMainBlock();
            selected_block = core.mainBlock;

            g = CreateGraphics();
            blocks = new List<Block_img>();
        }

        private void button2_Click(object sender, EventArgs e) {
            BlockType t = BlockType.ENQUANTO;
            //blocks.Add(new Block_img(t, CreateBlock(t), this).SetFather(selected_block));

            Render();
        }

        private void Render() {
            g.Clear(Color.White);

            foreach (Block_img b in blocks)
                b.DrawBlock(g);
        }

        private Block CreateBlock(BlockType type) {
            switch (type) {
                case BlockType.ENQUANTO:
                    return core.CreateLoopBlock(BlockType.ENQUANTO, selected_block, 15);

                case BlockType.PARA:
                    return core.CreateLoopBlock(BlockType.ENQUANTO, selected_block, 15);

                case BlockType.SE:
                    return core.CreateCondBlock(BlockType.SE, selected_block);

                case BlockType.SE_NAO:
                    return core.CreateCondBlock(BlockType.SE_NAO, selected_block);
            }

            return null;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e){
            bool success_click = false;

            foreach (Block_img b in blocks) {
                bool beer = b.CheckClicks(e.Location);
                if (beer)
                    success_click = true;
            }

            if (!success_click) 
                selected_block = core.mainBlock;

            Render();
        }

        public void setSelect_Block(Block new_select) {
            selected_block = new_select;
        }

        public Block getSelect_Block() { return selected_block; }

        public Block_img getBlock_img(Block block) {
            int i = core.allBlocks.IndexOf(block);

            if (i == -1)
                return null;

            return blocks[i];
        }
    }
}
