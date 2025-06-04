using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Product product = new Product();
        Customer customer = new Customer();

        order._products.Add("Chair");
        product._productName = order._products[0];
        product._productId = "C023";
        order._packingLabel.Add(product);
        product._price = 500;
        product._productQuantity = 5;

        order.shoppingCost = customer.ResideCheck();

        customer.SetCustomer("Frank","The Street","The city","The State", "Nig.");
        order._shippingLabel.Add(customer);

        Console.WriteLine("---------------------------------ORDER1---------------------------------");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("           PRODUCT");
        Console.WriteLine($"Product Name: {order._packingLabel[0]._productName}");
        Console.WriteLine($"Product Id: {order._packingLabel[0]._productId}");
        Console.WriteLine($"Product Price: ${product._price}");
        Console.WriteLine($"Product Quantity: {product._productQuantity}");
        Console.WriteLine($"Product Total Cost: ${product.SetTotalCost()}");
        Console.WriteLine($"Shopping Cost: ${order.shoppingCost}");
        Console.WriteLine($"Total Cost of order: ${order.TotalCostOrder(product.SetTotalCost(),order.shoppingCost)}");

        Console.WriteLine("           CUSTOMER");
        Console.WriteLine("Name: "+order._shippingLabel[0].GetCustomerName());
        Console.WriteLine("ADDRESS ==> "+order._shippingLabel[0].GetCustomerAddress());
        Console.WriteLine("------------------------------------------------------------------------");

        Order order1 = new Order();
        Product product1 = new Product();
        Customer customer1 = new Customer();

        order1._products.Add("Cloth");
        product1._productName = order1._products[0];
        product1._productId = "CT03";
        order1._packingLabel.Add(product1);
        product1._price = 600;
        product1._productQuantity = 4;

        order1.shoppingCost = customer1.ResideCheck();
        customer1.SetCustomer("Peter","That street","That city","That State", "USA");
        order1._shippingLabel.Add(customer1);

        Console.WriteLine("---------------------------------ORDER2---------------------------------");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("           PRODUCT");
        Console.WriteLine($"Product Name: {order1._packingLabel[0]._productName}");
        Console.WriteLine($"Product Id: {order1._packingLabel[0]._productId}");
        Console.WriteLine($"Product Price: ${product1._price}");
        Console.WriteLine($"Product Quantity: {product1._productQuantity}");
        Console.WriteLine($"Product Total Cost: ${product1.SetTotalCost()}");
        Console.WriteLine($"Shopping Cost: ${order1.shoppingCost}");
        Console.WriteLine($"Total Cost of order: ${order1.TotalCostOrder(product1.SetTotalCost(),order1.shoppingCost)}");

        Console.WriteLine("           CUSTOMER");
        Console.WriteLine("Name: "+order1._shippingLabel[0].GetCustomerName());
        Console.WriteLine("ADDRESS ==> "+order1._shippingLabel[0].GetCustomerAddress());
        Console.WriteLine("------------------------------------------------------------------------");

        Order order2 = new Order();
        Product product2 = new Product();
        Customer customer2 = new Customer();

        order2._products.Add("Table");
        product2._productName = order2._products[0];
        product2._productId = "T024";
        order2._packingLabel.Add(product2);
        product2._price = 400;
        product2._productQuantity = 2;

        order2.shoppingCost = customer2.ResideCheck();
        customer2.SetCustomer("John","John's Street","John's City","John's State", "Nig.");
        order2._shippingLabel.Add(customer2);

        Console.WriteLine("---------------------------------ORDER3---------------------------------");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("           PRODUCT");
        Console.WriteLine($"Product Name: {order2._packingLabel[0]._productName}");
        Console.WriteLine($"Product Id: {order2._packingLabel[0]._productId}");
        Console.WriteLine($"Product Price: ${product2._price}");
        Console.WriteLine($"Product Quantity: {product2._productQuantity}");
        Console.WriteLine($"Product Total Cost: ${product2.SetTotalCost()}");
        Console.WriteLine($"Shopping Cost: ${order2.shoppingCost}");
        Console.WriteLine($"Total Cost of order: ${order2.TotalCostOrder(product2.SetTotalCost(),order2.shoppingCost)}");

        Console.WriteLine("           CUSTOMER");
        Console.WriteLine("Name: "+order2._shippingLabel[0].GetCustomerName());
        Console.WriteLine("ADDRESS ==> "+order2._shippingLabel[0].GetCustomerAddress());
        Console.WriteLine("------------------------------------------------------------------------");
    }
}