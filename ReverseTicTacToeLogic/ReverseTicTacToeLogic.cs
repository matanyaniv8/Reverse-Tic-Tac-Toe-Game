using System;

namespace ReverseTicTacToeLogic
{
    public class ReverseTicTacToeLogic
    {
        private GameBoard m_Board;
        private readonly int r_MinimalBoardSize = 4;
        private readonly int r_MaximalBoardSize = 10;
        private const int k_MaxNumberOfPlayers = 2;
        private bool m_IsSecondPlayerHuman = true;
        private bool m_ComputerMoveExecutedLast = false;

        public ReverseTicTacToeLogic(int i_BoardSize, int i_NumberOfPlayers= k_MaxNumberOfPlayers)
        {
            if (isBoardSizeWithinRange(i_BoardSize) && i_NumberOfPlayers <= k_MaxNumberOfPlayers)
            {
                m_Board = new GameBoard(i_BoardSize);
                m_IsSecondPlayerHuman = (i_NumberOfPlayers != k_MaxNumberOfPlayers) ? false : true;
            }
            else
            {
                throw new ArgumentException("Size not acceptable");
            }
        }

        public int MinimalBoardSize
        {
            get
            {
                return r_MinimalBoardSize;
            }
        }

        public int MaximalBoardSize
        {
            get
            {
                return r_MaximalBoardSize;
            }
        }

        private bool isBoardSizeWithinRange(int i_BoardSize)
        {
            bool isBoardSizeValid = false;

            if (i_BoardSize >= r_MinimalBoardSize && i_BoardSize <= r_MaximalBoardSize)
            {
                isBoardSizeValid = true;
            }

            return isBoardSizeValid;
        }

        public bool PlayMove(int i_Row, int i_Column)
        {
            bool succeededToMakeMove = false;

            m_ComputerMoveExecutedLast = false;

            if (!m_IsSecondPlayerHuman && m_Board.FisrtPlayerTurn == true)
            {
                succeededToMakeMove = m_Board.MakeAMove(i_Row, i_Column);

                if (!IsThereAWin() && !IsThereTie())
                {
                    succeededToMakeMove = m_Board.MakeRandomMove();
                    m_ComputerMoveExecutedLast = true;
                }
            }
            else
            {
                succeededToMakeMove = m_Board.MakeAMove(i_Row, i_Column);
            }

            return succeededToMakeMove;
        }

        public string GetCellValue(int i_RowNumber, int i_ColumnNumber)
        {
            return m_Board.getBoardValueByIndex(i_RowNumber, i_ColumnNumber);
        }

        public bool IsFirstPlayerPlayed()
        {
            bool isFirstPlayerPlayedLastTurn = false;
            
            if(!m_IsSecondPlayerHuman && m_ComputerMoveExecutedLast)
            {
                isFirstPlayerPlayedLastTurn = false;
            }
            else if (m_Board.FisrtPlayerTurn == false)
            {
                isFirstPlayerPlayedLastTurn = true;
            }

            return isFirstPlayerPlayedLastTurn;
        }

        public bool IsThereTie()
        {
            bool isATie = (m_Board.NumberOfMovesRemains == 0);

            return isATie;
        }

        public bool IsThereAWin()
        {
            bool isOppenentLosses = m_Board.IsDiagonlElementsIdentitcal() || m_Board.IsSeconderyDiagonalElementsIdentical() || m_Board.IsIdentiticalColExist() || m_Board.IsIdentiticalRowExist();

            return isOppenentLosses;
        }

        public void BoardRestart()
        {
            m_Board = new GameBoard(m_Board.BoardSize);
        }
    }
}