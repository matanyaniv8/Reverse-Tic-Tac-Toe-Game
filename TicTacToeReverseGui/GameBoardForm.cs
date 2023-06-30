using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using GameLogic = ReverseTicTacToeLogic.ReverseTicTacToeLogic;

namespace TicTacToeReverseGui
{
    public partial class GameBoardForm : Form
    {
        private const string k_WinningCaptions = "A Win!";
        private const string k_TieCaptions = "A Tie";
        private const string k_AskUserToPlayAnotherRoundMessage = "Would Like To Play Another Round?";
        private string m_FirstPlayerName = "";
        private int m_FirstPlayerScore = 0;
        private string m_SecondPlayerName = "";
        private int m_SecondPlayerScore = 0;
        private int m_BoardSize = 0;
        private int m_CellSize = 0;
        private GameLogic m_GameLogic = null;

        public GameBoardForm(int i_BoardSize, string i_FirstPlayerName, string i_SecondPlayerName, bool i_IsSecondPlayerHuman)
        {
            InitializeComponent();
            m_CellSize = this.Width / i_BoardSize -2;
            int numberOfHumanPlayers = (i_IsSecondPlayerHuman) ? 2 : 1;
            m_BoardSize = i_BoardSize;
            m_GameLogic = new GameLogic(i_BoardSize, numberOfHumanPlayers);
            m_FirstPlayerName = i_FirstPlayerName;
            m_SecondPlayerName = i_SecondPlayerName;
        }

        private void FirstPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            int gridWidth = m_BoardSize * (m_CellSize +10);
            int gridHeight = (m_BoardSize + 2) * m_CellSize;

            this.ClientSize = new Size(gridWidth, gridHeight);
            setLabelsPosition();
            initializeButtons();

        }

        private void setLabelsValues()
        {
            FirstPlayerLabel.Text = $@"{m_FirstPlayerName}: {m_FirstPlayerScore.ToString()}         {m_SecondPlayerName}: {m_SecondPlayerScore.ToString()}";
        }

        private void setLabelsPosition()
        {
            setLabelsValues();
            FirstPlayerLabel.TextAlign = ContentAlignment.BottomCenter ;
        }

        private void initializeButtons()
        {
            for(int row = 0; row < m_BoardSize; row++)
            {
                for(int col = 0; col < m_BoardSize; col++)
                {
                    initializeAButton(row, col);
                }
            }
        }

        private void initializeAButton(int i_RowNumber, int i_ColNumber)
        {
            Button button = new Button();
            string buttonLocationAsIdentifier = $"{i_ColNumber},{i_RowNumber}";
            int distanceBetweenButtons = 2;

            button.Size = new Size(m_CellSize, m_CellSize);
            button.Padding = new Padding(5);
            button.Tag = buttonLocationAsIdentifier;
            button.Location = new Point((m_CellSize+10) * i_RowNumber + 5, (m_CellSize +10) * i_ColNumber +5);
            button.Click += Butten_Clicked;
            this.Controls.Add(button);
            button.Font = new Font(button.Font.FontFamily, button.Font.Size + 10f, FontStyle.Bold);
        }

        private void Butten_Clicked(object sender, EventArgs e)
        {
           int rowIndex = 0;
           int colIndex = 0;
           Button ClickedButton = sender as Button;

           if(ClickedButton != null)
            {
                convertBtnTagToIdices(ref rowIndex, ref colIndex, ClickedButton.Tag.ToString());
            }

            try
            {
                m_GameLogic.PlayMove(rowIndex, colIndex);
                ClickedButton.Enabled = false;
                printBoard();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            proceedGame();
        }

        private void proceedGame()
        {
            string message = k_AskUserToPlayAnotherRoundMessage;
            string messageCaption = "";
            string winnerName = "";
            bool isAPopWindowNeedsToBeSent = false;

            if (m_GameLogic.IsThereAWin())
            {
                winnerName = updateScoreOnAWin();
                message = string.Format($@"The Winner is {winnerName}!
{k_AskUserToPlayAnotherRoundMessage}");
                isAPopWindowNeedsToBeSent = true;
                messageCaption = k_WinningCaptions;
            }
            else if (m_GameLogic.IsThereTie())
            {
                isAPopWindowNeedsToBeSent = true;
                messageCaption = k_TieCaptions;
            }

            if (isAPopWindowNeedsToBeSent)
            {
                askUserToPlayAnotherRound(message, messageCaption);
            }
        }

        private string updateScoreOnAWin()
        {
            string winnerName = "";
            bool isFirstPlayerPlayedLast = m_GameLogic.IsFirstPlayerPlayed();

            if (isFirstPlayerPlayedLast)
            {
                winnerName = m_SecondPlayerName;
                m_SecondPlayerScore++;
            }
            else
            {
                winnerName = m_FirstPlayerName;
                m_FirstPlayerScore++;
            }

            return winnerName;
        }
        private void askUserToPlayAnotherRound(String i_Message, string i_PopUpWindowTitle)
        {
            DialogResult usersAnswer = MessageBox.Show(i_Message, i_PopUpWindowTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (usersAnswer == DialogResult.Yes)
            {
                m_GameLogic.BoardRestart();
                printBoard();
            }
            else
            {
                this.Close();
            }
        }

        private void convertBtnTagToIdices(ref int i_RowNumber, ref int i_ColNumber, string i_ButtonTag)
        {
            string[] tagIndices = i_ButtonTag.Split(',');

            i_RowNumber = int.Parse(tagIndices[0]);
            i_ColNumber = int.Parse(tagIndices[1]);
        }

        private void printBoard()
        {
            string btnLabel = "";
            string btnTag = "";
            Button cellBtn = null;

            setLabelsPosition();

            for (int row = 0; row < m_BoardSize; row++)
            {
                for(int col = 0;col < m_BoardSize; col++)
                {
                    btnTag = $"{row},{col}";
                    btnLabel = m_GameLogic.GetCellValue(row, col);
                    cellBtn = getButtenByTag(btnTag);
                    cellBtn.Text = btnLabel;
                    cellBtn.Enabled = (btnLabel != "") ? false: true;
                }
            }
        }

        private Button getButtenByTag(string i_Tag)
        {
            Button buttonToReturn = null;

            foreach (Control controlElement in this.Controls)
            {
                if(controlElement is Button btnConversion)
                {
                    if(btnConversion.Tag.ToString() == i_Tag)
                    {
                        buttonToReturn = btnConversion;
                    }
                }
            }

            return buttonToReturn;
        }
    }
}
