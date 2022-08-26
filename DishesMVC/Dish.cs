namespace DishesMVC
{
    public class Dish
    {
        public Dish(string name, string description, List<string> ingredients, int calories)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Calories = calories;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public int Calories { get; set; }
    }
}
