using System;

class Program
{
    static void Main(string[] args)
    {
        Address inUS = new Address("123 street Rd","Roy","Weber","UT");
        Customer dan = new Customer("Dan the Man",inUS);

        Address outOfUS = new Address();
        Customer bill = new Customer("Bill From Nowhere",outOfUS);

        Product salami = new Product("Salami",0,10.99F,1);
        Product umbrella = new Product("Umbrella",1,35.99F,2);
        Product napkins = new Product("Pack of Napkins",3,4.95F,1);
        Product bread = new Product("Bread",2,9.99F,3);
        Product nails = new Product("Box of Nails",4,18.95F,1);


        Console.WriteLine("Dan the Man's order:");
        List<Product> order1 = [salami, umbrella, napkins];
        Order danOrder = new Order(order1, dan);
        string danPackingLabel = danOrder.GetPackingLabel();
        string danShippingLabel = danOrder.GetShippingLabel();
        float danTotal = danOrder.GetTotalPrice();
        Console.WriteLine($"Packing Label: \n{danPackingLabel}Total: ${danTotal} \n \nShipping Label: \n {danShippingLabel}");

        Console.WriteLine("");
        Console.WriteLine("Bill From Nowhere's order:");
        List<Product> order2 = [bread,nails];
        Order billOrder = new Order(order2, bill);
        string billPackingLabel = billOrder.GetPackingLabel();
        string billShippingLabel = billOrder.GetShippingLabel();
        float billTotal = billOrder.GetTotalPrice();
        Console.WriteLine($"Packing Label: \n{billPackingLabel}Total: ${billTotal} \n \nShipping Label: \n {billShippingLabel}");
    }
}