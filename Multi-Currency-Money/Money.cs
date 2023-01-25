namespace Multi_Currency_Money;

public abstract class Money
{
    protected int Amount;
    protected internal string currency;

    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;
        return Amount == money.Amount && GetType() == money.GetType();
    }

    public static Money Dollar(int amount)
    {
        return new Dollar(amount, "USD");
    }
    
    public static Money Franc(int amount)
    {
        return new Franc(amount, "CHF");
    }

    internal abstract Money Times(int multiplier);

    protected internal string Currency()
    {
        return currency;
    }
}