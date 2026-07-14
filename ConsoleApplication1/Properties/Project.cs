using System;

namespace AlsoTrainingProject
{
    public class Properties
    {
        static void Nine()
        {

            {
                short user_input = Convert.ToInt16(Console.ReadLine());
                switch (user_input)
                {
                    case 1:
                        Console.WriteLine("Ви вибрали розвідника");
                        break;
                    case 2:
                        Console.WriteLine("Ви обрали солдата");
                        break;
                    case 3: Console.WriteLine("Ви обрали палія");
                        break;
                }
            }
        }
    }
}