﻿namespace Multi_Currency_Money;

// Value Object
public class Dollar: Money
{
    public Dollar(int amount)
    {
        this.Amount = amount;
    }
    public Dollar Times(int multiplier)
    {
        return new Dollar(Amount * multiplier);
    }
}