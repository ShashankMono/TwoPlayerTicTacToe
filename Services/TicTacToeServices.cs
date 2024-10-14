using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayersTicTacToe.Services
{
    internal class TicTacToeServices
    {
        public static bool CheckWin(List<Char> Board, char choice)
        {
            if (Board[0] + Board[1] + Board[2] == choice * 3
                || Board[3] + Board[4] + Board[5] == choice * 3
                || Board[6] + Board[7] + Board[8] == choice * 3
                || Board[0] + Board[3] + Board[6] == choice * 3
                || Board[1] + Board[4] + Board[7] == choice * 3
                || Board[2] + Board[5] + Board[8] == choice * 3
                || Board[0] + Board[4] + Board[8] == choice * 3
                || Board[2] + Board[4] + Board[6] == choice * 3
                )
            {
                return true;
            }
            return false;
        }
    }
}
