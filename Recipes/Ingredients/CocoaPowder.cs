﻿public class CocoaPowder : Ingredient
{
    public override int Id { get; } = 8;
    public override string Name { get; } = "Cocoa powder";
    public override string PreprationStructure => $"{base.PreprationStructure}";

}

