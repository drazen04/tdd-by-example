namespace Multi_Currency_Money;

// Value Object
public class Franc : Money
{
    public Franc(int amount, string currency): base(amount, currency) {}
    // public static Money Franc(int amount)
    // {
    //     return new Money(amount, "CHF");
    // }
    
}