using System;

namespace TicTacToeReverseGui
{
    partial class GameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettings));
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.NumOfRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfCols = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.SecondPlayerCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCols)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(42, 278);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(266, 48);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start !";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(180, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = ":Players";
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1TextBox.Location = new System.Drawing.Point(105, 65);
            this.Player1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(235, 35);
            this.Player1TextBox.TabIndex = 2;
            this.Player1TextBox.TextChanged += new System.EventHandler(this.Player1TextBox_TextChanged);
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.AcceptsTab = true;
            this.Player2TextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Player2TextBox.Enabled = false;
            this.Player2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2TextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Player2TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2TextBox.Location = new System.Drawing.Point(105, 131);
            this.Player2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(235, 35);
            this.Player2TextBox.TabIndex = 3;
            this.Player2TextBox.Text = "[Computer]";
            this.Player2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Player2TextBox.TextChanged += new System.EventHandler(this.Player2TextBox_TextChanged);
            // 
            // NumOfRows
            // 
            this.NumOfRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfRows.Location = new System.Drawing.Point(105, 238);
            this.NumOfRows.Margin = new System.Windows.Forms.Padding(4);
            this.NumOfRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumOfRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumOfRows.Name = "NumOfRows";
            this.NumOfRows.Size = new System.Drawing.Size(48, 38);
            this.NumOfRows.TabIndex = 4;
            this.NumOfRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumOfRows.ValueChanged += new System.EventHandler(this.NumOfRows_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rows :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Board Size :";
            // 
            // NumOfCols
            // 
            this.NumOfCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfCols.Location = new System.Drawing.Point(250, 239);
            this.NumOfCols.Margin = new System.Windows.Forms.Padding(4);
            this.NumOfCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumOfCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumOfCols.Name = "NumOfCols";
            this.NumOfCols.Size = new System.Drawing.Size(49, 38);
            this.NumOfCols.TabIndex = 7;
            this.NumOfCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumOfCols.ValueChanged += new System.EventHandler(this.NumOfCols_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cols :";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Enabled = false;
            this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(24, 65);
            this.Player1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(130, 31);
            this.Player1Label.TabIndex = 9;
            this.Player1Label.Text = "Player1 :";
            // 
            // SecondPlayerCheck
            // 
            this.SecondPlayerCheck.AutoSize = true;
            this.SecondPlayerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerCheck.Location = new System.Drawing.Point(12, 131);
            this.SecondPlayerCheck.Margin = new System.Windows.Forms.Padding(4);
            this.SecondPlayerCheck.Name = "SecondPlayerCheck";
            this.SecondPlayerCheck.Size = new System.Drawing.Size(162, 35);
            this.SecondPlayerCheck.TabIndex = 11;
            this.SecondPlayerCheck.Text = "Player2 :";
            this.SecondPlayerCheck.UseVisualStyleBackColor = true;
            this.SecondPlayerCheck.CheckedChanged += new System.EventHandler(this.SecondPlayerCheck_CheckedChanged);
            // 
            // GameSettings
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(347, 352);
            this.Controls.Add(this.SecondPlayerCheck);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumOfCols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumOfRows);
            this.Controls.Add(this.Player2TextBox);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSettings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.BackColorChanged += new System.EventHandler(this.GameSettings_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.NumOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.NumericUpDown NumOfRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumOfCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.CheckBox SecondPlayerCheck;
    }
}