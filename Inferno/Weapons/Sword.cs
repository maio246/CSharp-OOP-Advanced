using System;

public class Sword : IWeapon
{
    public string Name { get; private set; }

    public int minDamage = 4;
    public int maxDamage = 6;
    public object WeaponQuality;

    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Vitality { get; private set; }

    public Sword(string weaponQuality, string name)
    {
        this.Name = name;
        this.WeaponQuality = Enum.Parse(typeof(WeaponQuality), weaponQuality);
        this.Sockets = Sockets;
    }

    public IGem[] Sockets
    {
        get { return this.Sockets; }
        set { this.Sockets = new IGem[3]; }
    }

    public int MinDamage
    {
        get { return this.minDamage; }
        set { this.minDamage = this.minDamage * (int) WeaponQuality; }
    }

    public int MaxDamage
    {
        get { return this.maxDamage; }
        set { this.maxDamage = this.maxDamage * (int) WeaponQuality; }
    }

    public void InsertSocket(int index, IGem gem)
    {
        if (index <= Sockets.Length)
        {
            this.Sockets[index] = gem;
            this.Strength += gem.Strength;
            this.Agility += gem.Agility;
            this.Vitality += gem.Vitality;

            this.minDamage += this.Strength * 2 + this.Agility;
            this.maxDamage += this.Strength * 3 + this.Agility * 4;
        }
    }

    public void RemoveSocket(int index)
    {
        if (index <= this.Sockets.Length && Sockets[index] != null)
        {

            var gem = this.Sockets[index];

            this.minDamage -= this.Strength * 2 + this.Agility;
            this.maxDamage -= this.Strength * 3 + this.Agility * 4;

            this.Strength -= gem.Strength;
            this.Agility -= gem.Agility;
            this.Vitality -= gem.Vitality;


            this.Sockets[index] = null;
        }
    }

    public override string ToString()
    {
        return $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
    }
}