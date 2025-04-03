namespace Builder
{
    public class Drink
    {
        public string Type { get; private set; } = string.Empty;
        public bool ContainsAlcohol { get; private set; }
        public string GlassType { get; private set; } = string.Empty;
        public string Decoration { get; private set; } = string.Empty;

        private Drink() { }

        public class Builder
        {
            private readonly Drink _drink = new Drink();

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
                return _drink;
            }
        }

        public override string ToString()
        {
            return string.Format("| {0,-15} | {1,-12} | {2,-22} | {3,-13} |",
                "Drink: " + Type,
                "Alcohol: " + (ContainsAlcohol ? "Yes" : "No"),
                "Type of dishes: " + GlassType,
                "Decor: " + Decoration)
                + "\n---------------------------------------------------------------------------";
        }
    }
}