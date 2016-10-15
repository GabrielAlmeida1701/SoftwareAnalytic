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
        public int size;

        public Point position;

        private Rectangle click_box;

        public Block block;
        public Block father;

        private MainWindow window;

        public Block_img(BlockType type, Block block, MainWindow window) {
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
            left = Image.FromFile("C:\\asd\\tst_btn.png");
            button = Image.FromFile("C:\\asd\\tst_btn.png");
        }

        public void DrawBlock(Graphics g) {
            g.DrawImage(top, position.X, position.Y, X, Y);
            g.DrawImage(left, position.X, position.Y + Y, 20, GetHeight());
            g.DrawImage(button, position.X, position.Y + Y + GetHeight(), X, Y/2);

            size = (position.Y - Y / 2) + Y + GetHeight() + Y + (Y / 2);
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
            int count = window.core.mainBlock.GetChildBlocks().Count;

            if (count == 1) {
                pos.X = 50;
                pos.Y = 50;
            } else {
                int size = 50;
                for (int i = 0; i < count; i++) {
                    size += window.blocks[i].size;
                }

                pos.X = 50;
                pos.Y = (30*(count-1)) + size + Y + ((count-2) * Y);
            }

            return pos;
        }
    }
}
