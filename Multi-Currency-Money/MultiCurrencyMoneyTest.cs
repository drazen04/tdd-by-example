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
     */
    [Fact]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        Assert.Equal(new Dollar(10), five.Times(2));
        Assert.Equal(new Dollar(15), five.Times(3));
    }
    
    [Fact]
    public void TestEquality()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
    }
}