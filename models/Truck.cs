namespace CarFactory.Models
{
    public class Truck : Vehicle {
        public string Model { get; private set; }
        public float Capacity { get; private set; }

        public Truck(string color, string brand, string model, float capacity) 
            : base(color, brand) 
        {
            this.Model = model;
            this.Capacity = capacity;
        }
    }
}