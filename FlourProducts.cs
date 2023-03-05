class FlourProducts : Products
{
    public string TypeOfProduct;
    public int count;
    public FlourProducts() : this("Bulka")
    {

    }
    public FlourProducts(string TypeOfProducts)
    {
        this.TypeOfProduct = TypeOfProducts;
    }
    public FlourProducts(int count, string Name) : base(Name)
    {
        this.count = count;
    }

    public void ShowInfoFlour()
    {
        Console.WriteLine(TypeOfProduct);
        Console.WriteLine(count);
    }
}
