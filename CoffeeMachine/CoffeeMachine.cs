using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coins;
    private IList<CoffeeType> coffeesSold;

    public IEnumerable<CoffeeType> CoffeesSold { get { return this.coffeesSold; } }

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }
    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);

        if (this.coins >= (int)coffeePrice)
        {
            this.coffeesSold.Add(coffeeType);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        int currCoin = (int) Enum.Parse(typeof(Coin), coin);
        coins += currCoin;
    }

}
