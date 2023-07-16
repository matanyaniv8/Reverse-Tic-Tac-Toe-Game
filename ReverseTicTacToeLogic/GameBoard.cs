using System;

namespace ReverseTicTacToeLogic
{
    internal class GameBoard
    {
        public enum eBoardSigns
        {
            EmptySlot = 0,
            X = 1,
            O = 2
        }

        private eBoardSigns[,] m_Board;
        private int m_BoardSize;
        private bool m_FirstPlayerMove = true;
        private int m_NumberOfMovesRemains = 0;
        private const string k_SlotNotEmptyError = "Slot Is Not Empty";
        private const string k_CellIsNotDefineError = "Cell Is Not In Range Of The Board";
        private const string k_OutOfMovesError = "Out Of Moves";
        internal bool FisrtPlayerTurn
        {
            get
            {
                return m_FirstPlayerMove;
            }
        }

        internal int BoardSize
        {
            get 
            { 
                return m_BoardSize; 
            }
        }

        internal int NumberOfMovesRemains
        {
            get
            {
                return m_NumberOfMovesRemains;
            }
        }

        internal GameBoard(int i_BoardSize)
        {
                m_BoardSize = i_BoardSize;
                m_NumberOfMovesRemains = i_BoardSize * i_BoardSize;
                m_Board = new eBoardSigns[i_BoardSize, i_BoardSize];
        }

        internal bool MakeAMove(int i_Row, int i_Col)
        {
            bool succeededToMakeAMove = false;
            eBoardSigns playerSign = getPlayerSign();
            bool isIndicesInRange = isIndicesAreWithinRangeOfBoardSize(i_Row, i_Col);
            bool isBoardCellAvailable = isSlotAvailable(i_Row, i_Col);
            string possibleError = "";

            if (m_NumberOfMovesRemains > 0)
            {
                if (isIndicesInRange && isBoardCellAvailable)
                {
                    m_Board[i_Row, i_Col] = playerSign;
                    m_FirstPlayerMove = (playerSign == eBoardSigns.X) ? false : true;
                    m_NumberOfMovesRemains--;
                    succeededToMakeAMove = true;
                }
                else
                {
                    possibleError = (isBoardCellAvailable) ? k_CellIsNotDefineError : k_CellIsNotDefineError;
                    throw new Exception(possibleError);
                }
            }
            else
            {
                possibleError = k_OutOfMovesError;
                throw new Exception(possibleError);
            }

            return succeededToMakeAMove;
        }

        internal bool MakeRandomMove()
        {
            bool isRandomAssignedSucceded = false;
            bool isRandomSlotAvailable = false;
            Random rndGenerator = new Random();
            int rowIndex = 0;
            int colIndex = 0;

            while (!isRandomSlotAvailable)
            {
               rowIndex = rndGenerator.Next(0, m_BoardSize + 1);
               colIndex = rndGenerator.Next(0, m_BoardSize + 1);

                if (isSlotAvailable(rowIndex, colIndex))
                {
                    isRandomAssignedSucceded  = MakeAMove(rowIndex, colIndex);
                    isRandomSlotAvailable = true;
                }
            }

            return isRandomAssignedSucceded;
        }

        private eBoardSigns getPlayerSign()
        {
            eBoardSigns sign = m_FirstPlayerMove ? eBoardSigns.X : eBoardSigns.O;

            return sign;
        }

        internal string getBoardValueByIndex(int i_RowNumber, int i_ColNumber)
        {
            string cellValue = null;
            eBoardSigns boardCellValue = m_Board[i_RowNumber, i_ColNumber];

            if(boardCellValue == eBoardSigns.EmptySlot)
            {
                cellValue = "";
            }
            else
            {
                cellValue = boardCellValue.ToString();
            }

            return cellValue;
        }

        private bool isSlotAvailable(int i_Row, int i_Column)
        {
            bool isSlotAvailable = false;

            if (isIndicesAreWithinRangeOfBoardSize(i_Row, i_Column))
            {
                isSlotAvailable = (m_Board[i_Row, i_Column] == eBoardSigns.EmptySlot) ? true : false;
            }

            return isSlotAvailable;
        }

