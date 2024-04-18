using _03_AbstractClass;

Console.WriteLine("Car driver uses his horn!");
Car car = new Car();
SignalVehicleError(car);
//car.Horn();
//car.Error();

await Task.Delay(1000);

Console.WriteLine("Truck driver uses his horn!");
Truck truck = new Truck();
SignalVehicleError(truck);
//truck.Horn();
//truck.Error();

await Task.Delay(1000);

//void SignalVehicleError(Truck truck)
//{
//    truck.Error();
//}

//void SignalVehicleError(Car car)
//{
//    car.Error();
//}

//a fenti függvények helyett:

void SignalVehicleError(Vehicle vehicle)
{
    vehicle.Error();
}
//design pattern