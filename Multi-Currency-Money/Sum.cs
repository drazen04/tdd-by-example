namespace Multi_Currency_Money;

public class Sum : Expression
{
    public readonly Expression Augent;
    public readonly Expression Addend;

    public Sum(Expression augent, Expression addend)
    {
        Augent = augent;
        Addend = addend;
    }

    public Money Reduce(Bank bank, string to)
    {
        var amount = Augent.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
        return new Money(amount, to);
    }

    public Expression Plus(Expression addend)
    {
        return new Sum(this, addend);
    }

    public Expression Times(int multiplier)
    {
        return new Sum(Augent.Times(multiplier), Addend.Times(multiplier));
    }
}