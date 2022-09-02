namespace BilSalg
{
    public class Data
    {
        #region Lists
        public List<Cars> CarsList { get; set; } = new();
        public List<MC> McList { get; set; } = new();
        #endregion
        #region SaveData
        public static Data data = new Data();

        public void SaveData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path + @"/CarSaleData.json", json);
            Console.WriteLine("File saved succesfully in " + path);
            Console.Write("Press ANY button to go back to continue....");
            Console.ReadKey();
        }

        public void LoadData()
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
