using System.Reflection;

namespace Homework8;

internal class Program
{
    private const string PathToFiguresDll =
        "/home/dgalytskyi/Projects/RiderProjects/SystemProgramming/Figures/bin/Debug/net9.0/Figures.dll";

    private const string PathToTextUtilityDll =
        "/home/dgalytskyi/Projects/RiderProjects/SystemProgramming/TextUtility/bin/Debug/net9.0/TextUtility.dll";

    private const string PathToCredentialsCheckerDll =
        "/home/dgalytskyi/Projects/RiderProjects/SystemProgramming/CredentialsChecker/bin/Debug/net9.0/CredentialsChecker.dll";

    private static void Main(string[] args)
    {
        var assembly = Assembly.LoadFrom(PathToFiguresDll);

        var type = assembly.GetType("Figures.Circle");
        object instance = Activator.CreateInstance(type!, 4)!;
        var method = type!.GetMethod("ShowArea");
        method!.Invoke(instance, null);

        type = assembly.GetType("Figures.Rectangle");
        instance = Activator.CreateInstance(type!, 4, 6)!;
        method = type!.GetMethod("ShowArea");
        method!.Invoke(instance, null);

        type = assembly.GetType("Figures.Triangle");
        instance = Activator.CreateInstance(type!, 4, 6, 5)!;
        method = type!.GetMethod("ShowArea");
        method!.Invoke(instance, null);

        assembly = Assembly.LoadFrom(PathToTextUtilityDll);
        type = assembly.GetType("TextUtility.TextUtility");
        
        method = type!.GetMethod("IsPalindrome");
        var result1 = (bool)method!.Invoke(null, ["notapalindrome"])!;
        Console.WriteLine(result1);

        method = type!.GetMethod("WordCount");
        var result2 = (int)method!.Invoke(null, ["Have some bread and tea"])!;
        Console.WriteLine(result2);

        method = type!.GetMethod("Reverse");
        var result3 = (string)method!.Invoke(null, ["Reverse me!"])!;
        Console.WriteLine(result3);
        
        assembly = Assembly.LoadFrom(PathToCredentialsCheckerDll);
        type = assembly.GetType("CredentialsChecker.CredentialsChecker");
        
        method = type!.GetMethod("NameContainsOnlyLetters");
        var result4 = (bool)method!.Invoke(null, ["Dmytro", "Galytskyi", "Ruslanovych"])!;
        Console.WriteLine(result4);
        
        method = type!.GetMethod("AgeContainsOnlyDigits");
        var result5 = (bool)method!.Invoke(null, ["23"])!;
        Console.WriteLine(result5);
        
        method = type!.GetMethod("CheckEmailFormat");
        var result6 = (bool)method!.Invoke(null, ["someemail@gmail.com"])!;
        Console.WriteLine(result6);
    }
}