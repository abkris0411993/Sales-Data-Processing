﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Data_Processing.Services.Contracts
{
    public interface ILogGeneratorService
    {
        void GetSalesReport();
        void GetSalesAdjustmentsReport();

    }
}
