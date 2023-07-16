using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeReverseGui
{
    public partial class GameSettings : Form
    {
        private const string k_DefualtPlayer2Text = "[Computer]";
        private string m_FirstPlayerName = "Player1";
        private string m_SecondPlayerName = "Computer";

        public GameSettings()
        {
            InitializeComponent();
        }

        private void GameSettings_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void Player2TextBox_TextChanged(object sender, EventArgs e)
        {
            m_SecondPlayerName = Player2TextBox.Text;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int boardSizeFromSetting = (int)NumOfRows.Value;
            bool isSecondPlayerHuman = (SecondPlayerCheck.Checked) ? true : false;
            GameBoardForm TicTacToeManager = new GameBoardForm(boardSizeFromSetting, m_FirstPlayerName, m_SecondPlayerName, isSecondPlayerHuman);
            
            this.Hide();
            TicTacToeManager.ShowDialog();
        }

        private void SecondPlayerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(SecondPlayerCheck.Checked == true)
            {
                Player2TextBox.Enabled = true;
                Player2TextBox.BackColor = Color.White;
                Player2TextBox.Text = string.Empty;
            }
            else
            {
                Player2TextBox.BackColor = System.Drawing.SystemColors.ControlLight;
                Player2TextBox.Enabled = false;
                Player2TextBox.Text = k_DefualtPlayer2Text;
            }
        }

        private void Player1TextBox_TextChanged(object sender, EventArgs e)
        {
            m_FirstPlayerName = Player1TextBox.Text;
        }

        private void NumOfRows_ValueChanged(object sender, EventArgs e)
        {
            NumOfCols.Value = NumOfRows.Value;
        }

        private void NumOfCols_ValueChanged(object sender, EventArgs e)
        {
            NumOfRows.Value = NumOfRows.Value;
        }
    }
}
