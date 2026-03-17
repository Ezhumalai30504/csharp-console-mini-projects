using System;

namespace NestedTask
{
    class NestedTask{
        static void Main()
        {
            Console.Write("Enter Your Age:");
            int UserAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Salary:");
            int UserSalary = int.Parse(Console.ReadLine());

            if(UserAge>=18 || UserAge>=60){
                if(UserSalary>=10000){
                    Console.WriteLine("Your are Eligible For Loan");
                }
                else{
                    Console.WriteLine("Your are not Eligible For Loan");
                }
            }
            else{
                Console.WriteLine("Your Age not for apply for Loan");
            }

        }
    }
}