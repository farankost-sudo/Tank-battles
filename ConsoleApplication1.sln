using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int Tank1 = 250;  // Display current game balance/stats for decision-making
            int Tank2 = 150;
            Random rnd = new Random();
            
            Console.WriteLine("Press 1 to fire the first tank. Press 2 to fire the second tank " + // Explain controls and tank stats so the player knows what to choose
                              "\n First tank Medium tank health points: 150 damage: 50 hit chance: 8/10 " + 
                              "\n Second tank Super-heavy tank health points: 250 damage: 25 hit chance: 6/10 "); // Display current game balance/stats for decision-making
            
            for (byte i = 0; i < 100; i++)
            {
                        short Shot = Convert.ToInt16(Console.ReadLine());
                        switch (Shot)
                        {
                            case 1:
                                Console.WriteLine("Player number 1 fires"); // Informing Players who fires right now
                                int MyShot = rnd.Next(1, 11); 
                                if (MyShot >= 3)
                                {
                                    Tank1 = Tank1 - 50;
                                    Console.WriteLine("Hit. Enemy health: " + Tank1); 
                                }
                                else Console.WriteLine("Armor not penetrated.");

                                break;
                            
                            
                            case 2:
                                Console.WriteLine("Player number 2 fires"); // Informing Players who fires right now
                                int EnemyShot = rnd.Next(1, 11);
                                if (EnemyShot <= 6 )
                                {
                                    Tank2 = Tank2 - 25;
                                    Console.WriteLine("Hit. Enemy health: " + Tank2);
                                }
                                else Console.WriteLine("Armor not penetrated.");
                                break;
                        }

                        if ((Tank2 <= 0) || Tank1 <= 0)
                        {
                            Console.WriteLine("Game over");
                            break;
                        }
            }
        }
    }
}  
