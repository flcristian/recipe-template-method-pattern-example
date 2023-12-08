using recipe_template_method_pattern_example;

internal class Program
{
    public static void Main(string[] args)
    {
        PastaRecipe pasta = new PastaRecipe();
        pasta.PrepareRecipe();

        CakeRecipe cake = new CakeRecipe();
        cake.PrepareRecipe();
    }
}