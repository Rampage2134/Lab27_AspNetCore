var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-234! Автор: Медведев, Соколов");

app.MapGet("/about", () => "Это мой первый ASP.NET Core сервер");

app.MapGet("/time", () => $"Время на сервере: {DateTime.Now}");

app.MapGet("/hello/{time}", (string name) => $"Привет, {name}!");

app.MapGet("/sum/{a}/{b}", (int a, int b) => $"Cумма: {a + b}");

app.Run();
