namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cocktail = new Drink.Builder()
                .SetType("Cocktail")
                .SetAlcohol(true)
                .SetGlassType("Goblet")
                .SetDecoration("Lemon")
                .Build();

            var juice = new Drink.Builder()
                .SetType("Juice")
                .SetAlcohol(false)
                .SetGlassType("Glass")
                .SetDecoration("Mint")
                .Build();

            var bloodyMary = new Drink.Builder()
                .SetType("Cocktail")
                .SetAlcohol(true)
                .SetGlassType("Glass")
                .SetDecoration("Tomato")
                .Build();

            Console.WriteLine(cocktail);
            Console.WriteLine(juice);
            Console.WriteLine(bloodyMary);
        }
    }
}