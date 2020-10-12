using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int random = generator.Next(0,3);

            Art();
            Console.ReadLine();

            System.Console.WriteLine("input player 1 name");
            string player1 = Console.ReadLine(); // skriver in namn

            string[] player2name = {"Adam", "Bob", "Lizzie", "Sadie", "Berit", "Yarin"};

            string player2 =player2name[random]; //väljer random name från arrayen 

            int playerHealth1 = 100;
            int playerHealth2 = 100;  //start health

            Console.Clear();
            

            while (playerHealth1 > 0 &&  playerHealth2 > 0){

                //player turn

                if (playerHealth1!= 0){
                System.Console.WriteLine("do you want low-damage attack, or high-damage attack");
                System.Console.WriteLine("1) low damage    2) high damage");
                

                playerHealth2 = PlayerModifier(playerHealth2, player2, true);
                
                System.Console.WriteLine(player2 + " health is " + playerHealth2);
                Console.ReadLine();
                Console.Clear();

                }
                

                //computer turn 

                if (playerHealth2 != 0){
                playerHealth1 = PlayerModifier(playerHealth1, player1, false);

                System.Console.WriteLine(player1 + " health is " + playerHealth1);
                Console.ReadLine(); 
                Console.Clear();


                }


                
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

        
        static void Art(){
            System.Console.WriteLine(@"                      # #  ( )
                                  ___#_#___|__
                              _  |____________|  _
                       _=====| | |            | | |==== _
                 =====| |.---------------------------. | |====
   <--------------------'   .  .  .  .  .  .  .  .   '--------------/
     \                                                             /
      \_______________________________________________WWS_________/
  wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
   wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww 
                        BATTLESHIP");

        }


        static int TryParseBool(string input)
        {
            int inputInt; 
            bool lyckad = int.TryParse(input, out inputInt);
            while (lyckad == false || inputInt > 2){
                System.Console.WriteLine("input valid answer");
                input = Console.ReadLine();
                lyckad = int.TryParse(input, out inputInt);
            }

            return inputInt; 
        }

        static int PlayerModifier(int playerHealth, string name, bool rnd){
            
            
            Random generator = new Random();
            int random = generator.Next (1,100); 
            int inputInt; 

            if (rnd == false){ // om datorn kör så randomiseras inputint istället för inputint = readline. 
                random = generator.Next(1,3);
                inputInt = random;
            }
            else{
                string input= Console.ReadLine();
                inputInt = TryParseBool(input);
            }

            random = generator.Next(1,100);

            

            if (inputInt == 1){
                if (rnd == false){
                    System.Console.WriteLine("computer chose low dmg attack"); //vad datorn "valde" 
                }
                if (random > 10){
                    random = generator.Next(5,10); //attack dmg som sedan plir playerhealth - random 
                    playerHealth = playerHealth - random;
                    System.Console.WriteLine(name+ " health was decreased by " + random);
                    if (playerHealth < 0){ // om playerhealth blur mindre än 0 så läggs den till 0, inga negativa värden
                        playerHealth = 0;
                    }
                
                }
                else{
                    System.Console.WriteLine("miss!");
                }
            }

            if (inputInt == 2){
                if (rnd== false){
                    System.Console.WriteLine("computer chose high damage attack");
                }
                if (random > 70){
                    random = generator.Next(50,100); //samma process. Lägga in i en metod? 
                    playerHealth = playerHealth - random;
                    System.Console.WriteLine(name+ " health was decreased by " + random);
                    if (playerHealth < 0){
                        playerHealth = 0;
                    }

            }
            else {
                System.Console.WriteLine("miss!");
            }
        }
            
        return playerHealth; 
    }
}

}

