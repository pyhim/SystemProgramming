namespace CredentialsChecker;

public class CredentialsChecker
{
    public static bool NameContainsOnlyLetters(string firstName, string secondName, string middleName)
    {
        string toCheck = firstName + secondName + middleName;

        return toCheck.All(char.IsLetter);
    }

    public static bool AgeContainsOnlyDigits(string age)
    {
        return age.All(char.IsDigit);
    }

    public static bool CheckPhoneNumberFormat(string phoneNumber)
    {
        const int maxPhoneNumberLength = 13;

        return !(phoneNumber.Length > maxPhoneNumberLength || phoneNumber[0] != '+');
    }

    public static bool CheckEmailFormat(string emailAddress)
    {
        return emailAddress.Contains('@') && emailAddress.Contains('.');
    }
}