using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartManager
{
    internal class Track
    {
        private string _name;
        private int _capacity;
        private List<Driver> drivers;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Capacity
        {
            get { return _capacity; } 
            
        }
        public List<Driver> Drivers
        {
            get { return drivers; }
            
        }
        public Track(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
            drivers = new List<Driver>();
        }
        public bool AddDriver(Driver driver)
        {
            if (drivers.Count < _capacity)
            {
                drivers.Add(driver);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetDescription()
        {
            return $"Track: {_name}, Capacity: {_capacity}, Drivers: {drivers.Count}";
        }

        public string FindByName(string name)
        {
            foreach(Driver d in drivers)
            {
                if(d.Name == name)
                {
                     return d.GetDiscription();
                }
            } 
            return null;
        }

        public bool RemoveDriver(Driver driver)
        {
            if (!drivers.Contains(driver))
            {
                return false;
            }
            else
            {
                drivers.Remove(driver);
                return true;
            }
                
        }
        
        public void LowBalance()
        {
            List <Driver> LowBalanceDrivers = new List<Driver>();
            foreach(Driver d in drivers)
            {
                if(d.Balance < 1000)
                {
                    LowBalanceDrivers.Add(d);
                }
                else
                {
                    
                }
            }
            Console.WriteLine(LowBalanceDrivers);
        }
        public int TotalLaps()
        {
            int totalLaps = 0;
            foreach(Driver d in drivers)
            {
                totalLaps += d.LapsDriven;
            }
            return totalLaps;
        }
        
        public int MostLaps()
        {
            
            int mostLaps = 0
            ;
            foreach(Driver d in drivers)
            {
                if(d.LapsDriven > mostLaps)
                {
                    mostLaps = d.LapsDriven;
                }
            };
            return  mostLaps;
        }

    }
}
