

using System.Globalization;

string financeApp = "VaultPay";
Console.WriteLine(financeApp);


Console.WriteLine("Good day, Mr Dlamini");


decimal balance = 150000.00m;
var culture = new CultureInfo("en-ZA");
Console.WriteLine($"Opening Balance: {balance.ToString("C", culture)}");