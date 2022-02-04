using System;
using Xunit;

namespace CSharp10Classlib.ExtendedPropertyPatterns;

public class ExtendedPropertyPatternsTests
{
    [Fact]
    public void Should_Return_CryptoOrderProcessor_When_Currency_Of_The_Order_Was_BTC()
    {
        var order = new Order(new(new("BTC", 15.57M), DateTime.Now),
            new("Customer", "A"));

        string? GetCurrencyType(Order order) => order is {Payment.Price.Currency: "BTC"} ?
            "CryptoOrderProcessor" : null;
        
        Assert.Equal("CryptoOrderProcessor", GetCurrencyType(order));
    }
}