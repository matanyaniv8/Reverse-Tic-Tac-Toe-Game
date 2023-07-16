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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoardForm));
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.SecondPlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(212, 773);
            this.FirstPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(198, 37);
            this.FirstPlayerLabel.TabIndex = 100;
            this.FirstPlayerLabel.Text = "Player 1 : 0 ";
            this.FirstPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondPlayerLabel
            // 
            this.SecondPlayerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SecondPlayerLabel.AutoSize = true;
            this.SecondPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerLabel.Location = new System.Drawing.Point(437, 773);
            this.SecondPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondPlayerLabel.Name = "SecondPlayerLabel";
            this.SecondPlayerLabel.Size = new System.Drawing.Size(190, 37);
            this.SecondPlayerLabel.TabIndex = 101;
            this.SecondPlayerLabel.Text = "Player 2 : 0";
            this.SecondPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 840);
            this.Controls.Add(this.SecondPlayerLabel);
            this.Controls.Add(this.FirstPlayerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label SecondPlayerLabel;
    }
}