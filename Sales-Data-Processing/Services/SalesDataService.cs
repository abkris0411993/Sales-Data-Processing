using Sales_Data_Processing.Services.Contracts;
using OfficeOpenXml;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Data_Processing.Services
{
    public class SalesDataService : ISalesDataService
    {

        private List<SalesData> Sales;

        public  SalesDataService()
        {
            Sales = new List<SalesData>();
        }

        public void SaleRecord(SalesData SaleData)
        {
            Sales.Add(SaleData);
        }

        public List<SalesData> GetSales()
        {            
            return Sales;
        }
    }
}
