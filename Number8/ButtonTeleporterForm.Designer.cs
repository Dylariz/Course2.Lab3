namespace Number8
{
    partial class ButtonTeleporterForm
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
            this.jumpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jumpButton
            // 
            this.jumpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jumpButton.Location = new System.Drawing.Point(388, 300);
            this.jumpButton.Name = "jumpButton";
            this.jumpButton.Size = new System.Drawing.Size(200, 50);
            this.jumpButton.TabIndex = 0;
            this.jumpButton.Text = "Нажми меня =^_^=";
            this.jumpButton.UseVisualStyleBackColor = true;
            // 
            // ButtonTeleporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 696);
            this.Controls.Add(this.jumpButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(350, 100);
            this.Name = "ButtonTeleporterForm";
            this.Text = "Button Teleporter";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button jumpButton;

        #endregion
    }
}