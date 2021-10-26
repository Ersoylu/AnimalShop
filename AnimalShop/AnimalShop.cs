using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


public class AnimalShop
    {     
        public double money { get; set; }
        

        public Animal SellAnimal (string animalType)
        {
            switch (animalType)
            {
            case "Dog": 
                Dog dog = new Dog();
                Console.WriteLine(
                    "We have Dobermanns as a dog type right now. {0}\nBut they are. {1} \nlast but not least {2}\nSo what do you say? (Yes/No)",
                    dog.Aggression, dog.Guarddog, dog.Intelligence);
                string userinput = Console.ReadLine();
                if (userinput == "Yes")
                {
                    Console.WriteLine("Thank you for the purchase ! (Write 'End' to quit/Animal type to continue)");
                    money += dog.Price;
                    Console.WriteLine("Total Balance of AnimalShop " + money);
                }
                if (userinput == "No")
                {
                    Console.WriteLine("Sorry to hear that, we got Cat and Bird too if you want, else have a good day !\n(Write 'End' to quit/Animal type to continue)");
                }
                return dog;

            case "Cat":
                Cat cat = new Cat();
                Console.WriteLine("We have beautiful Siamase cats. {0} \n{1}\n and {2}\n What do you say ? (Yes/No)", cat.Blueeyes,cat.Camouflage,cat.NotMoult);
                string userinput2 = Console.ReadLine();
                if (userinput2 == "Yes")
                {
                    Console.WriteLine("Thank you for the purchase ! (Write 'End' to quit/Animal type to continue)");
                    money += cat.Price;
                    Console.WriteLine("Total Balance of AnimalShop " + money);
                }
                if (userinput2 == "No")
                {
                    Console.WriteLine("Sorry to hear that, we got Dog and Bird too if you want, else have a good day !\n(Write 'End' to quit/Animal type to continue)");
                }
                return cat;
               
            case "Bird":
                Bird bird = new Bird();
                Console.WriteLine("We have beautiful Cockatoos. {0} {1}and {2} \nSo what's your choice ?(Yes/No)",bird.Social,bird.Scream,bird.Longlife);
                string userinput3 = Console.ReadLine();
                if (userinput3 == "Yes")
                {
                    Console.WriteLine("Thank you for the purchase ! (Write 'End' to quit/Animal type to continue)");
                    money += bird.Price;
                    Console.WriteLine("Total Balance of AnimalShop " + money);
                }
                if (userinput3 == "No")
                {
                    Console.WriteLine("Sorry to hear that, we got Dog and Cat too if you want, else have a good day !\n(Write 'End' to quit/Animal type to continue)");
                }
                return bird;
                
            default:
                Console.WriteLine("Sorry we don't have "+animalType);
                break;
            }
           
            return null;
        }

    }


    public  class Animal
    {
        public double Price { get; set; }
    }

public class Dog : Animal
{
    public string Aggression;
    public string Guarddog;
    public string Intelligence;
    public Dog()
    {
        Guarddog = "Easy trainable type of dog, Their Aggression is very affective on Guarding places. ";
        Aggression = "Dobermanns are often stereotyped as being ferocious and aggressive. ";
        Intelligence = "The Doberman Pinscher has been ranked amongst the most intelligent dog breeds,\nin experimental studies and expert evaluations. ";
        Price = 1500;
    }
}


public class Cat : Animal
{
    public string Blueeyes;
    public string Camouflage;
    public string NotMoult;
    public Cat()
    {
        NotMoult = "The Siamese cats do not moult, and that is perfect for someone do not like hair everywhere in the house. ";
        Camouflage = "Siamese cats can camouflage easily,sometimes it can be impossible to see them (This happens mostly outdoor). ";
        Blueeyes = "Siamese cats born with sharp blue eyes their blue eyes is unique to their type. ";
        Price = 650;
    }
}

    public class Bird : Animal
    {
        public string Social;
        public string Scream;
        public string Longlife;
        public Bird()
        {
            Social="Cockatoos are very social animals, they are often called 'love sponges'\nand They want to be around their human 24/7 " +
                   "and they enjoy nothing more than a,\ngood cuddle with their favorite human !";
            Scream =
                "Cockatoos are notoriously loud.\nA cockatoos contact call can be heard for up to a mile or more away. Especially true early in the morning.\n ";
            Longlife = "They have very long lifetime for a pet, they live between 25 years upp to 65 years.";
            Price = 2000;
        }
    }

