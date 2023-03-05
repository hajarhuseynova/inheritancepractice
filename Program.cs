
Products Products=new Products();
MilkProducts MilkProducts=new MilkProducts();
MeatProducts MeatProducts=new MeatProducts();
FlourProducts FlourProducts=new FlourProducts();

/* 
Products.ShowInfoProducts();
MilkProducts.ShowInfoMilk();
FlourProducts.ShowInfoFlour();  
MeatProducts.ShowInfoMeat();
*/


Products[] product = { };
Console.WriteLine("0:Left the project");
Console.WriteLine("1:Create the product's information table");
Console.WriteLine("2:Show product's information");
string request=Console.ReadLine();
while (request != "0")
{
    if(request == "1")
    {
       CreateProducts(ref product);
        break;
    }
    else if(request == "2")
    {
        Show(product);
        break;
    }
    else
    {
        Console.WriteLine("you only write 0,1,2");
    }
    Console.WriteLine("0:Left the project");
    Console.WriteLine("1:Create the product's information table");
    Console.WriteLine("2:Show product's information");
    request = Console.ReadLine();
}



void CreateProducts(ref Products[] product)
{
    Array.Resize(ref product,product.Length+1);

    Console.WriteLine("Add Products' names:");
    Products.Name=Console.ReadLine();

    Console.WriteLine("Add products' prices");
    Products.Price=int.Parse(Console.ReadLine());
    product[product.Length-1]= Products;   
}

void Show( Products[] product)
{
    if (product.Length == 0)
    {
        Console.WriteLine("There is not any products");
    }
    else
    {
        foreach ( Products products in product)
        {
            products.ShowInfoProducts();
        }
    }
}
