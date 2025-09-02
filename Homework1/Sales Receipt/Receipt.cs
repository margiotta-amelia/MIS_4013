using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Receipt
{
    public class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        private double CogPrice { get; set; }
        private double GearPrice { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent { get; set; }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
            CogPrice = 79.99;
            GearPrice = 250.00;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
        }
        public double CalculateNetAmount()
        {
            int totalQty = CogQuantity + GearQuantity;
            double markup;

            if (totalQty > 10 || CogQuantity > 10 || GearQuantity >= 18)
            {
                markup = .125;

            }
            else
            {
               markup = .15;
            }
            
            double cogTotal = CogQuantity * CogPrice * (1 + markup);
            double gearTotal = GearQuantity * GearPrice * (1 + markup);

            return cogTotal + gearTotal;


        }
        public double CalculateTaxAmount()
        {
            return CalculateNetAmount() * SalesTaxPercent;
        }

        public double CalculateTotal()
        {
            return CalculateNetAmount() + CalculateTaxAmount();
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Receipt");
            Console.WriteLine($"CustomerID: {CustomerID}");
            Console.WriteLine($"Sale Date: {SaleDate}");
            Console.WriteLine($"COGS: {CogQuantity} Price: {CogPrice}");
            Console.WriteLine($"Gears: {GearQuantity} Price: {GearPrice}");
            Console.WriteLine($"Total Before Tax: {CalculateNetAmount():C}");
            Console.WriteLine($"Sales Tax: {CalculateTaxAmount():C}");
            Console.WriteLine($"Total Amount Due: {CalculateTotal():C}");
        }

    }
}
