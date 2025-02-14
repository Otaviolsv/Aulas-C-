// See https://aka.ms/new-console-template for more information

using System.Globalization;

DateTime datahoje = DateTime.Now; //considera a hora
//DateTime datahoje = DateTime.Now.Date; //considera somente a data



DateTime dataaniversario = new DateTime(2002, 08, 09);

int anoatual = datahoje.Year;

int anoaniversario = dataaniversario.Year;

int mesaniversario = dataaniversario.Month;

int idade = (anoatual - anoaniversario);

if(dataaniversario.Month <= datahoje.Month && dataaniversario.Day <= datahoje.Day )
{
    Console.WriteLine("Idade: " + idade);
}
else
{
    idade--;
    Console.WriteLine("Idade: " + idade);
}

Console.WriteLine("Data: " + datahoje);

CultureInfo cultura = new CultureInfo("pt-Br");

Console.WriteLine(datahoje.ToString("D" , cultura));

Console.WriteLine("Data de aniversario: " + dataaniversario.ToString("D", cultura));








