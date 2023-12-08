namespace recipe_template_method_pattern_example;

public class PastaRecipe : Recipe
{
    public override void GatherIngredients()
    {
        Console.WriteLine("Gathered ingredients for pasta.");
    }

    public override void Cook()
    {
        Console.WriteLine("Cooked pasta.");
    }

    public override void Serve()
    {
        Console.WriteLine("Served pasta.");
    }
}