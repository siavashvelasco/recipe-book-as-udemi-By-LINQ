public class Chocolate : Ingredient
{
    public override int Id { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string PreprationStructure => $"Melt in a water bath.{base.PreprationStructure}";

}

