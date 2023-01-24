using CarFactory.Models;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Console.WriteLine("How many vehicles would you like to add?");
            Console.Write("Enter number: ");
            int numOfVehicles = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOfVehicles; i++)
            {
                bool invalidChoice = true;
                int choice = 0;

                Console.WriteLine($"======= Adding Vehicle #{i+1} =======");
                Console.WriteLine("What type of Vehicle?");
                Console.WriteLine("1 - Car");
                Console.WriteLine("2 - Truck");
                Console.WriteLine("==============");

                while (invalidChoice) {
                    Console.Write("Enter Number: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        invalidChoice = false;
                    }
                    else {
                        Console.WriteLine("ERROR: Invalid choice. Input number again.");
                    }
                }

                Console.Write("Color: ");
                string color = Console.ReadLine();

                Console.Write("Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                if (choice == 1)
                {
                    Car car = new Car(color, brand, model);
                    vehicles.Add(car);
                }
                else if (choice == 2)
                {
                    Console.Write("Capacity: ");
                    float capacity = float.Parse(Console.ReadLine());

                    Truck truck = new Truck(color, brand, model, capacity);
                    vehicles.Add(truck);
                }
            }

            Console.WriteLine("=========== DONE ADDING VEHICLES ===========");
            Console.WriteLine("== Vehicles List ==");

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Brand: {vehicle.Brand}");

                if (vehicle.GetType() == typeof(Car))
                {
                    Car temp = (Car)vehicle;
                    Console.WriteLine($"Model: {temp.Model}");
                }
                else if (vehicle.GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)vehicle;
                    Console.WriteLine($"Model: {temp.Model}");
                    Console.WriteLine($"Capacity: {temp.Capacity}");
                }
                Console.WriteLine("==============");
            }
        }
    }
}
