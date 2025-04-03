public class Drink
{
    public string Type { get; private set; } = string.Empty;
    public bool ContainsAlcohol { get; private set; }
    public string GlassType { get; private set; } = string.Empty;
    public string Decoration { get; private set; } = string.Empty;

    // Приватный конструктор, объект можно создать только через Builder
    private Drink() { }

    // Вложенный Builder
    public class Builder
    {
        private Drink _drink = new Drink();

        public Builder SetType(string type)
        {
            _drink.Type = type;
            return this;
        }

        public Builder SetAlcohol(bool containsAlcohol)
        {
            _drink.ContainsAlcohol = containsAlcohol;
            return this;
        }

        public Builder SetGlassType(string glassType)
        {
            _drink.GlassType = glassType;
            return this;
        }

        public Builder SetDecoration(string decoration)
        {
            _drink.Decoration = decoration;
            return this;
        }

        public Drink Build()
        {
            return _drink; // Возвращаем готовый напиток
        }
    }

    public override string ToString()
    {
        return $"Напиток: {Type}, Алкоголь: {(ContainsAlcohol ? "Есть" : "Нет")}, Стекло: {GlassType}, Украшение: {Decoration}";
    }
}
