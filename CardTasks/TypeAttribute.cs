using System;

public class TypeAttribute : Attribute
{
    public string Type { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    public TypeAttribute(string category, string description)
    {
        this.Type = "Enumeration";
        this.Category = category;
        this.Description = description;
    }

    public override string ToString()
    {
        return $"Type = {this.Type}, Description = {this.Description}";
    }
}