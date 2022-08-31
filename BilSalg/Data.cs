namespace BilSalg
{
    public class Data
    {
        #region Lists
        public List<SellCar> CarsList { get; set; } = new();
        public List<SellMC> McList { get; set; } = new();
        #endregion
        #region GetSets
        public string? Maker { get; set; }
        public string? Model { get; set; }
        public string? Discription { get; set; }
        public int Year { get; set; }
        public int KM { get; set; }
        public int Price { get; set; }
        #endregion
        #region SaveData
        public static Data data = new Data();

        public static void SaveData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path + @"/CarSaleData.json", json);
            Console.WriteLine("File saved succesfully in " + path);
            Console.Write("Press ANY button to go back to continue....");
            Console.ReadKey();
        }

        public static void LoadData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(path + @"/CarSaleData.json");
            data = System.Text.Json.JsonSerializer.Deserialize<Data>(json);
            Console.WriteLine("File loaded succesfully from " + path);
            Console.Write("Press ANY button to go back to continue....");
            Console.ReadKey();
        }
        #endregion
    }
}
