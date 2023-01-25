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
     * 21. [] Common equals
     */
    [Fact]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        Assert.Equal(new Dollar(10), five.Times(2));
        Assert.Equal(new Dollar(15), five.Times(3));
    }
    
    [Fact]
    public void TestFrancMultiplication()
    {
        var five = new Franc(5);
        Assert.Equal(new Franc(10), five.Times(2));
        Assert.Equal(new Franc(15), five.Times(3));
    }
    
    [Fact]
    public void TestEquality()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
    }
}