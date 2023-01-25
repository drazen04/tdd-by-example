namespace Multi_Currency_Money;

// Value Object
public class Dollar
{
    private readonly int amount;

    public Dollar(int amount)
    {
        this.amount = amount;
    }
    public Dollar Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        var dollar = (Dollar) obj;
        return amount == dollar.amount;
    }
}