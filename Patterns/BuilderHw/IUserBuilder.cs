namespace BuilderHw;

public interface IUserBuilder
{
    public User Build();
    public IUserBuilder Reset();

    // Methods for building the properties of User class 
    public IUserBuilder AddFirstName(string firstName);
    public IUserBuilder AddLastName(string lastName);
    public IUserBuilder AddMiddleName(string middleName);
    public IUserBuilder AddPhone(string phone);
    public IUserBuilder AddAddress(string address);
    public IUserBuilder AddEmail(string email);
    public IUserBuilder AddBirthDate(DateOnly birthDate);
}