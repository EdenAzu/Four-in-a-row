using System.Collections.Generic;

namespace C21_Ex05_FourInARow_Logic
{
    public class GameBoard
    {
        private readonly byte r_Columns;
        private readonly byte r_Rows;
        private char[,] m_Board;

        public GameBoard(byte i_Columns, byte i_Rows)
        {
            r_Columns = i_Columns;
            r_Rows = i_Rows;
            CleanBoard();
        }

        public void CleanBoard()
        {
            m_Board = new char[r_Rows, r_Columns];
        }

        public bool CheckIfFourConnectedByToken(char i_PlayerToken)
        {
            return horizontalCheck(i_PlayerToken) || verticalCheck(i_PlayerToken)
                                                  || ascendingDiagonalCheck(i_PlayerToken)
                                                  || descendingDiagonalCheck(i_PlayerToken);
        }

        public string GetTokenFromCell(int i_Row, int i_Columns)
        {
            char token = m_Board[i_Row, i_Columns];
            return new string(token, 1);
        }

        private bool descendingDiagonalCheck(char i_PlayerToken)
        {
            bool checkResult = false;

            for (int i = 3; i < r_Rows; i++)
            {
                for (int j = 3; j < r_Columns; j++)
                {
                    if (m_Board[i, j] == i_PlayerToken && m_Board[i - 1, j - 1] == i_PlayerToken
                                                      && m_Board[i - 2, j - 2] == i_PlayerToken
                                                      && m_Board[i - 3, j - 3] == i_PlayerToken)
                    {
                        checkResult = true;
                    }
                }
            }

            return checkResult;
        }

        private bool ascendingDiagonalCheck(char i_PlayerToken)
        {
            bool checkResult = false;

            for (int i = 3; i < r_Rows; i++)
            {
                for (int j = 0; j < r_Columns - 3; j++)
                {
                    if (m_Board[i, j] == i_PlayerToken && m_Board[i - 1, j + 1] == i_PlayerToken
                                                      && m_Board[i - 2, j + 2] == i_PlayerToken
                                                      && m_Board[i - 3, j + 3] == i_PlayerToken)
                    {
                        checkResult = true;
                    }
                }
            }

            return checkResult;
        }

        private bool verticalCheck(char i_PlayerToken)
        {
            bool checkResult = false;

            for (int i = 0; i < r_Rows - 3; i++)
            {
                for (int j = 0; j < r_Columns; j++)
                {
                    if (m_Board[i, j] == i_PlayerToken && m_Board[i + 1, j] == i_PlayerToken
                                                      && m_Board[i + 2, j] == i_PlayerToken
                                                      && m_Board[i + 3, j] == i_PlayerToken)
                    {
                        checkResult = true;
                    }
                }
            }

            return checkResult;
        }

        private bool horizontalCheck(char i_PlayerToken)
        {
            bool checkResult = false;

            for (int j = 0; j < r_Columns - 3; j++)
            {
                for (int i = 0; i < r_Rows; i++)
                {
                    if (m_Board[i, j] == i_PlayerToken && m_Board[i, j + 1] == i_PlayerToken
                                                      && m_Board[i, j + 2] == i_PlayerToken
                                                      && m_Board[i, j + 3] == i_PlayerToken)
                    {
                        checkResult = true;
                    }
                }
            }

            return checkResult;
        }

        public bool CheckForTie()
        {
            bool isTie = true;

            for (int columnIndex = 0; columnIndex < r_Columns; columnIndex++)
            {
                if (m_Board[0, columnIndex] == '\0')
                {
                    isTie = false;
                    break;
                }
            }

            return isTie;
        }

        public void InsertCoin(int i_ColumnChoice, char i_Token)
        {
            bool isInsert = false;
            int indexRow = r_Rows - 1;
            while (!isInsert)
            {
                if (m_Board[indexRow, i_ColumnChoice - 1] == 'X' || m_Board[indexRow, i_ColumnChoice - 1] == 'O')
                {
                    indexRow--;
                }
                else
                {
                    m_Board[indexRow, i_ColumnChoice - 1] = i_Token;
                    isInsert = true;
                }
            }
        }

        public int[] GetAvailableColumns()
        {
            List<int> availableColumns = new List<int>();
            for (int column = 1; column <= r_Columns; column++)
            {
                if (!IsColumnFull(column))
                {
                    availableColumns.Add(column);
                }
            }

            return availableColumns.ToArray();
        }

        public bool IsColumnFull(int i_Column)
        {
            return m_Board[0, i_Column - 1] == 'X' || m_Board[0, i_Column - 1] == 'O';
        }
    }
}