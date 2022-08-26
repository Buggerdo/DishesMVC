namespace DishesMVC
{
    public class DishDetailsView
    {
        public DishDetailsView(Dish dish)
        {
            Dish = dish;
        }
        public Dish Dish { get; set; }

        public void Display()
        {
            string ingredients = string.Join(", ", Dish.Ingredients);
            //string ingredients = string.Empty;
            //Dish.Ingredients.ForEach(i => ingredients += i + ", ");

            Console.WriteLine($"Name: {Dish.Name}" +
                $"\nDescription: {Dish.Description}" +
                $"\nCalories: {Dish.Calories}" +
                $"\nIngredients: {ingredients}");
        }
    }
}
