class Products
{
    public string Name;
    public double Price;

    public Products():this("Flour",15.2)
    {

    }
    public Products(string Name)
    {
        this.Name = Name;
    }
    public Products(string Name,double Price):this(Name)
    {
        this.Price=Price;   
    }

    public void ShowInfoProducts()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Price);
    }
}