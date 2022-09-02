using System.ComponentModel.Design;

namespace BilSalg
{
    public class Gui : Data
    {
        public Gui()
        {
            while(true)
            {
                Menu();
            }
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to MotorSales\n\n[1] For Cars\n[2] For MotorCycles\n[3] Save Data\n[4] Load Data");

            SellCar sellCar = new SellCar();
            SellMC sellMC = new SellMC();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    sellCar.CarMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    sellMC.McMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    SaveData();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    LoadData();
                    break;
                default:
                    break;
            }
        }
    }
}