        private bool isIndicesAreWithinRangeOfBoardSize(int i_Row, int i_Column)
        {
            bool isColumnWithInRange = i_Column >= 0 && i_Column < m_BoardSize;
            bool isRowWithInRange = i_Row >= 0 && i_Row < m_BoardSize;
            bool isIndicesAreWithinRange = isColumnWithInRange && isRowWithInRange;

            return isIndicesAreWithinRange;
        }

        private eBoardSigns convertToBoardSigns(int i_NumberToConvert)
        {
            eBoardSigns boardSigns;
            bool isBoardSignValid = Enum.TryParse(i_NumberToConvert.ToString(), out boardSigns);

            if (!isBoardSignValid)
            {
                boardSigns = eBoardSigns.EmptySlot;
            }

            return boardSigns;
        }

        internal bool IsIdentiticalRowExist()
        {
            bool isThereAnIdenticalElementsRow = false;

            for (int row = 0; row < m_BoardSize; row++)
            {
                isThereAnIdenticalElementsRow = isRowElementsIdentical(row);

                if (isThereAnIdenticalElementsRow)
                {
                    break;
                }
            }

            return isThereAnIdenticalElementsRow;
        }

        private bool isRowElementsIdentical(int i_RowIndex)
        {
            bool isElementsSeenSoFarAreTheSame = true;
            eBoardSigns firstElement = m_Board[i_RowIndex, 0];
            eBoardSigns horizontalElement = firstElement;

            for (int col = 0; col < m_BoardSize; col++)
            {
                horizontalElement = m_Board[i_RowIndex, col];

                if (firstElement != horizontalElement || firstElement == eBoardSigns.EmptySlot)
                {
                    isElementsSeenSoFarAreTheSame = false;
                    break;
                }
            }

            return isElementsSeenSoFarAreTheSame;
        }

        internal bool IsIdentiticalColExist()
        {
            bool isThereAnIdenticalElementsColumn = false;

            for (int col = 0; col < m_BoardSize; col++)
            {
                isThereAnIdenticalElementsColumn = isColElementsIdentitical(col);

                if (isThereAnIdenticalElementsColumn)
                {
                    break;
                }
            }

            return isThereAnIdenticalElementsColumn;
        }

        private bool isColElementsIdentitical(int i_ColIndex)
        {
            bool isElementsSeenSoFarAreTheSame = true;
            eBoardSigns firstElement = m_Board[0, i_ColIndex];
            eBoardSigns verticalElement = firstElement;

            for (int row = 1; row < m_BoardSize; row++)
            {
                verticalElement = m_Board[row, i_ColIndex];

                if (firstElement != verticalElement || firstElement == eBoardSigns.EmptySlot)
                {
                    isElementsSeenSoFarAreTheSame = false;
                    break;
                }
            }

            return isElementsSeenSoFarAreTheSame;
        }

        internal bool IsDiagonlElementsIdentitcal()
        {
            bool isElementsSeenSoFarAreTheSame = true;
            eBoardSigns firstElement = m_Board[0, 0];
            eBoardSigns diagonalElement = firstElement;

            for (int i = 1; i < m_BoardSize; i++)
            {
                diagonalElement = m_Board[i, i];

                if (firstElement != diagonalElement || firstElement == eBoardSigns.EmptySlot)
                {
                    isElementsSeenSoFarAreTheSame = false;
                    break;
                }
            }

            return isElementsSeenSoFarAreTheSame;
        }

        internal bool IsSeconderyDiagonalElementsIdentical()
        {
            bool isElementsSeenSoFarAreTheSame = true;
            eBoardSigns firstElement = m_Board[0, BoardSize - 1];
            eBoardSigns seconderyDiagonalElement = firstElement;

            for (int i = 0; i < BoardSize; i++)
            {
                seconderyDiagonalElement = m_Board[i, BoardSize - i - 1];

                if (seconderyDiagonalElement != firstElement || firstElement == eBoardSigns.EmptySlot)
                {
                    isElementsSeenSoFarAreTheSame = false;
                    break;
                }
            }

            return isElementsSeenSoFarAreTheSame;
        }
    }
}
