using System;
namespace Application{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is the Schmending Machine! How much money do you have?");
            float moneyAmount = float.Parse(Console.ReadLine());
            bool loopFlag = true;
            while(loopFlag){
                Console.WriteLine("Enter product selection (1-5)");
                int selection = int.Parse(Console.ReadLine());
                switch(selection){
                    case 1:
                        if(moneyAmount >= 1.5f){
                            Console.WriteLine("Purchased: Schmapple");
                            moneyAmount -= 1.5f;
                        }
                        else{Console.WriteLine("Sorry you can't afford this broke boy, try again next time!");}
                        break;
                    case 2:
                        if(moneyAmount >= 1f){
                            Console.WriteLine("Purchased: Lightly Used Grape");
                            moneyAmount -= 1f;
                        }
                        else{Console.WriteLine("Sorry you can't afford this broke boy, try again next time!");}
                        break;
                    case 3:
                        if(moneyAmount >= .5f){
                            Console.WriteLine("Purchased: Scent of a Pizza");
                            moneyAmount -= .5f;
                        }
                        else{Console.WriteLine("Sorry you can't afford this broke boy, try again next time!");}
                        break;
                    case 4:
                        if(moneyAmount >= 1.25f){
                            Console.WriteLine("Purchased: Heavily Used Grape");
                            moneyAmount -= 1.25f;
                        }
                        else{Console.WriteLine("Sorry you can't afford this broke boy, try again next time!");}
                        break;
                    case 5:
                        if(moneyAmount >= 2f){
                            Console.WriteLine("Purchased: Banana?");
                            moneyAmount -= 2f;
                        }
                        else{Console.WriteLine("Sorry you can't afford this broke boy, try again next time!");}
                        break;
                }
                Console.WriteLine("Keep purchasing? (y/n)");
                string? choice = Console.ReadLine();
                if(choice == "n" || choice == "N"){loopFlag = false;}
            }
            Console.WriteLine("You have $" + moneyAmount.ToString("F") + " remaining. Have a Schmealthy day!");

        }

    }
}
