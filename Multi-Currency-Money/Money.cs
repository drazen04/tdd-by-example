namespace Multi_Currency_Money;

public class Money : Expression
{
    protected internal int Amount;
    protected internal string currency;

    public Money(int amount, string currency)
    {
        Amount = amount;
        this.currency = currency;
    }
    
    public override bool Equals(object? obj)
    {
        Money money = (Money) obj;
        return Amount == money.Amount && Currency() == money.Currency();
    }

    public static Money Dollar(int amount)
    {
        return new Money(amount, "USD");
    }
    
    public static Money Franc(int amount)
    {
        return new Money(amount, "CHF");
    }

    public Money Times(int multiplier)
    {
        return new Money(Amount * multiplier, currency);
    }

    protected internal string Currency()
    {
        return currency;
    }

    public Expression Plus(Money moneyToSum)
    {
        return new Sum(this, moneyToSum);
    }

    public Money Reduce(Bank bank, string to)
    {
        var rate = bank.Rate(currency, to);
        return new Money(Amount / rate, to);
    }
}