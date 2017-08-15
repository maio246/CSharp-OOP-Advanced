public class Robot : IHabitant
{
    public string Id { get; private set; }
    private string model;

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
}
