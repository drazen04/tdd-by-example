namespace Multi_Currency_Money;

public class MultiCurrencyMoneyTestClass
{
    /**
     * To do:
     * 1. [] $5 + 10 CHF = $10 if CHF:USD is 2:1
     * 2. [X] $5 * 2 = $10
     * 3. [] Make “amount” private
     * 4. [X] Dollar side-effects?
     * 5. Money rounding?
     * 6. Equals()
     * 7. HashCode()
     */
    [Fact]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        var product = five.Times(2);
        Assert.Equal(10, product.Amount);
        product = five.Times(3);
        Assert.Equal(15, product.Amount);
    }
}