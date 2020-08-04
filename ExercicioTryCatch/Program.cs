using System;
using ExercicioTryCatch.Entities;
using ExercicioTryCatch.Entities.Exceptions;
namespace ExercicioTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                acc.WithDraw(amount);

                Console.WriteLine(acc);

            }
            catch(DomainException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
