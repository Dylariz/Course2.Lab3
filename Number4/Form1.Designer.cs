namespace Number4
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.sourceTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(198, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 52);
            label1.TabIndex = 2;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(637, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(267, 52);
            label2.TabIndex = 3;
            label2.Text = "Morse code";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceTextBox.Location = new System.Drawing.Point(57, 102);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(415, 273);
            this.sourceTextBox.TabIndex = 0;
            this.sourceTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(545, 102);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(442, 261);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 449);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "TextToMorse";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox sourceTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;

        #endregion
    }
}