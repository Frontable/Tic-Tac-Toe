
namespace Tic_Tac_Toe
{
    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            string name = "X";
            start();
        }


        static void start()
        {
            Console.Title = "Tic Tac Toe";
            Console.WriteLine("Hello.");
            drawBoard();
            while(winCon() == false)
            {
                askPlayer("X");
                if (winCon() == true)
                    break;
                askPlayer("O");
            }
        }

        static void drawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("| " + board[i] + " | " + board[i + 1] + " | " + board[i + 2] + " |");
            }
            
        }

        static void askPlayer(string player)
        {
            Console.WriteLine("Enter Input: ");
            int select = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0;i < board; i++) { }
        }

        static Boolean winCon()
        {
            return false;
        }

    }

}