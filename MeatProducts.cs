
class MeatProducts:Products
{
    public string TypeOfMeat;
    public double Ceki;

    public MeatProducts():this("Qoc et","Toyuq Eti")
    {

    }
    public MeatProducts(string Name,string TypeOfMeat):base(Name)
    {
        this.TypeOfMeat = TypeOfMeat;
    }
    public MeatProducts(double Ceki,string Name,string TypeOfMeat):this(Name,TypeOfMeat)
    {
        this.Ceki = Ceki;   
    }

    public void ShowInfoMeat()
    {
        Console.WriteLine(TypeOfMeat);
        Console.WriteLine(Ceki);
    }
}