namespace Patterns;

public interface IUserBuilderHelper
{
    bool ValidateFirstName(string firstName);
    bool ValidateLastName(string lastName);
    bool ValidateMiddleName(string middleName);
    bool ValidateBirthDay(DateOnly birthday);
    bool ValidatePhoneNumber(string phoneNumber);
    bool ValidateEmail(string email);
    bool ValidateAddress(string address);
}