using System.Diagnostics.CodeAnalysis;
using System.Net.Quic;
using System.Xml.Serialization;
using Sales_Receipt;

namespace Sales_Receipt
{
    class Program
    {
        static void Main()
        {

            List<Receipt> list = new List<Receipt>();
            string moreOrders;

            do
            {
                Console.WriteLine("COGS are $79.99, how many do you want?");
                int cogQty = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Gears are $250,00, how many do you want?");
                int gearQty = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your Customer ID?");
                int customerID = Convert.ToInt32(Console.ReadLine());

                Receipt receipt = new Receipt(customerID, cogQty, gearQty);
                receipt.PrintReceipt();
                list.Add(receipt);


                Console.WriteLine("Do you want to enter another order? yes or no?");
                moreOrders = Console.ReadLine().ToLower();

            } while (moreOrders == "yes");

            string option;

            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Print all receipts based on a Customer ID.");
                Console.WriteLine("2. Print all receipts for the day.");
                Console.WriteLine("3. Print the receipt for the sale that had the highest total");
                Console.WriteLine("4. None of the above");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter a Customer ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Receipt r in list)
                    {
                        if (r.CustomerID == id)
                        {
                            r.PrintReceipt();
                        }
                    }
                }
                else if (option == "2")
                {
                    foreach (Receipt r in list)
                    {
                        r.PrintReceipt();
                    }
                }
                else if (option == "3")
                {
                    Receipt maxRecipt = null;
                    double maxTotal = 0;

                    foreach (Receipt r in list)
                    {
                        double total = r.CalculateTotal();
                        if (total > maxTotal)
                        {
                            maxTotal = total;
                            maxRecipt = r;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Goodbye!"); ;
                }
                
            } while (option != "4");
            
        }
    }
}

