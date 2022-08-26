namespace DishesMVC
{
    public class DishController
    {
        public List<Dish> DishDB { get; set; }
        
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
            GetSelection();
            DishDetails();
        }
    }
}
