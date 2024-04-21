using System;// window integrated means system compiler
using System.Threading;//breaking up the parts of the code and makes parallel processing 
namespace TicTacToeGame
{
    class TicTacToe 
    {
        static char[] arr={'0','1','2','3','4','5','6','7','8','9'};// no use of 0
        static int player= 1 ;
        static int choice;
        static int flag =0; // 0=running , 1 =someone win ,-1 =draw

        static void Main(string[] args)
        {
            do{
                Console.Clear();
                Console.WriteLine("player 1 wil be x and player 2 will be o");
                Console.WriteLine("\n");//escape sequence 

                if (player%2==0)
                {
                    Console.WriteLine("player 2 chance");
                }
                else{
                    Console.WriteLine("player 1 chance");
                }

                Console.WriteLine("\n");
                Board();

                choice = int.Parse(Console.ReadLine());

                if (arr[choice]!='x' && arr[choice]!='o')
                {
                    if(player%2==0)
                    {
                        arr[choice]='o';
                        player++;
                    }
                    else
                    {
                        arr[choice]='x';
                        player++; 
                    }
                }
                else
                {
                    Console.WriteLine("already occupied");
                    Console.WriteLine("\n");
                    Console.WriteLine("wait for the board to reload ");
                    Thread.Sleep(2000);//stops the game for 2000mili second 

                }

                flag=Winner();

            }
            while(flag!=1 && flag!=-1);

            Console.Clear();

            if(flag==1)
            {
                Console.WriteLine("player {0} has won",(player%2)+1);

            }
            else{
                Console.WriteLine("draw");
            }
            Console.ReadLine();

        }

        private static void Board()
        {
            //Console.WriteLine("     |       |       ");            
            Console.WriteLine(" {0}   |   {1}   |   {2} ",arr[1],arr[2],arr[3]);
            Console.WriteLine("_____|_______|_______");
            //Console.WriteLine("     |       |       ");
            Console.WriteLine(" {0}   |   {1}   |   {2} ",arr[4],arr[5],arr[6]);
            Console.WriteLine("_____|_______|_______");
            //Console.WriteLine("     |       |       ");
            Console.WriteLine(" {0}   |   {1}   |   {2} ",arr[7], arr[8],arr[9]);
            Console.WriteLine("     |       |       ");          
        }

        private static int Winner()
        {  
            //horizontal
            if(arr[1]==arr[2] && arr[2]==arr[3] )
            {
                return 1;
            }
            else if (arr[4]==arr[5] && arr[5]==arr[6])
            {
                return 1;
            }
            else if (arr[6]==arr[7] && arr[7]==arr[8])
            {
                return 1;
            }

            //vertical
            else if (arr[1]==arr[4] && arr[4]==arr[7])
            {
                return 1;
            }
            else if (arr[2]==arr[5] && arr[5]==arr[8])
            {
                return 1;
            }
            else if (arr[3]==arr[6] && arr[6]==arr[9])
            {
                return 1;
            }
            //diagonal
            else if (arr[1]==arr[5] && arr[5]==arr[9])
            {
                return 1;
            }
            else if (arr[3]==arr[5] && arr[5]==arr[7])
            {
                return 1;
            }

            //draw or not
            else if(arr[1]!='1' && arr[2]!='2' && arr[3]!='3' && arr[4]!='4' && arr[5]!='5' && arr[6]!='6' && arr[7]!='7' && arr[8]!='8' && arr[9]!='9')
            {
                return -1;
            }

            // game is running yet 
            else 
            {
                return 0;
            }
        }
    }
}