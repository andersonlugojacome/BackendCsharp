// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!, DigitalesWeb");
Sale sale = new Sale();
    sale.total = 15;
Console.WriteLine("Sale cuesta: " + sale.total.ToString());


class Sale
{
    public decimal total { get; set; }

}

