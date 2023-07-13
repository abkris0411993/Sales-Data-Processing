using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Data_Processing
{
    public class MessageProcessing
    {
        public int MessageType { get; set; }
        public SalesData SalesData { get; set; }
        public int Occurrences { get; set; }
        public AdjustmentOperation AdjustmentOperation { get; set; }
    }
}
