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
                SalesData = new SalesData { ProductType = "Apple", Value = 1.20m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 5.10m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,       
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Multiply }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Subtract }
            },
             new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.20m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.10m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Multiply }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.20m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.10m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.20m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Multiply }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Subtract }
            },
             new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.00m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Multiply }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.00m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.10m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Subtract }
            },
             new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.00m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Banana", Value = 4.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 2
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Orange", Value = 2.00m, Operation = Operations.Multiply }
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Cheese", Value = 2.00m, Operation = Operations.Subtract }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Apple", Value = 1.00m }
            },
            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.00m }
            },
            new MessageProcessing
            {
                MessageType = 2,
                SalesData = new SalesData { ProductType = "Orange", Value = 3.00m },
                Occurrences = 3
            },
            new MessageProcessing
            {
                MessageType = 3,
                AdjustmentOperation = new AdjustmentOperation { ProductType = "Apple", Value = 1.00m, Operation=Operations.Add }
            },

            new MessageProcessing
            {
                MessageType = 1,
                SalesData = new SalesData { ProductType = "Cheese", Value = 2.00m }
            },


        };
        
        return (messages);
        }   
}