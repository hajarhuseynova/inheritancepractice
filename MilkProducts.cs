class MilkProducts:Products
{
    public int ID;
    public double OilPercentage;
    public double Litr;

    public MilkProducts():this(12,"Milla")
    {

    }
    public MilkProducts(int Id, string Name):base(Name)
    {
        this.ID = Id;   
    }
    public MilkProducts(double OilPercentage,double Litr):this(Litr)
    {
        this.OilPercentage = OilPercentage;
    }
    public MilkProducts(double Litr)
    {
        this.Litr = Litr;
    }
    public void ShowInfoMilk()
    {
        Console.WriteLine(ID);
        Console.WriteLine(OilPercentage);
        Console.WriteLine(Litr);
    }
}