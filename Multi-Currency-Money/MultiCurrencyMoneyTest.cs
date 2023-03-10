namespace Multi_Currency_Money;

public class MultiCurrencyMoneyTestClass
{
    /**
     * To do running:
     * [] Money rounding?
     * [] HashCode()
     * [] Equal null
     * [] Equal object
     */
    
    /**
     * To do done:
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
     * [X] Reduce Money with conversion
     * [X] $5 + 10 CHF = $10 if CHF:USD is 2:1
     * [X] Sum.plus
     * [X] Expression.Plus
     * [X] Expression.Times
     * [X] Return Money from $5 + $5
     * [X] Reduce(Bank, string) vs Reduce(string)
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
        
    [Fact]
    public void TestReduceMoneyDifferentCurrency()
    {
        var bank = new Bank();
        var result = bank.Reduce(Money.Franc(2), "USD");
        Assert.Equal(Money.Dollar(1), result);
    }
            
    [Fact]
    public void TestArrayEqual()
    {
        Assert.Equal(new List<string>(){"abc"}, new List<string>(){"abc"});
    }
            
    [Fact]
    public void TestIdentityRate()
    {
        Assert.Equal(1, new Bank().Rate("USD", "USD"));
    }

    [Fact]
    public void TestMixedAddition()
    {
        Expression tenFranc = Money.Franc(10);
        Expression fiveBucks = Money.Dollar(5);
        var bank = new Bank();
        var result = bank.Reduce(fiveBucks.Plus(tenFranc), "USD");
        Assert.Equal(Money.Dollar(10), result);
    }

    [Fact]
    public void TestSumPlusMoney()
    {
        Expression tenFranc = Money.Franc(10);
        Expression fiveBucks = Money.Dollar(5);
        var bank = new Bank();
        var sum = new Sum(fiveBucks, tenFranc).Plus(fiveBucks);
        var result = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(15), result);
    }
    
    
    [Fact]
    public void TestSumTimes()
    {
        Expression tenFranc = Money.Franc(10);
        Expression fiveBucks = Money.Dollar(5);
        var bank = new Bank();
        var sum = new Sum(fiveBucks, tenFranc).Times(2);
        var result = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(20), result);
    }

}