using Sales_Data_Processing.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sales_Data_Processing.Services
{
    public class LogGeneratorService:ILogGeneratorService
    {
        private readonly ISalesDataService _salesrecorder;
        private int reportCount;
        private int adjustmentreportCount;

        public LogGeneratorService(ISalesDataService salesRecorder)
        {
            _salesrecorder = salesRecorder;
            reportCount = 0;
            adjustmentreportCount = 0;
        }

        public void GetSalesReport()
        {
            Console.WriteLine("\nGenerating sales report...");

            Dictionary<string, decimal> productSales = GetProductSales();

            Console.WriteLine($"---- Sales Report #{++reportCount}----");
            foreach (var productSale in productSales)
            {                
                Console.WriteLine($"{productSale.Key}: {productSale.Value} units, Total Value: {productSale.Value * _salesrecorder.GetSales().First(s => s.ProductType == productSale.Key).Value}");
            }
        }

        public void GetSalesAdjustmentsReport()
        {
            Console.WriteLine("\nGenerating adjustments report...");
            List<SalesData> sales = _salesrecorder.GetSales();                                   
            Console.WriteLine($"---- Adjustments Report #{++adjustmentreportCount}---");
            
            foreach (SalesData sale in sales)
            {
                int pos = sales.IndexOf(sale);
                if (pos < 50)
                {
                    Console.WriteLine($"{sale.ProductType}: {sale.Value}");
                }
                            
            }                      
        }

        private Dictionary<string, decimal> GetProductSales()
        {
            List<SalesData> sales = _salesrecorder.GetSales();
            Dictionary<string, decimal> productSales = new Dictionary<string, decimal>();

            foreach (SalesData sale in sales)
            {
                if (productSales.ContainsKey(sale.ProductType))
                {
                    productSales[sale.ProductType]++;
                }
                else
                {
                    productSales[sale.ProductType] = 1;
                }
            }

            return productSales;
        }
    }
}
