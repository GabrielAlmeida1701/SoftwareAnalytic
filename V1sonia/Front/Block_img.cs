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

        public Point position;

        private Rectangle click_box;

        Block block;
        Block father;

        private Form1 window;

        public Block_img(BlockType type, Block block, Form1 window) {
            this.block = block;
            this.window = window;
            position = GetStartPosition();
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
            g.DrawImage(top, PositionX(), PositionY(), X, Y);
            g.DrawImage(left, PositionX(), PositionY() + Y, 20, size);
            g.DrawImage(button, PositionX(), PositionY() + Y + size, X, Y/2);
            
            if (block == window.getSelect_Block()) {
                g.DrawLine(Pens.Red, new Point(PositionX() - 10, PositionY()), new Point(PositionX() - 10, PositionY() + 30));//left
                g.DrawLine(Pens.Red, new Point(PositionX() + X + 10, PositionY()), new Point(PositionX() + X + 10, PositionY() + 30));//right

                g.DrawLine(Pens.Red, new Point(PositionX() - 10, PositionY()), new Point(PositionX() + X + 10, PositionY()));//top
                g.DrawLine(Pens.Red, new Point(PositionX() - 10, PositionY() + 30), new Point(PositionX() + X + 10, PositionY() + 30));//down
            }
        }

        public Block_img SetFather(Block block) {
            father = block;

            if (father != window.core.mainBlock) {
                position.X += 20;
                position.Y += 22;
            }

            click_box = new Rectangle(PositionX(), PositionY(), X, Y);
            while (block != window.core.mainBlock) {
                window.getBlock_img(father).size += 55;
                block = block.motherBlock;
            }

            return this;
        }

        int GetHeight() {
            int childCount = block.GetChildBlocks().Count;
            for (int i = 0; i < block.GetChildBlocks().Count; i++)
                childCount += block.GetChildBlocks()[i].GetChildBlocks().Count;

            childCount = (childCount != 0) ? childCount * 30 + 90 : 30;

            return childCount;
        }

        public bool CheckClicks(Point e) {
            e.Y -= window.global.Y;

            if (click_box.Contains(e))
                window.setSelect_Block(block);

            return click_box.Contains(e);
        }

        public Point GetStartPosition() {
            Point pos = new Point(0, 0);

            Block mother = block.motherBlock;
            int final_size = 90;
            
            if (window.blocks.Count == 0) {
                pos.X = window.group_bnts.Width + 50;
                pos.Y = 120;

                return pos;
            }

            if (mother.GetChildBlocks().Count == 1) {
                int index_m = window.core.allBlocks.IndexOf(mother) - 1;
                
                pos.X = window.blocks[index_m].position.X;
                pos.Y = window.blocks[index_m].position.Y;

                return pos;
            }

            foreach (Block b in mother.GetChildBlocks()) {
                int index = mother.GetChildBlocks().IndexOf(b);
                if(index < window.blocks.Count-1) {
                    final_size += window.blocks[index].size;
                }
            }

            Block blk = block.motherBlock;
            int x = (blk == window.core.mainBlock)? 0 : -20;
            while(blk != window.core.mainBlock) {
                x += 20;
                blk = blk.motherBlock;
            }
            
            pos.X = (window.group_bnts.Width + 50) + x;
            pos.Y = 90 + final_size - ((window.blocks.Count - 1) * Y);

            return pos;
        }

        public int PositionX() {
            return position.X + window.global.X;
        }

        public int PositionY() {
            return position.Y + window.global.Y;
        }
    }
}
