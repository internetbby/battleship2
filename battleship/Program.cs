using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int random = generator.Next(0,3);

            System.Console.WriteLine("input player 1 name");
            string player1 = Console.ReadLine(); // skriver in namn

            string[] player2name = {"Adam", "Bob", "Lizzie"};

            string player2 =player2name[random]; //väljer random name från arrayen 

            int playerHealth1 = 50;
            int playerHealth2 = 50;  //start health

            Console.Clear();
            

            while (playerHealth1 > 0 && playerHealth2 > 0){
                random = generator.Next(1,10);
                playerHealth1 = playerHealth1 - random; 
                System.Console.WriteLine( player1 +  " health was decreased by " + random);
                    if (playerHealth1 <  0){
                        playerHealth1 = 0;
                    }
                System.Console.WriteLine(playerHealth1);
                Console.ReadLine(); // första rundan för player 1
                Console.Clear();

                random = generator.Next(1,10);
                playerHealth2 = playerHealth2 - random;
                System.Console.WriteLine(player2 +" health was decreased by " + random);
                if (playerHealth2 <  0){
                        playerHealth2 = 0;
                    }

                System.Console.WriteLine(playerHealth2);
                Console.ReadLine(); // player 2 rundan
                Console.Clear();


            }

            if (playerHealth1 > playerHealth2){
                System.Console.WriteLine(player1 + " wins");
            }
            else if ( playerHealth2 > playerHealth1){
                System.Console.WriteLine(player2 +" wins");
            }
            else {
                System.Console.WriteLine("tied!");
            }

            Console.ReadLine();
        }
    }
}
