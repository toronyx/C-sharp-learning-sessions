using System.Diagnostics.CodeAnalysis;
using static MaybeNullExample;

string? nullableString;
nullableString = null;

if (StringNotNull(nullableString))
{
    Console.WriteLine(nullableString.Length);
}

if (StringNotNull_NoAttribute(nullableString))
{
    Console.WriteLine(nullableString.Length);
}




public static class MaybeNullExample
{
    public static bool StringNotNull([NotNullWhen(true)]string? str)
    {
        return str != null;
    }

    public static bool StringNotNull_NoAttribute(string? str)
    {
        return str != null;
    }
}











/*
string testGoodString = "hello";
string testBadString = null;

string errorMessage;

MaybeNullExample.BetterValidate(testGoodString, out errorMessage);
Console.WriteLine($"error message after good string: {errorMessage}");

MaybeNullExample.BetterValidate(testBadString, out errorMessage);
Console.WriteLine($"error message after bad string: {errorMessage}");


if (!MaybeNullExample.BetterValidate(testBadString, out errorMessage))
{
    MaybeNullExample.FailIfNull(errorMessage);
}

public class MaybeNullExample
{
    public static bool Validate(string str, out string errorMessage)
    {
        if (str == null || str == "")
        {
            errorMessage = "String is empty or null!";
            return false;
        }
        else
        {
            errorMessage = null;
            return true;
        }
    }

    public static bool BetterValidate(string str, [MaybeNullWhen(true)] out string errorMessage)
    {
        if (str == null || str == "")
        {
            errorMessage = "String is empty or null!";
            return false;
        }
        else
        {
            errorMessage = null;
            return true;
        }
    }

    public static void FailIfNull(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException();
        }
        return;
    }
}*/