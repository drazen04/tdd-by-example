namespace Multi_Currency_Money;

public interface Expression
{
    Money Reduce(Bank bank, string to);
    Expression Plus(Expression addend);
}