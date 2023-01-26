namespace Multi_Currency_Money;

public class Bank
{
    private Dictionary<KeyValuePair<string, string>, int> rates = new()
    {
        {
            new KeyValuePair<string, string>("CHF","USD"), 2
        }
    };
    public Money Reduce(Expression expression, string currency)
    {
        return expression.Reduce(this, currency);
    }

    public int Rate(string from, string to)
    {
        return !rates.TryGetValue(new KeyValuePair<string, string>(from, to), out var rate) ? 1 : rate;
    }

    public void addRate(string from, string to, int rate)
    {
        rates.Add(new KeyValuePair<string, string>(from, to), rate);
    }
}