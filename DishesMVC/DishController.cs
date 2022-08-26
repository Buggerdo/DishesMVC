namespace DishesMVC
{
    public class DishController
    {
        public List<Dish> DishDB { get; set; } = new List<Dish>()
        {
            new Dish("Pizza", "Pizza is a savory dish of Italian origin, consisting of a usually round, flattened base of leavened wheat-based dough topped with tomatoes, cheese, and various other ingredients baked at a high temperature, traditionally in a wood-fired oven. The name pizza derives from the first mention of the dish in a 14th-century Italian text, the recipe for which is still commonly found today.", new List<string>() { "Tomato", "Cheese", "Pizza base" }, 400),
            new Dish("Spaghetti", "Spaghetti is a type of pasta dish from Italy, consisting of a rolled sheet of pasta, placed in a large, hollowed out, cylindrical pan, and filled with a mixture of various ingredients.", new List<string>() { "Tomato", "Cheese", "Spaghetti base" }, 350),
            new Dish("Ravioli", "Ravioli are a type of pasta dish from the Italian cuisine. Ravioli are made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Ravioli base" }, 400),
            new Dish("Lasagne", "Lasagne is a type of pasta dish from the Italian cuisine. Lasagne is made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Lasagne base" }, 400),
            new Dish("Risotto", "Risotto is a type of pasta dish from the Italian cuisine. Risotto is made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Risotto base" }, 400),
            new Dish("Rigatoni", "Rigatoni is a type of pasta dish from the Italian cuisine. Rigatoni is made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Rigatoni base" }, 400),
            new Dish("Penne", "Penne is a type of pasta dish from the Italian cuisine. Penne is made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Penne base" }, 400),
            new Dish("Fettuccine", "Fettuccine is a type of pasta dish from the Italian cuisine. Fettuccine is made with a layer of pasta, then a layer of cheese, then a layer of meat, then a layer of vegetables.", new List<string>() { "Tomato", "Cheese", "Fettuccine base" }, 400),
        };

        public void DishList()
        {
            var view = new DishListView(DishDB);
            view.Display();
        }

        public void DishDetails()
        {
            int slection = GetSelection();
            var view = new DishDetailsView(DishDB[slection - 1]);
            view.Display();
        }

        public int GetSelection()
        {
            Console.WriteLine($"Which dish would you like to view? Enter 1-{DishDB.Count}");
            return int.Parse(Console.ReadLine());
        }

        public void Welcome()
        {
            DishList();
            DishDetails();
        }
    }
}
