
namespace Tic_Tac_Toe
{
    class Program
    {
        static string[] board = new string[9];
        static void initializeBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = i.ToString();
            }
        }
        static void Main(string[] args)
        {
            //string name = "X";
            initializeBoard();  
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
            for (int i = 0; i < 9; i+=3)
            {
                Console.WriteLine("|   " + board[i] + "   |   " + board[i + 1] + "   |   " + board[i + 2] + "   |");
            }
            
        }

        static void askPlayer(string player)
        {
            Console.WriteLine("Player " + player + " plaes enter a number from 0 to 8: ");

            int select = Convert.ToInt32(Console.ReadLine());
            board[select] = player;
            drawBoard();
        }

        static Boolean winCon()
        {

            if (String.Equals(board[0], board[1]) && String.Equals(board[1], board[2]))
            {
                Console.WriteLine("GG");
                return true;
            }    
         
            if (String.Equals(board[3], board[4]) && String.Equals(board[4], board[5]))
            {
                Console.WriteLine("GG");
                return true;
            }

            return false;
                
        }

    }

}