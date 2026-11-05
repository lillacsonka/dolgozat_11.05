using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartManager
{
    internal class ConsoleView
    {
        public void ShowDriver(Driver driver)
        {
            Console.WriteLine(driver.GetDiscription());
        }
        public void ShowDrivers(List<Driver> drivers)
        {
            foreach (var driver in drivers)
            {
                ShowDriver(driver);
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
