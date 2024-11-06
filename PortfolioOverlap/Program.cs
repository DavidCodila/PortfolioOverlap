// See https://aka.ms/new-console-template for more information
using PortfolioOverlap.Classes;

Console.WriteLine("Hello, World!");
Database database = new Database();
database.LoadFunds(@"Data\stock_data.json");
var newvar = database.Funds;
