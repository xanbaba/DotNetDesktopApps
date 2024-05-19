namespace BuilderHw;

public class UserBuilder(IUserValidator userValidator) : IUserBuilder
{
    private User _user = new();

    private bool _isFirstNameInitialized;
    private bool _isLastNameInitialized;

    public User Build()
    {
        if (!_isFirstNameInitialized)
        {
            throw new InvalidOperationException("Initialize FirstName before building the user");
        }
        if (!_isLastNameInitialized)
        {
            throw new InvalidOperationException("Initialize LastName before building the user");
        }

        var user = _user;
        Reset();
        return user;
    }

    public IUserBuilder Reset()
    {
        _user = new User();
        _isFirstNameInitialized = false;
        _isLastNameInitialized = false;
        return this;
    }

    private T GetValidatedProperty<T>(T property, Predicate<T> validator)
    {
        if (validator(property))
        {
            return property;
        }

        throw new ArgumentException($"{property} does not satisfy the validation");
    }

    public IUserBuilder AddFirstName(string firstName)
    {
        _user.FirstName = GetValidatedProperty(firstName, userValidator.ValidateFirstName);
        _isFirstNameInitialized = true;
        return this;
    }

    public IUserBuilder AddLastName(string lastName)
    {
        _user.LastName = GetValidatedProperty(lastName, userValidator.ValidateLatsName);
        _isLastNameInitialized = true;
        return this;
    }

    public IUserBuilder AddMiddleName(string middleName)
    {
        _user.MiddleName = GetValidatedProperty(middleName, userValidator.ValidateMiddleName);
        return this;
    }

    public IUserBuilder AddPhone(string phone)
    {
        _user.Phone = GetValidatedProperty(phone, userValidator.ValidatePhone);
        return this;
    }

    public IUserBuilder AddAddress(string address)
    {
        _user.Address = GetValidatedProperty(address, userValidator.ValidateAddress);
        return this;
    }

    public IUserBuilder AddEmail(string email)
    {
        _user.Email = GetValidatedProperty(email, userValidator.ValidateEmail);
        return this;
    }

    public IUserBuilder AddBirthDate(DateOnly birthDate)
    {
        _user.BirthDate = GetValidatedProperty(birthDate, userValidator.ValidateBirthDate);
        return this;
    }
}