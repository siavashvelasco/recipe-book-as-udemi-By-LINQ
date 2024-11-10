public class Butter : Ingredient
{
    public override int Id { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string PreprationStructure => $"Melt on low heat.{base.PreprationStructure}";

}

