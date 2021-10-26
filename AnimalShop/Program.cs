using System;
using System.Threading.Channels;

 
class Program 
    {// Fråga 1. När man inte tänker sig, använda något i classet utanför classen. Om det blir något fel i koden så har man minskad linor av kod som man behöver gå igenom
        //för att hitta felet.
        //Fråga 2. It makes your code look better and you can find things more easily.Exampel: You can sometimes need to use just a string so you can have constructor for that
        //or you need to have both a string and int, so you can make a constructor that includes both or you can just create a empty one, it fills your needs.

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Petshop mr/mrs what do you need ? ");
            AnimalShop minButik = new AnimalShop();
           
        while (true)
            {
                string answer = Console.ReadLine();
            if (answer == "End")
                {
                    Console.WriteLine("Thank you for visiting uss please come again !");
                    break;
                }

            minButik.SellAnimal(answer);
        }

        }

    }
   