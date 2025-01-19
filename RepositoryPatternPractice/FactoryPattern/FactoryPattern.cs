using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.FactoryPattern
{
    public interface IVehicle
    {
        public void Start();
    }
    public class TwoWheelerVehicle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Two wheeler started");
        }
    }

    public class FourWheelerVehicle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Four wheeler started");
        }
    }

    public class CarFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "twoWheeler":
                    return new TwoWheelerVehicle();
                case "fourWheeler":
                    return new FourWheelerVehicle();
            }
            return null;
        }
    }

    public class FactoryPattern
    {
        public static void Test()
        {
            CarFactory carFactory = new CarFactory();
            IVehicle twoWheeler = carFactory.CreateVehicle("twoWheeler");
            IVehicle fourWheeler = carFactory.CreateVehicle("fourWheeler");

            twoWheeler.Start();
            fourWheeler.Start();

        }
    }
}

