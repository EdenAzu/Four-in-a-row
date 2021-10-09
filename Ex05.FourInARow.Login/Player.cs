using System;

namespace C21_Ex05_FourInARow_Logic
{
    public class Player
    {
        private readonly Random r_Random = new Random();

        public Player(char i_TokenSymbol, bool i_IsPlayerHuman = true)
        {
            TokenSymbol = i_TokenSymbol;
            IsHuman = i_IsPlayerHuman;
        }

        public char TokenSymbol { get; }

        public bool IsHuman { get; }

        public int Score { get; set; }

        public int ChooseRandomColumn(int[] i_AvailableColumns)
        {
            return i_AvailableColumns[r_Random.Next(0, i_AvailableColumns.Length)];
        }
    }
}
