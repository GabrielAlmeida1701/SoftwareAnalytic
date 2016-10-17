namespace V1sonia
{
    partial class InputForm
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_bnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(44, 55);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(139, 20);
            this.InputField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor digite o número de interações";
            // 
            // ok_bnt
            // 
            this.ok_bnt.Location = new System.Drawing.Point(229, 47);
            this.ok_bnt.Name = "ok_bnt";
            this.ok_bnt.Size = new System.Drawing.Size(95, 34);
            this.ok_bnt.TabIndex = 2;
            this.ok_bnt.Text = "OK";
            this.ok_bnt.UseVisualStyleBackColor = true;
            this.ok_bnt.Click += new System.EventHandler(this.ok_bnt_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 91);
            this.Controls.Add(this.ok_bnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputField);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_bnt;
    }
}