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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.while_bnt = new System.Windows.Forms.Button();
            this.else_bnt = new System.Windows.Forms.Button();
            this.if_bnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_bnt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.while_bnt);
            this.panel1.Controls.Add(this.else_bnt);
            this.panel1.Controls.Add(this.if_bnt);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 269);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Iterações:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 5;
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
            this.remove_bnt.Location = new System.Drawing.Point(16, 379);
            this.remove_bnt.Name = "remove_bnt";
            this.remove_bnt.Size = new System.Drawing.Size(181, 41);
            this.remove_bnt.TabIndex = 2;
            this.remove_bnt.Text = "Remover";
            this.remove_bnt.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 432);
            this.Controls.Add(this.remove_bnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Software Analytic";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button while_bnt;
        private System.Windows.Forms.Button else_bnt;
        private System.Windows.Forms.Button if_bnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_bnt;
    }
}