using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string numOfWheels)
        {
           
            switch (numOfWheels.ToLower())
            {
                case "4" :
            
                    return new Truck();
                    break;

                case "2" :
                    return new Motorcycle();
                    break;
                default :
                    Console.WriteLine("Not a vaild option, creating truck instead.");
                    return new Truck();
                    break;
                   
            }
        }
            

        
    }
}
