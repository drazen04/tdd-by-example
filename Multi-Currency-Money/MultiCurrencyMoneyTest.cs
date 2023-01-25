namespace Multi_Currency_Money;

public class MultiCurrencyMoneyTestClass
{
    /**
     * To do:
     * 1. [] $5 + 10 CHF = $10 if CHF:USD is 2:1
     * 2. [X] $5 * 2 = $10
     * 3. [] Make “amount” private
     * 4. [X] Dollar side-effects?
     * 5. [] Money rounding?
     * 6. [X] Equals()
     * 7. [] HashCode()
     * 8. [] Equal null
     * 9. [] Equal object
     * 10. [X] 5 CHF * 2 = 10 CHF
     * 11. [] Dollar/Franc duplication
     * 21. [X] Common equals
     * 22. [] Common times
     * 23. [X] Francs != Dollars
     * 24. [] Currency?
     * 25. [] Delete testFrancMultiplication?
     */
    [Fact]
    public void TestMultiplication()
    {
        var five = Money.Dollar(5);
        Assert.Equal(Money.Dollar(10), five.Times(2));
        Assert.Equal(Money.Dollar(15), five.Times(3));
    }
    
    [Fact]
    public void TestFrancMultiplication()
    {
        var five = Money.Franc(5);
        Assert.Equal(Money.Franc(10), five.Times(2));
        Assert.Equal(Money.Franc(15), five.Times(3));
    }
    
    [Fact]
    public void TestEquality()
    {
        Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
        Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
        Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
        Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
        Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
    }

    [Fact]
    public void TestCurrency()
    {
        Assert.Equal("USD", Money.Dollar(1).Currency());
        Assert.Equal("CHF", Money.Franc(1).Currency());
    }
}