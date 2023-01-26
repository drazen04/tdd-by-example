namespace Multi_Currency_Money;

public class Bank
{
    public Money Reduce(Expression expression, string currency)
    {
        return expression.Reduce(currency);
    }
}