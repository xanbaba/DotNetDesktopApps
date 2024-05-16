namespace Patterns;

public interface IUserBuilder
{
    IUserBuilder AddFirstName(string firstName);
    IUserBuilder AddLatsName(string lastName);
    IUserBuilder AddMiddleName(string middleName);
    IUserBuilder AddBirthday(DateOnly birthday);
    IUserBuilder AddPhoneNumber(string phoneNumber);
    IUserBuilder AddAddress(string address);
    IUserBuilder AddEmail(string email);
    IUserBuilder Reset();

    IUser Build();
}