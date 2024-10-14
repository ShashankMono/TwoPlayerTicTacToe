using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPlayersTicTacToe.Exceptions;
using TwoPlayersTicTacToe.Services;

namespace TwoPlayersTicTacToe.Controller
{
    internal class TicTacToeController
    {
        public static List<char> Board = new List<char>()
        { '1','2','3','4','5','6','7','8','9'};
        public static int CountTurn = 0;

        public static string DisplayBoard()
        {
            return $"{Board[0]} | {Board[1]} | {Board[2]}\n" +
                $"- - - - - -\n" +
                $"{Board[3]} | {Board[4]} | {Board[5]}\n" +
                $"- - - - - -\n" +
                $"{Board[6]} | {Board[7]} | {Board[8]}\n";
        }

        public static string TakeResponse(int index, char choice)
        {
            if(index < 1 || index > 9)
            {
                throw new IndexOutOfBoundException("Index out of bound, please enter correct index as per board \n");
            }
            if (Board[index - 1] == 'x' || Board [index - 1] == 'o')
            {
                throw new AlreadyUsedPlaceException("Already played on this box!\n");
            }
            Board[index - 1] = choice;
            return CheckWhoWin(choice);
        }

        public static string CheckWhoWin(char choice)
        {
            bool win = false;
            CountTurn++;
            if (CountTurn >= 3)
            {
                win = TicTacToeServices.CheckWin(Board, choice);
            }
            else
            {
                return "";
            }

            if (win == true && CountTurn < 9)
            {
                return "win";
            }
            else if (win == false && CountTurn == 9)
            {
                return "draw";
            }
            return "next";
        }

        //public static string Computer(char choice)
        //{
        //    Random random = new Random();
        //    int index = random.Next(1, 10);
        //    if (Board[index - 1] == 'x' || Board[index - 1] == 'o')
        //    {
        //        return Computer(choice);
        //    }
        //    Board[index - 1] = choice;
        //    return CheckWhoWin(choice);
        //}
    }
}
