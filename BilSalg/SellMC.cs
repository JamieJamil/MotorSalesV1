namespace BilSalg
{
    public class SellMC : Data
    {
        public static void McMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMotorcycle Menu\n[1] To Put MC For Sale\n[2] To Look up Listed Motorcycles");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    SellMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchMC();
                    break;
                default:
                    break;
            }
        }
        public static void SellMenu()
        {
            MC mc = new MC();
            Console.Clear();
            mc.Maker = GetString("MOTORCYCLE SALE\n\nMaker: ");
            mc.Model = GetString("Model: ");
            mc.Year = GetInt("Model Year: ");
            mc.KM = GetInt("KM Driven: ");
            mc.Price = GetInt("\nPrice example(150000)(Currency: DKK)\nPrice: ");
            mc.Discription = GetString("Discription: ");


            ConfirmSale(mc);
            Console.WriteLine("\nConfirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.McList.Add(mc);

        }
        public static void ConfirmSale(MC m)
        {
            Console.Clear();
            Console.WriteLine($"\nMaker: {m.Maker} \nModel: {m.Model} \nModel Year: {m.Year} \nKM Driven: {m.KM} \nPrice: {m.Price}kr \nDiscription: {m.Discription}");
        }
        public static void ShowSale(MC m)
        {
            Console.Clear();
            Console.WriteLine("Search results\n");
            Console.WriteLine($"\nMaker: {m.Maker} \nModel: {m.Model} \nModel Year: {m.Year} \nKM Driven: {m.KM} \nPrice: {m.Price}kr \nDiscription: {m.Discription}");
            Console.ReadKey();
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
        public static void SearchMC()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine().ToLower();
            foreach (MC mc in data.McList)
            {
                if (search != null)
                {
                    if (mc.Maker.ToLower().Contains(search) || mc.Model.ToLower().Contains(search))
                    {
                        ShowSale(mc);
                    }
                }
            }
        }
    }
}
