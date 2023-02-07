using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDep = double.Parse(Console.ReadLine());

            newAccount.Deposit(amountToDep);
            double userBalance = newAccount.GetBalance();
            Console.WriteLine($"Your balance is {amountToDep}");



        }
    }
}


//Create a new public class named BankAccount
//In your BankAccount class, create the following:
//A private field of type double named balance with a value of 0
//Define a method named Deposit that will accept a double and store that value in the balance field
//Define a method named GetBalance that will return the amount stored in the balance field
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github
