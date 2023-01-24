namespace CarFactory.Models {
    public class Car : Vehicle {
        public string Model { get; private set; }

        public Car(string color, string brand, string model) : base(color, brand) {
            this.Model = model;
        }
    }
}