using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum GameStatus { Playing, Win, Loss, Draw };

    public class Game
    {
        public (int,char)[,] board =
        {
            { (1,'0'), (2,'0'), (3,'0') },
            { (4,'0'), (5,'0'), (6,'0') },
            { (7,'0'), (8,'0'), (9,'0') },
        };

        private int[,] solutions =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 },
            { 1, 5, 9 },
            { 3, 5, 7 }
        };

        public GameStatus status = GameStatus.Playing;

        public void DrawBoard()
        {
            Console.WriteLine("   _____ _____ _____");
            Console.WriteLine("  |     |     |     |");
            Console.WriteLine("  |  {0}  |  {1}  |  {2}  |", Display(0,0), Display(0, 1), Display(0, 2));
            Console.WriteLine("  |_____|_____|_____|");
            Console.WriteLine("  |     |     |     |");
            Console.WriteLine("  |  {0}  |  {1}  |  {2}  |", Display(1, 0), Display(1, 1), Display(1, 2));
            Console.WriteLine("  |_____|_____|_____|");
            Console.WriteLine("  |     |     |     |");
            Console.WriteLine("  |  {0}  |  {1}  |  {2}  |", Display(2, 0), Display(2, 1), Display(2, 2));
            Console.WriteLine("  |_____|_____|_____|");
            Console.WriteLine();
        }

        public GameStatus CheckStatus()
        {

            if (board[1, 1].Item2 == 'X')
            {
                if (board[0, 0].Item2 == 'X' & board[2, 2].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
                else if (board[0, 1].Item2 == 'X' & board[2, 1].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
                else if (board[1, 0].Item2 == 'X' & board[1, 2].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
                else if (board[2,0].Item2 == 'X' & board[0,2].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
            }
            else if (board[0, 0].Item2 == 'X')
            {
                if (board[0, 1].Item2 == 'X' & board[0,2].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
                else if (board[1, 0].Item2 == 'X' & board[2,0].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
            }

            if (board[2, 2].Item2 == 'X')
            {
                if (board[0, 2].Item2 == 'X' & board[1, 2].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
                else if (board[2, 0].Item2 == 'X' & board[2, 1].Item2 == 'X')
                {
                    return GameStatus.Win;
                }
            }

            if (board[1, 1].Item2 == 'O')
            {
                if (board[0, 0].Item2 == 'O' & board[2, 2].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
                else if (board[0, 1].Item2 == 'O' & board[2, 1].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
                else if (board[1, 0].Item2 == 'O' & board[1, 2].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
                else if (board[2, 0].Item2 == 'O' & board[0, 2].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
            }
            else if (board[0, 0].Item2 == 'O')
            {
                if (board[0, 1].Item2 == 'O' & board[0, 2].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
                else if (board[1, 0].Item2 == 'O' & board[2, 0].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
            }

            if (board[2, 2].Item2 == 'O')
            {
                if (board[0, 2].Item2 == 'O' & board[1, 2].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
                else if (board[2, 0].Item2 == 'O' & board[2, 1].Item2 == 'O')
                {
                    return GameStatus.Loss;
                }
            }

            int count = 0;
            foreach ((int, char) x in board)
            {
                if (x.Item2 != '0')
                    count++;
            }

            if (count == 9)
                return GameStatus.Draw;
            else
                return GameStatus.Playing;
        }

        public bool UpdateBoard(int choice, char player)
        {
            switch (choice)
            {
                case 1:
                    if (board[0, 0].Item2 == '0')   
                    {
                        board[0, 0].Item2 = player;
                        return true;
                    }
                    return false;
                case 2:
                    if (board[0, 1].Item2 == '0')
                    {
                        board[0, 1].Item2 = player;
                        return true;
                    }
                    return false;
                case 3:
                    if (board[0, 2].Item2 == '0')
                    {
                        board[0, 2].Item2 = player;
                        return true;
                    }
                    return false;
                case 4:
                    if (board[1, 0].Item2 == '0')
                    {
                        board[1, 0].Item2 = player;
                        return true;
                    }
                    return false;
                case 5:
                    if (board[1, 1].Item2 == '0')
                    {
                        board[1, 1].Item2 = player;
                        return true;
                    }
                    return false;
                case 6:
                    if (board[1, 2].Item2 == '0')
                    {
                        board[1, 2].Item2 = player;
                        return true;
                    }
                    return false;
                case 7:
                    if (board[2, 0].Item2 == '0')
                    {
                        board[2, 0].Item2 = player;
                        return true;
                    }
                    return false;
                case 8:
                    if (board[2, 1].Item2 == '0')
                    {
                        board[2, 1].Item2 = player;
                        return true;
                    }
                    return false;
                case 9:
                    if (board[2, 2].Item2 == '0')
                    {
                        board[2, 2].Item2 = player;
                        return true;
                    }
                    return false;
            }

            return false;
        }

        public void AIturn()
        {
            // Determine who has what squares
            List<int> mySquares = new List<int>();
            List<int> humanSquares = new List<int>();
            foreach ((char,char) c in board)
            {
                if (c.Item2 == 'O')
                    mySquares.Add(c.Item1);
                else if (c.Item2 == 'X')
                    humanSquares.Add(c.Item1);
            }

            // Analyze patterns among squares for each player to determine
            // if either is close to win and a) either complete my win or b) intercept hers

            int count;
            int missingSquare;
            bool moveMade = false;

            for (int i = 0; i < 8; i++)
            {
                count = 0;
                missingSquare = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (mySquares.Contains(solutions[i, j]))
                        count++;
                    else
                        missingSquare = solutions[i, j];
                }

                if (count == 2)
                {
                    if (UpdateBoard(missingSquare, 'O'))
                    {
                        moveMade = true;
                        break;
                    }
                }
            }

            if (!moveMade)
            {
                for (int i = 0; i < 8; i++)
                {
                    count = 0;
                    missingSquare = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        if (humanSquares.Contains(solutions[i, j]))
                            count++;
                        else
                            missingSquare = solutions[i, j];
                    }

                    if (count == 2)
                    {
                        if (UpdateBoard(missingSquare, 'O'))
                        {
                            break;
                        }
                    }

                    if (i == 7)
                    {
                        Random rand = new Random();
                        bool x = UpdateBoard(rand.Next(1, 10), 'O');

                        while (x == false)
                        {
                            x = UpdateBoard(rand.Next(1, 10), 'O');
                        }
                    }
                }
            }
        }

        public void Reset()
        {
            board = new (int, char)[,]
            {
                { (1, '0'), (2, '0'), (3, '0') },
                { (4, '0'), (5, '0'), (6, '0') },
                { (7, '0'), (8, '0'), (9, '0') },
            };

            status = GameStatus.Playing;
        }

        // Helper function for DrawBoard, returning either the number of a
        // given square or the char value of the player that has claimed it
        public char Display(int x, int y)
        {
            if (board[x, y].Item2 == '0')
                return (char)(board[x, y].Item1 + 48);
            else
                return board[x, y].Item2;
        }

    }

    class Program
    {
        static int HumanTurn()
        {
            bool parse = false;
            int[] options = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Please choose a square by typing in its number and pressing enter: ");

            parse = Int32.TryParse(Console.ReadLine(), out int input);

            while (!parse)
            {
                Console.WriteLine("Incorrect input, please renter a choice, numbering from 1 through 9.");
                parse = Int32.TryParse(Console.ReadLine(), out input);
            }

            foreach (int x in options)
            {
                if (x == input)
                    return input;
            }

            return input;
        }

        static bool EndgameMenu(GameStatus x)
        {
            bool quit = false;
            string endgameMsg = "";
            if (x == GameStatus.Win)
            {
                endgameMsg = "You won, good job!";
            }
            else if (x == GameStatus.Loss)
            {
                endgameMsg = "You lost, sorry :(";
            }
            else if (x == GameStatus.Draw)
            {
                endgameMsg = "The game ended in a draw.";
            }

            Console.WriteLine();
            Console.WriteLine(endgameMsg);
            Console.WriteLine();
            Console.Write("Play again? Type \"y\" for yes or \"n\" for no: ");
            string input = Console.ReadLine();

            switch (input[0])
            {
                case 'y':
                    quit = false;
                    break;
                case 'n':
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Improper input. Exiting application.");
                    quit = true;
                    break;
            }

            return quit;
        }

        static void Main()
        {
            Random rando = new Random();
            bool quit = false;
            bool endgame = false;
            bool success;

            Game game = new Game();

            Console.WriteLine("TIC TAC TOE\n\n");
            while (!quit)
            {
                game.Reset();

                while (game.CheckStatus() == GameStatus.Playing)
                {
                    game.DrawBoard();
                    endgame = false;

                    do
                    {
                        success = game.UpdateBoard(HumanTurn(), 'X');
                        if (!success)
                            Console.WriteLine("That spot is already taken!");
                    }
                    while (!success);

                    if (game.CheckStatus() == GameStatus.Win)
                    {
                        game.DrawBoard();
                        quit = EndgameMenu(GameStatus.Win);
                        endgame = true;
                    }
                    else if (game.CheckStatus() == GameStatus.Loss)
                    {
                        game.DrawBoard();
                        quit = EndgameMenu(GameStatus.Loss);
                        endgame = true;
                    }
                    else if (game.CheckStatus() == GameStatus.Draw)
                    {
                        game.DrawBoard();
                        quit = EndgameMenu(GameStatus.Draw);
                        endgame = true;
                    }

                    if (!quit & !endgame)
                    {
                        game.AIturn();

                        if (game.CheckStatus() == GameStatus.Win)
                        {
                            game.DrawBoard();
                            quit = EndgameMenu(GameStatus.Win);
                        }
                        else if (game.CheckStatus() == GameStatus.Loss)
                        {
                            game.DrawBoard();
                            quit = EndgameMenu(GameStatus.Loss);
                        }
                        else if (game.CheckStatus() == GameStatus.Draw)
                        {
                            game.DrawBoard();
                            quit = EndgameMenu(GameStatus.Draw);
                        }
                    }

                }

            }

        }
        
    }
}
