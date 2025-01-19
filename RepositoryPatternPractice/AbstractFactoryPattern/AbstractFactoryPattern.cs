using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.AbstractFactoryPattern
{
    public interface IBike
    {
        public void StartBike();

    }

    public interface ICar
    {
        public void StartCar();
    }

    public class TataCar : ICar
    {
        public void StartCar() {
            Console.WriteLine("Tata car started");
        }
    }
    public class TataBike : IBike
    {
        public void StartBike() {
            Console.WriteLine("Tata bike started");
        }
    }

    public class TeslaCar : ICar
    {
        public void StartCar() {
            Console.WriteLine("Tesla car started");
        }
    }
    public class TeslaBike : IBike
    {
        public void StartBike() {
            Console.WriteLine("Tesla bike started");
        }
    }

    public abstract class VehicleCompany
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }
    public class Tesla : VehicleCompany
    {
        public override ICar GetCar()
        {
        return new TeslaCar();
        }

        public override IBike GetBike()
        { 
            return new TeslaBike();
        }
    }

    public class Tata : VehicleCompany
    {
        public override ICar GetCar()
        {
            return new TataCar();
        }

        public override IBike GetBike()
        {
            return new TataBike();
        }
    }
    public class AbstractFactoryPattern
    {
        public static void Test()
        {
            VehicleCompany teslaCompany = new Tesla();
            var teslaCar = teslaCompany.GetCar();
            var teslaBike=teslaCompany.GetBike();
            teslaCar.StartCar();
            teslaBike.StartBike();

            VehicleCompany tataCompany = new Tata();
            var tataCar = tataCompany.GetCar();
            var tataBike=tataCompany.GetBike();
            tataCar.StartCar();
            tataBike.StartBike();

        }
    }
}
