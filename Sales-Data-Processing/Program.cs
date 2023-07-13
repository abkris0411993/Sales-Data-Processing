using Sales_Data_Processing;
using Sales_Data_Processing.Helper;
using Sales_Data_Processing.Services;
using Sales_Data_Processing.Services.Contracts;


public class Program
{
    public static void Main()
    {
        ISalesDataService salesDataService = new SalesDataService();
        ILogGeneratorService logGeneratorService = new LogGeneratorService(salesDataService);
        IMessageProcessingService messageProcessingService = new MessageProcessingService(salesDataService, logGeneratorService);

        // Simulate receiving messages
        List<MessageProcessing> messages = GenerateSampleMessageData();
        foreach (MessageProcessing message in messages)
        {
            messageProcessingService.ProcessIncomingMessage(message);
        }
    }

    // Generate sample messages for testing
    private static List<MessageProcessing> GenerateSampleMessageData()
    {
        List<MessageProcessing> messages = new List<MessageProcessing>
        {
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 0.20m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 0.30m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Vegetables", Value = 0.05m, Operation=Operations.Subtract }
            }
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m },
            //    Occurrences = 2
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.10m, Operation = Operations.Multiply }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            // new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m },
            //    Occurrences = 3
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.05m, Operation=Operations.Add }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m },
            //    Occurrences = 2
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.10m, Operation = Operations.Multiply }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            // new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m },
            //    Occurrences = 3
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.05m, Operation=Operations.Add }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m },
            //    Occurrences = 2
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.10m, Operation = Operations.Multiply }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            // new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m },
            //    Occurrences = 3
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.05m, Operation=Operations.Add }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m },
            //    Occurrences = 2
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.10m, Operation = Operations.Multiply }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            // new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m },
            //    Occurrences = 3
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.05m, Operation=Operations.Add }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 2,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m },
            //    Occurrences = 2
            //},
            //new MessageProcessing
            //{
            //    MessageType = 3,
            //    AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 0.10m, Operation = Operations.Multiply }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            //new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
            //},
            // new MessageProcessing
            //{
            //    MessageType = 1,
            //    SalesData = new SalesData { ProductType = "Apple", Value = 0.10m }
            //},
            //new MessageProcessing
            //{
            //    SalesData = new SalesData { ProductType = "Orange", Value = 0.20m }
           
            //    SalesData = new SalesData { ProductType = "Banana", Value = 0.30m }
            //},



        };
        
        return (messages);
        }   
}