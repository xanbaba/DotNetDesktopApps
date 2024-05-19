namespace BuilderHw;

public interface IUserValidator
{
    public bool ValidateFirstName(string firstName);
    public bool ValidateLatsName(string lastName);
    public bool ValidateMiddleName(string middleName);
    public bool ValidatePhone(string phone);
    public bool ValidateAddress(string address);
    public bool ValidateEmail(string email);
    public bool ValidateBirthDate(DateOnly birthDate);
}