namespace Multi_Currency_Money;

public class Sum : Expression
{
    public readonly Money Augent;
    public readonly Money Addend;

    public Sum(Money augent, Money addend)
    {
        Augent = augent;
        Addend = addend;
    }

    public Money Reduce(Bank bank, string to)
    {
        var amount = Augent.Amount + Addend.Amount;
        return new Money(amount, to);
    }
}