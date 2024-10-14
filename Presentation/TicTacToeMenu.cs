using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPlayersTicTacToe.Controller;

namespace TwoPlayersTicTacToe.Presentation
{
    internal class TicTacToeMenu
    {
        public static bool Toggle = true;
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcom let's play!");
            Console.WriteLine(TicTacToeController.DisplayBoard());

            while (true)
            {

                ExecuteGame(Toggle);
                Toggle = !Toggle;
            }

        }

        public static void ExecuteGame(bool player)
        {
            switch (player)
            {
                case true:
                    Player("Player 1",'x');
                    break;

                case false:
                    Player("Player 2",'o');
                    break;

                default:
                    break;
            }
        }

        public static void Player(string player,char turn)
        {
            //string player = Toggle ? "Player 1" : "Player 2";
            //char turn = Toggle ? 'x' : 'o';
            Console.WriteLine($"Player {player} turn 'x' :\n" +
                $"Choose the box value to enter {turn}, from the board\n");

            int index = int.Parse(Console.ReadLine());

            try
            {
                DeclareResult(TicTacToeController.TakeResponse(index, turn), player);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Player(player,turn);
            }
            
        }


        public static void DeclareResult(string result, string whoIsPlaying)
        {
            Console.WriteLine(TicTacToeController.DisplayBoard());
            if (result == "win")
            {
                Console.WriteLine($"{whoIsPlaying} won!");
                Environment.Exit(0);
            }
            else if (result == "draw")
            {
                Console.WriteLine("Game draw!");
                Environment.Exit(0);
            }
            return;
        }
    }
}
