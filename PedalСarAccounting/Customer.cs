namespace PedalСarAccounting;

public class Customer
{
    public required string Name { get; set; }

    public Car? Car { get; set; }

    public override string ToString()
    {
        return $"Имя: {Name}, Номер: {Car?.Number ?? -1}";
    }
}