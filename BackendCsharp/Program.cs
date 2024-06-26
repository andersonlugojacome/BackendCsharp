// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!, DigitalesWeb");
Sale sale = new Sale(20);
    //sale.Total = 15;
Console.WriteLine("Sale cuesta: " + sale.Total.ToString());
OtherClass otherClass = new OtherClass();
Console.WriteLine("Sale cuesta: " + sale.Sum(1, 2));
otherClass.Print();



class Sale
{
    public decimal Total { get; set; }
    public Sale (decimal totalCons)
    {
        Total = totalCons;
    }
    //Create a function that SUM a +b and result is “Tequiero”
    public string Sum(int a, int b)
    {
        return "Tequiero";
    }
    //Create a function that SUM a +b
    


}

