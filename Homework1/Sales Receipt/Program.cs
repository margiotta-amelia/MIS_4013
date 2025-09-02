using System.Diagnostics.CodeAnalysis;
using System.Net.Quic;

int CogQuantity = 0;
int GearQuantity = 0;
int CustomerID = 0;

Console.WriteLine("COGS are $79.99, how many do you want?");
string answer = Console.ReadLine();
CogQuantity = Convert.ToInt32(answer);

Console.WriteLine("Gears are $250,00, how many do you want?");
string answer1 = Console.ReadLine();
GearQuantity = Convert.ToInt32(answer1);

Console.WriteLine("What is your Customer ID?");
string custID = Console.ReadLine();
CustomerID = Convert.ToInt32(custID);

double CogPrice = 79.99;
double GearPrice = 250.00;
double SalesTaxPercent = .089;
DateTime SaleDate = DateTime.Now;

int totalQty = CogQuantity + GearQuantity;

if (totalQty <= 10)
{
    double markup = .15;
}
else
{
    double markup = 12.5;
}