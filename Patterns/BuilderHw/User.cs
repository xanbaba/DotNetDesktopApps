namespace BuilderHw;

//У класса User есть следущие характеристики: firstName*, lastName*, middleName, birthdate, phone, address, email.
// Данные со звёдочкой помечены как обязательные, а остальные - nullable. 

public class User
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public DateOnly? BirthDate { get; set; }
}