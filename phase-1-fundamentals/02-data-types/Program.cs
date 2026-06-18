using System;
using System.Globalization;

class Program
{
    
    static void Main (String[] args)
    {
         // Personal Details
    string firstName = "Morena";
    string lastName = "Dlamini";

    // Bank Account Details
    long accountNumber = 48594930394950;
    string currencyCode = "ZAR";

    // Account Balance
    decimal balance = 1450000.00m;
    var culture = new CultureInfo("en-ZA");

    // Account Status 
    bool accountStatus = true;
    
    Console.WriteLine("Name: " + firstName + " " + lastName);
    Console.WriteLine("Account Number: " + accountNumber);
    Console.WriteLine("Currency Code: " + currencyCode);
    Console.WriteLine($"Opening Balance: {balance.ToString("C", culture)}");
    Console.WriteLine(accountStatus);
    }
}

    
