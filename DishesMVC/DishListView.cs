namespace DishesMVC
{
    public class DishListView
    {
        public DishListView(List<Dish> dishes)
        {
            Dishes = dishes;
        }

        public List<Dish> Dishes { get; set; }

        public void Display()
        {
            Console.WriteLine("Here is out list of dishes:");
            foreach(var dish in Dishes)
            {
                Console.WriteLine($"{dish.Name} - {dish.Description} - {dish.Calories}");
            }
        }
    }
}
