namespace Multi_Currency_Money;

public class Franc : Money
{
    public Franc(int amount)
    {
        Amount = amount;
    }
    
    public Franc Times(int multiplier)
    {
        return new Franc(Amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        Money money = (Franc) obj;
        return Amount == money.Amount;
    }
}