namespace Multi_Currency_Money;

public class Dollar
{
    public int Amount;

    public Dollar(int amount)
    {
        this.Amount = amount;
    }
    public Dollar Times(int multiplier)
    {
        return new Dollar(Amount * multiplier);
    }
}