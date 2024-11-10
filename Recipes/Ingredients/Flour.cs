public abstract class Flour : Ingredient
{
    public override string PreprationStructure => $"Sieve.{base.PreprationStructure}";
}

