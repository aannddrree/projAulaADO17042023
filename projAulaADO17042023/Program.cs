// See https://aka.ms/new-console-template for more information
using projAulaADO17042023.Controllers;
using projAulaADO17042023.Model;
using projAulaADO17042023.Models;

Console.WriteLine("Proj MVC - ADO.NET");

Console.WriteLine("Teste Inclusão de dados");

Airplane airplane = new()
{
    Description = "Para testes",
    Id = 1,
    Name = "TOP TURBO",
    NumberOfPassagers = 20,
    Engine = new Engine() { Description = "Motor Legal"}
};

for (int i = 0; i <= 1; i++)
{
    if (new AirplaneController().Insert(airplane))
        Console.WriteLine("Sucesso! registro Inserido!");
    else
        Console.WriteLine("Erro ao inserir registro");
}

new AirplaneController().FindAll().ForEach(Console.WriteLine);

