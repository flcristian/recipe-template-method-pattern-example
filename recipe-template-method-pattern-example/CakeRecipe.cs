namespace recipe_template_method_pattern_example;

public class CakeRecipe : Recipe
{
    public override void GatherIngredients()
    {
        Console.WriteLine("Gathered ingredients for cake.");
    }

    public override void Cook()
    {
        Console.WriteLine("Cooked cake.");
    }

    public override void Serve()
    {
        Console.WriteLine("Served cake.");
    }
}