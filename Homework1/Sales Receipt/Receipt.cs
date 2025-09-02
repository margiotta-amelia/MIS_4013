using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Receipt
{
    public class Receipt
    {
        int CustomerID { get; set; }
        int CogQuantity { get; set; }
        int GearQuantity { get; set; }
        double CogPrice { get; set; }
        double GearPrice { get; set; }
        DateTime SaleDate { get; set; }
        double SalesTaxPercent { get; set; }

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
        public double CalculateTotal()
        {
            int totalQty = CogQuantity + GearQuantity;
            if (totalQty<= 10)
            {
                double markup = .15;
            }
            else
            {
               double markup = 12.5;
            }

        }
    }
}
