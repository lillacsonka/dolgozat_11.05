using System.Diagnostics;

namespace KartManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Driver> drivers = new List<Driver>();
            ConsoleView view = new ConsoleView();
            Driver driver1 = new Driver("John Doe", 5, true);
            Driver driver2 = new Driver("Jane Smith", 10, false);
            Driver driver3 = new Driver("Aryton Senna", 27, false);
            Driver driver4 = new Driver("Lance Stroll", 0, true);


            drivers.Add(driver1);
            drivers.Add(driver2);
            drivers.Add(driver3);
            drivers.Add(driver4);

            driver1.GetDiscription();
            driver2.GetDiscription();
            driver3.GetDiscription();
            driver4.GetDiscription();
            view.ShowDrivers(drivers);
            Console.WriteLine(" ");

            Console.WriteLine("number of drivers:  " +drivers.Count);
            Console.WriteLine(" ");


            Track track = new Track("Radiator Springs", 3);
            track.AddDriver(driver1);
            track.AddDriver(driver2);
            track.AddDriver(driver3);
            track.AddDriver(driver4);
            Console.WriteLine(" ");

            Console.WriteLine(track.GetDescription());
            Console.WriteLine(" ");

            track.FindByName("Aryton Senna");
            track.FindByName("Lewis Hamilltion");
            track.RemoveDriver(driver2);
            track.FindByName(driver2.Name);
            track.AddDriver(driver4);

            Console.WriteLine("");
            //lowbalance
          track.LowBalance();
        }
        
    }
}
