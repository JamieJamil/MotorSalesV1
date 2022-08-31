namespace BilSalg
{
    public class SellCar : Data
    {
        public static void CarMenu()
        {
            Console.Clear();
            Console.WriteLine("\nCar Menu\n[1] To Put Car For Sale\n[2] To Look up Listed Cars");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    SellMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchCar();
                    break;
                default:
                    break;
            }
        }
        public static void SellMenu()
        {
            SellCar car = new SellCar();
            Console.Clear();
            car.Maker = GetString("CARSALE\n\nMaker: ");
            car.Model = GetString("Model: ");
            car.Year = GetInt("Model Year: ");
            car.KM = GetInt("KM Driven: ");
            car.Price = GetInt("\nPrice example(150000)(Currency: DKK)\nPrice: ");
            car.Discription = GetString("Discription: ");

            //TODO Diesel/Benz - KM - GEAR


            ShowSale(car);
            Console.WriteLine("Confirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.CarsList.Add(car);
        }
        public static void ShowSale(SellCar s)
        {
            Console.WriteLine($"\nMaker: {s.Maker} \nModel: {s.Model} \nModel Year: {s.Year} \nKM Driven: {s.KM}kr \nPrice: {s.Price}kr \nDiscription: {s.Discription}");

        }
        public static string GetString(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "");
            return input;
        }
        public static int GetInt(string request)
        {
            int i;
            do
            {
                Console.Write(request);
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
        public static void SearchCar()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (SellCar car in data.CarsList)
            {
                if (search != null)
                {
                    if (car.Maker.ToLower().Contains(search) || car.Model.ToLower().Contains(search))
                    {
                        ShowSale(car);
                    }
                }
            }
        }
    }
}
