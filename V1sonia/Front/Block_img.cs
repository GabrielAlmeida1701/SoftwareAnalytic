using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1sonia;

namespace V1sonia.Front {

    public class Block_img {
        Image top, left, button;

        public int X = 180;
        public int Y = 30;
        public int size = 30;
        public Point position = new Point();
        public string Text;

        private Rectangle click_box;

        public Block block;
        public List<Instruction> instroctions = new List<Instruction>();
        private Block father;

        private Form1 window;

        private int instroctions_Height {
            get {
                return window.getBlock_img(father).instroctions.Count * Y;
            }
        }

        public Block_img(BlockType type, Block block, Form1 window) {
            this.block = block;
            this.window = window;
            click_box = new Rectangle(PositionX(), PositionY(), X, Y);

            switch (type) {
                case BlockType.LOOP:
                    top = Properties.Resources.while_Top;
                    left = Properties.Resources.while_btn;
                    button = Properties.Resources.while_btn;
                    break;
                case BlockType.SE:
                    top = Properties.Resources.if_top;
                    left = Properties.Resources.if_btn;
                    button = Properties.Resources.if_btn;
                    break;
                case BlockType.SE_NAO:
                    top = Properties.Resources.else_top;
                    left = Properties.Resources.else_btn;
                    button = Properties.Resources.else_btn;
                    break;
            }
        }

        public void DrawBlock(Graphics g) {
            click_box = new Rectangle(PositionX(), PositionY(), X, Y);

            g.DrawImage(top, PositionX(), PositionY(), X, Y);
            g.DrawImage(left, PositionX(), PositionY() + Y, 20, size);
            g.DrawImage(button, PositionX(), PositionY() + Y + size, X, Y/2);
            DrawInstructions(g);

            if (Text != "")
                g.DrawString(Text, new Font(FontFamily.Families[3], 18), Brushes.Black, PositionX() + 80, PositionY() + 2);
            
            if (block == window.getSelect_Block()) {
                g.DrawLine(Pens.Red, click_box.Location, new Point(click_box.X + click_box.Width, click_box.Y));//top
                g.DrawLine(Pens.Red, click_box.Location, new Point(click_box.X, click_box.Y + click_box.Height));//left
                g.DrawLine(Pens.Red, new Point(click_box.X + click_box.Width, click_box.Y + click_box.Height), new Point(click_box.X, click_box.Y + click_box.Height));//down
                g.DrawLine(Pens.Red, new Point(click_box.X + click_box.Width, click_box.Y), new Point(click_box.X + click_box.Width, click_box.Y + click_box.Height));//right
            }
        }

        public Block_img SetFather(Block block) {
            father = block;

            if (father != window.core.mainBlock) {
                Block_img b_img = window.getBlock_img(father);
                position = b_img.position;

                position.X += 20;
                position.Y = instroctions_Height + 
                    window.getBlock_img(block).PositionY() + ChildSize(block) +
                    ((block.GetChildBlocks().Count == 1)? 0 : 15 * block.GetChildBlocks().Count);

                Console.WriteLine(instroctions.Count);
            } else {
                position.X = 20;
                position.Y = 120 + OthersSize();
            }
            
            while (block != window.core.mainBlock) {
                window.getBlock_img(block).size += 55;
                block = block.motherBlock;
            }

            return this;
        }

        public void AddInstruction(Instruction ins) {
            size += Y;
            instroctions.Add(ins);
            block.AddInstruction(ins);
        }

        public void DrawInstructions(Graphics g) {
            foreach (Instruction ins in instroctions) {
                g.DrawImage(Properties.Resources.inst,
                    PositionX() + 20, PositionY() + Y + (instroctions.IndexOf(ins) * Y), X, Y);

                g.DrawString(ins.inst, new Font(FontFamily.Families[0], 18), Brushes.Black, PositionX() + 30, PositionY() + Y + (instroctions.IndexOf(ins) * Y));
            }
        }

        public bool CheckClicks(Point e) {
            e.Y -= window.global.Y;

            if (click_box.Contains(e))
                window.setSelect_Block(block);

            return click_box.Contains(e);
        }

        public int PositionX() {
            return position.X + window.global.X;
        }

        public int PositionY() {
            return position.Y + window.global.Y;
        }

        private int ChildSize(Block b) {
            int size_c = 0;

            foreach(Block bk in b.GetChildBlocks()) 
                size_c += window.getBlock_img(bk).size;

            return size_c;
        }

        public int OthersSize() {
            int f_size = 0;
            int f_id = window.core.mainBlock.GetChildBlocks().IndexOf(block);
            for (int i = 0; i < f_id; i++) 
                f_size += window.getBlock_img(window.core.mainBlock.GetChildBlocks()[i]).size;

            return f_size;
        }
    }
}
