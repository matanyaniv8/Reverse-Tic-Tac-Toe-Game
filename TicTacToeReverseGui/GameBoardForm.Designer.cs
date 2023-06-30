namespace TicTacToeReverseGui
{
    partial class GameBoardForm
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
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(212, 773);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(391, 37);
            this.FirstPlayerLabel.TabIndex = 100;
            this.FirstPlayerLabel.Text = "Player 1 : 0     Player 2:0";
            this.FirstPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstPlayerLabel.Click += new System.EventHandler(this.FirstPlayerName_Click);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 840);
            this.Controls.Add(this.FirstPlayerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GameBoardForm";
            this.Text = "TicTacToeMisere";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstPlayerLabel;
    }
}