namespace Multi_Currency_Money;

public class MultiCurrencyMoneyTestClass
{
    /**
     * To do:
     * 1. [] $5 + 10 CHF = $10 if CHF:USD is 2:1
     * 2. [X] $5 * 2 = $10
     * 3. [X] Make “amount” private
     * 4. [X] Dollar side-effects?
     * 5. [] Money rounding?
     * 6. [X] Equals()
     * 7. [] HashCode()
     * 8. [] Equal null
     * 9. [] Equal object
     * 10. [X] 5 CHF * 2 = 10 CHF
     * 11. [X] Dollar/Franc duplication
     * 21. [X] Common equals
     * 22. [X] Common times
     * 23. [X] Francs != Dollars
     * 24. [X] Currency?
     * 25. [X] Delete testFrancMultiplication?
     */
    [Fact]
    public void TestMultiplication()
    {
        var five = Money.Dollar(5);
        Assert.Equal(Money.Dollar(10), five.Times(2));
        Assert.Equal(Money.Dollar(15), five.Times(3));
    }

    [Fact]
    public void TestEquality()
    {
        Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
        Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
        Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
    }

    [Fact]
    public void TestCurrency()
    {
        Assert.Equal("USD", Money.Dollar(1).Currency());
        Assert.Equal("CHF", Money.Franc(1).Currency());
    }
    
    [Fact]
    public void TestDifferentClassEquality()
    {
        Assert.True(new Money(10, "USD").Equals(new Money(10, "USD")));
    }
}