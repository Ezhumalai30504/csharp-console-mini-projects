using System;

namespace ATMTask
{
    class AtmTask
    {
        public static void Main()
        {
            int AtmPin = 1212;
            Console.Write("Enter Your ATM PIN:");
            int UserPin = int.Parse(Console.ReadLine());
            double Balance = 10000;
            int Option = 1;
                
            
            if(AtmPin == UserPin)
            {
                while(Option != 4)
                {
                Console.WriteLine("\n1.Check Balance");
                Console.WriteLine("2.Withdraw Amount");
                Console.WriteLine("3.Deposit Amount");
                Console.WriteLine("4.Exit");

                Console.Write("\nEnter Your Choice:");
                Option = int.Parse(Console.ReadLine());


                switch(Option)
                {
                    case 1:
                        Console.WriteLine("\n Your Current Account Balance is "+Balance);
                        break;

                    case 2:
                        Console.Write("Enter Withraw Amount:");
                        double UserWith = int.Parse(Console.ReadLine());
                        if(Balance<UserWith)
                        {
                            Console.WriteLine("\nInsufficient Balance!");
                        }
                        else
                        {
                            Balance -= UserWith;
                            Console.WriteLine("\nYour Withdraw Amount is "+UserWith+" and Your Current Balance is "+Balance);
                        }
                        break;
                    case 3:
                        Console.Write("Enter Your Deposit Amount:");
                        double Userdep = int.Parse(Console.ReadLine());
                        
                        Balance += Userdep;
                        Console.WriteLine("\nYour Deposit Amount is "+Userdep+" and Your Current Balance is "+Balance);
                        break;

                    case 4:
                        Console.WriteLine("\nThank You for Using ATM!!!");
                        break; 
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;               
                }
               }
            }
            if(AtmPin != UserPin)
            {
                Console.WriteLine("\nIncorrect ATM PIN!");
            }

        }
    }
}