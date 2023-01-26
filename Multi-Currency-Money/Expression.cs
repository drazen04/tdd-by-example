namespace Multi_Currency_Money;

public interface Expression
{
    Money Reduce(string to);
}