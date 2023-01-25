namespace Multi_Currency_Money;

public class Money
{
    protected internal int Amount;
    
    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;
        return Amount == money.Amount;
    }
}