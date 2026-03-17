using System;

namespace UserPassword
{
    class Password
    {
        static void Main()
        {
            //--------------------Do While loop---------------

            int Password = 1122;
            int num = 1;
            Console.Write(" Enter a Password:");
            int UserInput = int.Parse(Console.ReadLine());

            do
            {
              if(UserInput != Password)
              {
                Console.Write(" Your Password is Incorrect!");
                Console.WriteLine(" Your Attempt "+num);
                Console.Write("\n Re-Enter Your Password:");
                UserInput = int.Parse(Console.ReadLine());
                num++;
              }
              if(UserInput == Password)
              {
                Console.WriteLine(" Your Password is Correct");
                num = 4;
              }
            }
            while(num<=3);
            if(UserInput != Password)
             {
                Console.WriteLine("\n Your limit is Reached!");
             }

            //-------------------For loop----------------------

            //  int Pass_word = 1212;
            //  Console.Write(" Enter a Password:");
            //  int User_Input = int.Parse(Console.ReadLine());
 
            //  for(int i=1;i<=3;i++)
            //  {
            //     if(Pass_word != User_Input)
            //     {
            //         Console.Write(" Your Password is Incorrect!");
            //         Console.WriteLine(" Your Attempt "+i);
            //         Console.Write("\n Re-Enter Your Passsword:");
            //         User_Input = int.Parse(Console.ReadLine());
            //     }
            //  }
            //  if(Pass_word == User_Input)
            //     {
            //         Console.WriteLine(" Your Password is Correct");
            //     }
            //  if(Pass_word != User_Input)
            //  {
            //     Console.WriteLine("\n Your limit is Reached!");
            //  }

            //--------------------------while loop-----------------------

            // int PasswordPin = 2121;
            // int no = 1;
            // Console.Write(" Enter a Password:");
            // int UserPin = int.Parse(Console.ReadLine());

            // while(no<=3)
            // {
            //     if(UserPin != PasswordPin)
            //     {
            //         Console.Write(" Your Password is Incorrect!");
            //         Console.WriteLine(" Your Attempt "+no);
            //         Console.Write("\n Re-Enter Your Password:");
            //         UserPin = int.Parse(Console.ReadLine());
            //     }
            //     no++;
            // }
            // if(UserPin == PasswordPin)
            // {
            //     Console.WriteLine(" Your Password is Correct");
            // }
            // if(UserPin != PasswordPin)
            // {
            //     Console.WriteLine("\n Your limit is Reached!");
            // }

        }
    }
}