using System;

namespace ATM
{
    class FunctionATM
    {
        static double  Balance = 10000;
        static void CheckBalance(int)
        {
            Console.WriteLine("\nYour Current Balance is "+Balance);
        }

        static void WithdrawAmount()
        {
            Console.Write("\nEnter a Withraw Amount:");
            int WithAmt = int.Parse(Console.ReadLine());

            if(Balance < WithAmt)
            {
              Console.WriteLine("\nInsuffient Balance!");
            }
            else
            {
              Balance -= WithAmt;
              Console.WriteLine("\nYour Withraw Amount is "+WithAmt+" and Your Current Balance is "+Balance);  
            }
        }
        static void DepositAmount()
        {
            Console.Write("\nEnter a Deposit Amount:");
            int DepAmt = int.Parse(Console.ReadLine());

            Balance += DepAmt;
            Console.WriteLine("\nYour Deposit Amount is "+DepAmt+" and Your Current Balance is "+Balance); 
        }
        static void Exit()
        {
            Console.WriteLine("\nThank You for Using ATM !!!");
        }
        static void Invalid()
        {
            Console.WriteLine("\nInvalid Option!");
        }

        static void Main()
        {
            int AtmPin = 1212;
            Console.Write("\nEnter Your ATM PIN:");
            int UserPin = int.Parse(Console.ReadLine());
            int Option = 1;
            double Balance = 10000;
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
                        CheckBalance(Balance);
                        break;
                    case 2:
                        WithdrawAmount();
                        break;
                    case 3:
                        DepositAmount();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Invalid();
                        break;    
                  }
                }
            }
            else
            {
                Console.WriteLine("\nIncorrect ATM PIN!!!");
            }
        }
    }
}