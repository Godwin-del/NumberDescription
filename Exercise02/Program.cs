using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a Number");
        string number = Console.ReadLine();
        var result = Regex.Match(number, @"(.{3})\s*$");
        var res = Exercise01.ExtensionMethods.ProcessInterger(number);
        Console.WriteLine(res);
    }
}
