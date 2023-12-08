namespace recipe_template_method_pattern_example;

public abstract class Recipe
{
    public void PrepareRecipe()
    {
        GatherIngredients();
        Cook();
        Serve();
    }

    public abstract void GatherIngredients();
    public abstract void Cook();
    public abstract void Serve();
}