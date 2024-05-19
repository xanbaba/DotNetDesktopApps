namespace BuilderHw;

public class UserValidator : IUserValidator
{
    public bool ValidateFirstName(string firstName)
    {
        return !string.IsNullOrWhiteSpace(firstName) && char.IsUpper(firstName.First());
    }

    public bool ValidateLatsName(string lastName)
    {
        return !string.IsNullOrWhiteSpace(lastName) && char.IsUpper(lastName.First());
    }

    public bool ValidateMiddleName(string middleName)
    {
        return !string.IsNullOrWhiteSpace(middleName) && char.IsUpper(middleName.First());
    }

    public bool ValidatePhone(string phone)
    {
        return !phone.Any(char.IsLetter);
    }

    public bool ValidateAddress(string address)
    {
        return !string.IsNullOrWhiteSpace(address);
    }

    public bool ValidateEmail(string email)
    {
        return !string.IsNullOrWhiteSpace(email) && email.Contains('@') && email.Contains('.');
    }

    public bool ValidateBirthDate(DateOnly birthDate)
    {
        var currentDate = DateOnly.FromDateTime(DateTime.Now);
        return (currentDate.Year - birthDate.Year) switch
        {
            > 18 => true,
            18 when currentDate.Month > birthDate.Month => true,
            18 => currentDate.Day >= birthDate.Day,
            _ => false
        };
    }
}