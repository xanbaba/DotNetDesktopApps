// See https://aka.ms/new-console-template for more information

using BuilderHw;

var userValidator = new UserValidator();
var userBuilder = new UserBuilder(userValidator);
userBuilder.AddFirstName("Xanbaba")
    .AddLastName("Fatullayev")
    .AddEmail("Fatul_gb62@itstep.edu.az")
    .AddBirthDate(new DateOnly(2000, 6, 28))
    .AddAddress("ItStepAcademy").AddPhone("+9941110022");

var user = userBuilder.Build();
Console.WriteLine(user.FirstName);
Console.WriteLine(user.LastName);
Console.WriteLine(user.Email);
Console.WriteLine(user.Phone);
Console.WriteLine(user.BirthDate);

userBuilder.AddFirstName("Anton")
    .AddLastName("Vasiliyev")
    .AddEmail("Vasil_an06@itstep.edu.az")
    .AddBirthDate(new DateOnly(2006, 3, 30))
    .AddAddress("ItStepAcademy-Junior").AddPhone("+9940001122");

var user2 = userBuilder.Build();
Console.WriteLine(user2.FirstName);
Console.WriteLine(user2.LastName);
Console.WriteLine(user2.Email);
Console.WriteLine(user2.Phone);
Console.WriteLine(user2.BirthDate);