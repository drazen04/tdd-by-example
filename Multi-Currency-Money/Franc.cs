namespace Multi_Currency_Money;

// Value Object
public class Franc : Money
{
    public Franc(int amount, String currency)
    {
        Amount = amount;
        this.currency = currency;
    }

    internal override Money Times(int multiplier)
    {
        return Franc(Amount * multiplier);
    }
}