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

namespace V1sonia {

    public enum InputBlockType {
        Loop,
        Instructions
    }

    public partial class InputForm : Form {

        Form1 form;
        InputBlockType type;

        public InputForm(Form1 form, InputBlockType type) {
            InitializeComponent();
            this.form = form;
            this.type = type;

            if (type == InputBlockType.Instructions)
                label1.Text = "Por favor digite a linha de codigo";
        }

        private void ok_bnt_Click(object sender, EventArgs e) {
            if (type == InputBlockType.Loop)
                while_box();
            else
                instruction_box();
        }

        private void while_box() {
            if (InputField.Text != "") {
                try {
                    int value = int.Parse(InputField.Text);

                    BlockType t = BlockType.LOOP;
                    form.blocks.Add(new Block_img(t, form.CreateBlock(t), form));
                    form.blocks[form.blocks.Count - 1]
                        .SetFather(form.getSelect_Block())
                        .Text = value.ToString();

                    form.blocks[form.blocks.Count - 1].block.AddLoopCondition(value);

                    form.Render();
                    Close();
                } catch (Exception) {
                    ShowErrorMessage();
                }
            }else
                ShowErrorMessage();
        }

        private void instruction_box() {
            if (InputField.Text == "") return;

            if (form.getSelect_Block() != form.core.mainBlock) {
                Instruction ins = new Instruction(InputField.Text);
                ins.block = form.getSelect_Block();
                form.getBlock_img(form.getSelect_Block()).AddInstruction(ins);
            } else;

            form.Render();
            Close();
        }

        private void ShowErrorMessage() {
            MessageBox.Show("Por favor insira um dado valido");
        }
    }
}
