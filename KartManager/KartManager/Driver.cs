using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KartManager
{
    internal class Driver
    {
        private string _name;
        private int _kartNumber;
        private bool _isMember;
        private int _count;
        private int _balance;
        private int _lapsDriven;

        public int Count { get { return _count; } }
            
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int KartNumber
        {
            get 
            { 
                if (_kartNumber > 0 || _kartNumber < 100) 
                    {  
                        return _kartNumber;
                    }
                else
                {
                    return 0;
                }
            }
            set { _kartNumber = value; }
        }
        public bool IsMember
        {
            get { return _isMember; }
            set { _isMember = value; }
        }


        public int Balance
        {
            get { return _balance; }
            
        }
        public int LapsDriven
        {
            get { return _lapsDriven; }
            
        }

        public Driver(string name, int kartNumber, bool isMember)
        {
            _name = name;
            _kartNumber = kartNumber;
            _isMember = isMember;
            _count++;
        }

        public bool TopUp (int amount)
        {
             if(amount == 2000)
            {
                _balance += amount;
                return true;
            }
             if(amount == 5000)
            {
                _balance += amount;
                return true;
            }
             if(amount == 10000)
            {
                _balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Drive (int laps)
        {
            int cost = laps * 500;
            int membercost = laps * 400;
            if(_isMember == true)
            {
                if(_balance < membercost)
                {
                    return false;
                }
                else
                {
                    _balance -= membercost;
                    _lapsDriven += laps;
                    return true;
                }
            }
            else
            {
                if(_balance < cost)
                {
                    return false;
                }
                else
                {
                    _balance -= cost;
                    _lapsDriven += laps;
                    return true;
                }
            }
        }

        public string GetDiscription()
        {
            return $"Driver: {Name}, (gocart number:{KartNumber}, {IsMember}): balance: {Balance}ft, number of laps: {LapsDriven}";
        }

    }
}
