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

            string[] player2name = {"Adam", "Bob", "Lizzie", "Sadie"};

            string player2 =player2name[random]; //väljer random name från arrayen 

            int playerHealth1 = 100;
            int playerHealth2 = 100;  //start health

            Console.Clear();
            

            while (playerHealth1 > 0 &&  playerHealth2 > 0){

                //player turn

                playerHealth2 = PlayerModifier(playerHealth2, player2);
                
                System.Console.WriteLine(player2 + " health is " + playerHealth2);
                Console.ReadLine();
                Console.Clear();


                //computer turn 


                playerHealth2 = PlayerModifier(playerHealth1, player1);

                System.Console.WriteLine(player1 + " health is " + playerHealth1);
                Console.ReadLine(); 
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

        static int PlayerModifier(int playerHealth, string name){
            Random generator = new Random(); 
            int random = generator.Next (1,100);

                if (random > 25){
                    random = generator.Next(1,25);
                    playerHealth = playerHealth - random; 
                    System.Console.WriteLine( name+  " health was decreased by " + random);
                    if (playerHealth <  0){
                        playerHealth = 0;
                    }
                }
                else{
                    System.Console.WriteLine("miss!");
                }

                return playerHealth;
        }
    }
}
