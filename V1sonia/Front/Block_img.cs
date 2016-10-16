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
        public int size = 90;

        public Point position;

        private Rectangle click_box;

        public Block block;
        public Block father;

        private Form1 window;

        public Block_img(BlockType type, Block block, Form1 window) {
            this.block = block;
            this.window = window;
            position = GetStartPosition();
            click_box = new Rectangle(position.X, position.Y, X, Y);

            switch (type) {
                case BlockType.INICIO:
                    break;
                case BlockType.ENQUANTO:
                    break;
                case BlockType.PARA:
                    break;
                case BlockType.SE:
                    break;
                case BlockType.SE_NAO:
                    break;
            }

            top = Properties.Resources.tst_Top;
            left = Properties.Resources.tst_btn;
            button = Properties.Resources.tst_btn;
        }

        public void DrawBlock(Graphics g) {
            g.DrawImage(top, position.X, position.Y, X, Y);
            g.DrawImage(left, position.X, position.Y + Y, 20, GetHeight());
            g.DrawImage(button, position.X, position.Y + Y + GetHeight(), X, Y/2);

            //size = (position.Y - Y / 2) + Y + GetHeight() + Y + (Y / 2);
            if (block == window.getSelect_Block()) {
                g.DrawLine(Pens.Red, new Point(position.X - 10, position.Y), new Point(position.X - 10, size));//left
                g.DrawLine(Pens.Red, new Point(position.X + X + 10, position.Y), new Point(position.X + X + 10, size));//right

                g.DrawLine(Pens.Red, new Point(position.X - 10, position.Y), new Point(position.X + X + 10, position.Y));//top
                g.DrawLine(Pens.Red, new Point(position.X - 10, size), new Point(position.X + X + 10, size));//down
            }

            //g.DrawString("If", new Font(FontFamily.Families[2], 20), Brushes.Black, 0, 0);
        }

        public Block_img SetFather(Block block) {
            father = block;

            if (father != window.core.mainBlock) {
                position.X += 20;
                position.Y += Y * block.GetChildBlocks().Count;
            }

            click_box = new Rectangle(position.X, position.Y, X, Y);
            return this;
        }

        int GetHeight() {
            int childCount = block.GetChildBlocks().Count;
            for (int i = 0; i < block.GetChildBlocks().Count; i++)
                childCount += block.GetChildBlocks()[i].GetChildBlocks().Count;

            childCount = (childCount != 0) ? childCount * 30 + 50 : 30;

            return childCount;
        }

        public int GetAcctualHeight() {
            return (position.Y - Y / 2) + Y + GetHeight() + Y + (Y / 2);
        }

        public bool CheckClicks(Point e) {
            if (click_box.Contains(e)) {
                window.setSelect_Block(block);
                Console.WriteLine("poop \n\n");
            }

            return click_box.Contains(e);
        }

        public Point GetStartPosition() {
            Point pos = new Point(0, 0);

            Block main = window.core.mainBlock;
            int final_size = 80;

            if(window.blocks.Count == 0) {
                pos.X = window.group_bnts.Width + 50;
                pos.Y = 120;

                return pos;
            }

            foreach (Block b in main.GetChildBlocks()) {
                int index = main.GetChildBlocks().IndexOf(b);
                if(index < window.blocks.Count - 2) {
                    final_size += window.blocks[index].size;
                }
            }

            Block blk = block.motherBlock;
            while(blk != main) {

            }

            pos.X = window.group_bnts.Width + 50;

            return pos;
        }
    }
}
