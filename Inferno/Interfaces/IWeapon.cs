public interface IWeapon
{
    string Name { get; }
    int MinDamage { get; }
    int MaxDamage { get; }
    IGem[] Sockets { get; }
    void InsertSocket(int index, IGem gem);
    void RemoveSocket(int index);
}