using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice.FactoryMethodPattern
{
    public interface IVehicle
    {
        void Start();
    }

    public class TwoWheeler : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Two wheeler started");
        }
    }

    public class FourWheeler : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("For wheeler started");
        }
    }

    public abstract class VehicleCreator
    {
        public abstract IVehicle FactoryMethod();

        public void StartOperation()
        {
            // Call the factory method to get a product
            IVehicle vehicle = FactoryMethod();
            // Use the product
            
        }
    }

    public class TwoWheelerCreator : VehicleCreator
    {
        public override IVehicle FactoryMethod()
        {
            return new TwoWheeler();
        }
    }

    public class FourWheelerCreator : VehicleCreator
    {
        public override IVehicle FactoryMethod()
        {
            return new FourWheeler();
        }
    }


    public class FactoryMethodPattern
    {
        public static void Test()
        {
            VehicleCreator twoWheelerCreator = new TwoWheelerCreator();
            var twoWheeler=twoWheelerCreator.FactoryMethod();
            

            VehicleCreator fourWheelerCreator = new FourWheelerCreator();
            var fourWheeler = fourWheelerCreator.FactoryMethod();

            twoWheeler.Start();
            fourWheeler.Start();
        }
    }

}
