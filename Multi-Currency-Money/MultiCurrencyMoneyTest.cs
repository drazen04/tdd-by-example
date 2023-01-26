namespace Multi_Currency_Money;

public class MultiCurrencyMoneyTestClass
{
    /**
     * To do to complete:
     * [] $5 + 10 CHF = $10 if CHF:USD is 2:1
     * [] Return Money from $5 + $5
     * [] Reduce Money with conversion 
     * [] Money rounding?
     * [] HashCode()
     * [] Equal null
     * [] Equal object
     */
    
    /**
     * To do completed:
     * [X] $5 * 2 = $10
     * [X] Make “amount” private
     * [X] Dollar side-effects?
     * [X] Equals()
     * [X] 5 CHF * 2 = 10 CHF
     * [X] Dollar/Franc duplication
     * [X] Common equals
     * [X] Common times
     * [X] Francs != Dollars
     * [X] Currency?
     * [X] Delete testFrancMultiplication?
     * [X] Bank.Reduce(Money)
     * [X] $5 + $5 = $10
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

    [Fact]
    public void TestSimpleAddition()
    {
        var five = Money.Dollar(5);
        var sum = five.Plus(Money.Dollar(5));
        var bank = new Bank();
        var reduced = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(10), reduced);
    }

    [Fact]
    public void TestPlusReturnsSum()
    {
        var five = Money.Dollar(5);
        var result = five.Plus(five);
        var sum = (Sum) result;
        Assert.Equal(five, sum.Augent);
        Assert.Equal(five, sum.Addend);
    }

    [Fact]
    public void TestReduceSum()
    {
        var sum = new Sum(Money.Dollar(3), Money.Dollar(5));
        var bank = new Bank();
        var result = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(8), result);
    }
    
    [Fact]
    public void TestReduceMoney()
    {
        var bank = new Bank();
        var result = bank.Reduce(Money.Dollar(1), "USD");
        Assert.Equal(Money.Dollar(1), result);
    }
}