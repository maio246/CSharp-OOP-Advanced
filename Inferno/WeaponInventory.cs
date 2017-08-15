using System;
using System.Collections.Generic;

public class WeaponInventory
{
    public Dictionary<string, IWeapon> Inventory;

    public WeaponInventory()
    {
        Inventory = new Dictionary<string, IWeapon>();
    }
    public void Create(string weaponType, string weaponName)
    {
        IWeapon weapon;

        var weaponTokens = weaponType.Split();

        var quality = weaponTokens[0];
        var type = weaponTokens[1];

        switch (type)
        {
            case "Axe":
                weapon = new Axe(quality, weaponName);
                if (!Inventory.ContainsKey(weaponName))
                {
                    Inventory.Add(weaponName, weapon);
                }
                break;
            case "Sword":
                weapon = new Sword(quality, weaponName);
                if (!Inventory.ContainsKey(weaponName))
                {
                    Inventory.Add(weaponName, weapon);
                }
                break;
            case "Knife":
                weapon = new Knife(quality, weaponName);
                if (!Inventory.ContainsKey(weaponName))
                {
                    Inventory.Add(weaponName, weapon);
                }
                break;
        }
    }

    public void Add(string weaponName, int socketIndex, string gem)
    {
        var currWeapon = Inventory[weaponName];
        IGem currGem;

        var gemInfo = gem.Split();
        var gemQuality = gemInfo[0];
        var gemType = gemInfo[1];

        switch (gemType)
        {
            case "Ruby":
                currGem = new Ruby(gemQuality);
                currWeapon.InsertSocket(socketIndex, currGem);
                break;
            case "Emerald":
                currGem = new Emerald(gemQuality);
                currWeapon.InsertSocket(socketIndex, currGem);
                break;
            case "Amethyst":
                currGem = new Amethyst(gemQuality);
                currWeapon.InsertSocket(socketIndex, currGem);
                break;

        }

    }

    public void Remove(string weaponName, int socketIndex)
    {
        var currWeapon = Inventory[weaponName];
        currWeapon.RemoveSocket(socketIndex);
    }

    public void Print(string weaponName)
    {
        Console.WriteLine(Inventory[weaponName]);
    }
}