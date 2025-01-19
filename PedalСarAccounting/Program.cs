namespace PedalСarAccounting;

internal class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new() { Name = "Timofey Karuba" },
            new() { Name = "Timofey Karuba" },
            new() { Name = "Timofey Karuba" },
            new() { Name = "Emre" },
            new() { Name = "Tengir" },
            new() { Name = "Miha" },
            new() { Name = "Min'" },

        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 6; i++)
        {
            factory.AddCar();
        }

        Console.WriteLine("Cars and people");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();

        Console.WriteLine("People with cars");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
    }
}