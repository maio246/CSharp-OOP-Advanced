public class Mission : IMissions
{
    public string CodeName { get; private set; }
    public string State { get; private set;}

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public void CompleteMission()
    {
        this.State = "finished";
    }

    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}