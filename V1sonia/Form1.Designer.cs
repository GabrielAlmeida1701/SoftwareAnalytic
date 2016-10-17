namespace V1sonia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.while_bnt = new System.Windows.Forms.Button();
            this.else_bnt = new System.Windows.Forms.Button();
            this.if_bnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_bnt = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.instruction_bnt = new System.Windows.Forms.Button();
            this.analys_bnt = new System.Windows.Forms.Button();
            this.compx = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instruction_bnt);
            this.panel1.Controls.Add(this.while_bnt);
            this.panel1.Controls.Add(this.else_bnt);
            this.panel1.Controls.Add(this.if_bnt);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 302);
            this.panel1.TabIndex = 0;
            // 
            // while_bnt
            // 
            this.while_bnt.BackColor = System.Drawing.Color.DarkOrchid;
            this.while_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.while_bnt.Location = new System.Drawing.Point(3, 167);
            this.while_bnt.Name = "while_bnt";
            this.while_bnt.Size = new System.Drawing.Size(182, 48);
            this.while_bnt.TabIndex = 3;
            this.while_bnt.Text = "Enquanto(while)";
            this.while_bnt.UseVisualStyleBackColor = false;
            this.while_bnt.Click += new System.EventHandler(this.while_bnt_Click);
            // 
            // else_bnt
            // 
            this.else_bnt.BackColor = System.Drawing.Color.SpringGreen;
            this.else_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.else_bnt.Location = new System.Drawing.Point(4, 91);
            this.else_bnt.Name = "else_bnt";
            this.else_bnt.Size = new System.Drawing.Size(181, 48);
            this.else_bnt.TabIndex = 2;
            this.else_bnt.Text = "Se não(else)";
            this.else_bnt.UseVisualStyleBackColor = false;
            this.else_bnt.Click += new System.EventHandler(this.else_bnt_Click);
            // 
            // if_bnt
            // 
            this.if_bnt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.if_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.if_bnt.Location = new System.Drawing.Point(4, 19);
            this.if_bnt.Name = "if_bnt";
            this.if_bnt.Size = new System.Drawing.Size(181, 48);
            this.if_bnt.TabIndex = 1;
            this.if_bnt.Text = "Se(if)";
            this.if_bnt.UseVisualStyleBackColor = false;
            this.if_bnt.Click += new System.EventHandler(this.if_bnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Software Analytic";
            // 
            // remove_bnt
            // 
            this.remove_bnt.BackColor = System.Drawing.Color.Crimson;
            this.remove_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_bnt.ForeColor = System.Drawing.Color.Black;
            this.remove_bnt.Location = new System.Drawing.Point(114, 379);
            this.remove_bnt.Name = "remove_bnt";
            this.remove_bnt.Size = new System.Drawing.Size(92, 41);
            this.remove_bnt.TabIndex = 2;
            this.remove_bnt.Text = "Remover";
            this.remove_bnt.UseVisualStyleBackColor = false;
            this.remove_bnt.Click += new System.EventHandler(this.remove_bnt_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(577, 337);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(37, 37);
            this.up.TabIndex = 3;
            this.up.Text = "▲";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(577, 380);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(37, 37);
            this.down.TabIndex = 4;
            this.down.Text = "▼";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // instruction_bnt
            // 
            this.instruction_bnt.BackColor = System.Drawing.SystemColors.Highlight;
            this.instruction_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.instruction_bnt.Location = new System.Drawing.Point(4, 233);
            this.instruction_bnt.Name = "instruction_bnt";
            this.instruction_bnt.Size = new System.Drawing.Size(182, 48);
            this.instruction_bnt.TabIndex = 5;
            this.instruction_bnt.Text = "Instrução (Code)";
            this.instruction_bnt.UseVisualStyleBackColor = false;
            this.instruction_bnt.Click += new System.EventHandler(this.instruction_bnt_Click);
            // 
            // analys_bnt
            // 
            this.analys_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.analys_bnt.Location = new System.Drawing.Point(16, 379);
            this.analys_bnt.Name = "analys_bnt";
            this.analys_bnt.Size = new System.Drawing.Size(92, 41);
            this.analys_bnt.TabIndex = 5;
            this.analys_bnt.Text = "Analizar";
            this.analys_bnt.UseVisualStyleBackColor = true;
            this.analys_bnt.Click += new System.EventHandler(this.analys_bnt_Click);
            // 
            // compx
            // 
            this.compx.AutoSize = true;
            this.compx.Location = new System.Drawing.Point(491, 106);
            this.compx.Name = "compx";
            this.compx.Size = new System.Drawing.Size(79, 13);
            this.compx.TabIndex = 6;
            this.compx.Text = "Complexidade: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 432);
            this.Controls.Add(this.compx);
            this.Controls.Add(this.analys_bnt);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.remove_bnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Software Analytic";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button while_bnt;
        private System.Windows.Forms.Button else_bnt;
        private System.Windows.Forms.Button if_bnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_bnt;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button instruction_bnt;
        private System.Windows.Forms.Button analys_bnt;
        private System.Windows.Forms.Label compx;
    }
}