using Sales_Data_Processing.Helper;
using Sales_Data_Processing.Services.Contracts;
using System.Collections.Generic;
using System.Text.Json;


namespace Sales_Data_Processing.Services
{
    public class MessageProcessingService : IMessageProcessingService
    {
        private readonly ISalesDataService _salesrecorder;
        private readonly ILogGeneratorService _logGenerator;
        private int messageCount;

        public MessageProcessingService(ISalesDataService salesRecorder, ILogGeneratorService reportGenerator)
        {
            _salesrecorder = salesRecorder;
            _logGenerator = reportGenerator;
            messageCount = 0;
        }

        public void ProcessIncomingMessage(MessageProcessing message)
        {
            // Record and display each sale(s)
            RecordSalesFromIncomingMessage(message);
            Console.WriteLine(JsonSerializer.Serialize(message));

            // Generate sales report after every 10th message
            messageCount++;
            if (messageCount % 10 == 0)
            {
                _logGenerator.GetSalesReport();
            }

            // Pause the application and generate adjustment reports after 50 messages
            if (messageCount % 50 == 0)
            {
                Console.WriteLine("\nPausing the application...");
                _logGenerator.GetSalesAdjustmentsReport();
                Environment.Exit(0);
            }
        }

        //Process Incoming Messages based on Message Type
        private void RecordSalesFromIncomingMessage(MessageProcessing message)
        {
            switch (message.MessageType)
            {
                case 1:
                    _salesrecorder.AddSaleRecord(message.SalesData);
                    break;
                case 2:
                    for (int i = 0; i < message.Occurrences; i++)
                    {                        
                        SalesData sale = new SalesData
                        {
                            ProductType = message.SalesData.ProductType,
                            Value = message.SalesData.Value,
                            Occurrences = 1  
                        };
                        _salesrecorder.AddSaleRecord(sale);

                    }
                    break;
                case 3:
                    ApplyAdjustmentToRecordedSales(message.AdjustmentOperation);
                    break;
                default:
                    Console.WriteLine($"Invalid message type: {message.MessageType}");
                    break;
            }
        }

        private void ApplyAdjustmentToRecordedSales(AdjustmentOperation adjustment)
        {
            List<SalesData> sales = _salesrecorder.GetSales();
            List<SalesData> recordsales = sales.Where(sale => sale.ProductType == adjustment.ProductType).ToList();
                       
                foreach (SalesData sale in recordsales)
                {
                                                                                      
                        switch (adjustment.Operation)
                        {
                            case Operations.Add:                                
                                sale.Value+= adjustment.Value;
                                break;
                            case Operations.Subtract:
                                sale.Value -= adjustment.Value;
                                break;
                            case Operations.Multiply:
                                sale.Value *= adjustment.Value;
                                break;
                        }                        
                    }
                }
            }
        }
    
