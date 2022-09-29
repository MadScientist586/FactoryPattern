using FactoryPatternExercise;
Console.WriteLine("How many wheels do you wnat your vehicle to have? (2 or 4)");
var Tires = Console.ReadLine();
VehicleFactory setter = new VehicleFactory();
IVehicle vehicle = setter.GetVehicle(Tires);
vehicle.Drive();

