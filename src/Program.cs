
//<<Магазин музыкальных | На основании информации о сделанных и выполненных заказах, а
//инструментов»         | также наличии инструмента на складе, необходимо сделать заказ на
//<<Инструмент»         | пополнение склада с инструментами.

using src.classes;
using src.enums;

String? msg = "";
SimpleStorage simpleStorage = new SimpleStorage();

while (msg != "exit")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("create Storage");
    Console.ForegroundColor = ConsoleColor.Green;
    msg = Console.ReadLine();
   
    switch(msg)
    {
        case "none":
            break;
        case "AddOrder":
            Console.WriteLine("Add Order");
            Console.WriteLine("================");
            int aboba = 4;
            foreach( var item in Enum.GetNames(typeof(Items))) 
            {
                Console.WriteLine($"item {item} {Enum.GetValues(typeof(Items))}");
            }
            Console.WriteLine("================");
            // simpleStorage.AddOrder();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR");
            Console.ForegroundColor = ConsoleColor.Green;
            break;

    }
    msg = Console.ReadLine();
}




foreach (var order in simpleStorage.simpleOrders)
{
    Console.WriteLine($"status:{order.status} \titem: {order.Item}\t count: {order.Count}");
}
Console.WriteLine("_______________________");
foreach (var item in simpleStorage.items)
{
    Console.WriteLine($"key:{item.Key} \tvalue: {item.Value}");
}

simpleStorage.MakeOrders();
Console.WriteLine("_______________________");
foreach (var order in simpleStorage.simpleOrders)
{
    Console.WriteLine($"status:{order.status} \titem: {order.Item}\t count: {order.Count}");
}
foreach (var item in simpleStorage.items)
{
    Console.WriteLine($"key:{item.Key} \tvalue: {item.Value}");
}

