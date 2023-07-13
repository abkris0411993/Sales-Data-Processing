using Sales_Data_Processing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Data_Processing
{
    public class AdjustmentOperation
    {
        public string ProductType { get; set; }
        public decimal Value { get; set; }
        public Operations Operation { get; set; }

    }

}
