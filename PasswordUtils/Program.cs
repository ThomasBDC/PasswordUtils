// See https://aka.ms/new-console-template for more information
using PasswordUtils;
string userWantsContinue;

do
{

    Console.WriteLine("Please enter your password. ");

    string password = Console.ReadLine();

    var passwordStrength = PasswordTester.GetStrengthPassword(password);

    Console.WriteLine("Your password is " + passwordStrength);

    Console.WriteLine("Voulez-vous continuer ? (o/n)");
    userWantsContinue = Console.ReadLine();

} while (userWantsContinue.Equals("o", StringComparison.OrdinalIgnoreCase));