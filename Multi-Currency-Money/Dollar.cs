namespace Multi_Currency_Money;

// Value Object
public class Dollar: Money
{
    public Dollar(int amount, String currency)
    {
        Amount = amount;
        this.currency = currency;
    }

    internal override Money Times(int multiplier)
    {
        return Dollar(Amount * multiplier);
    }

}