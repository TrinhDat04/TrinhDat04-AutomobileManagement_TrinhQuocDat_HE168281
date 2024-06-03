using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomobileLibrary.BussinessObject; 
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //Initialize car list
        private static List<Car> Carlist = new List<Car>()
        {
            new Car{ CarID = 1, CarName = "CRV", Manufacturer="Honda",
            Price = 30000, ReleaseYear = 2021},
            new Car{ CarID = 2,CarName = "Ford Focus", Manufacturer="Ford",
            Price = 15000, ReleaseYear = 2020}
        };
        //--------------------------------------------
        //Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new Object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //--------------------------------------------

        public List<Car> GetCarList => Carlist;
        //--------------------------------------------
        public Car GetCarByID(int carID)
        {
            //using LinQ to object
            Car car = Carlist.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }
        //---------------------------------------------
        //Add new car
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if(pro == null) 
            {
                Carlist.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }
        //Update a car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = Carlist.IndexOf(c);
                Carlist[index] = car;
            }
            else { throw new Exception("Car doest not already exists.");
            }
        }
        //Remove a carr
        public void Remove(int CarID)
        {
            Car p = GetCarByID(CarID); 
            if(p != null)
            {
                Carlist.Remove(p);
            }
            else
            {
                throw new Exception("Car doest not already exists.");
            }
        }
        //--------------
    }//End Class

}
