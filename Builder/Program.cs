class Program
{
    static void Main(string[] args)
    {
        // Создание напитка через Builder
        var cocktail = new Drink.Builder()
            .SetType("Коктейль")
            .SetAlcohol(true)
            .SetGlassType("Бокал")
            .SetDecoration("Лимон")
            .Build();

        var juice = new Drink.Builder()
            .SetType("Сок")
            .SetAlcohol(false)
            .SetGlassType("Стакан")
            .SetDecoration("Мята")
            .Build();

        // Выводим информацию о напитках
        Console.WriteLine(cocktail);
        Console.WriteLine(juice);
    }
}
