namespace CarFactory.Models {
    public class Vehicle {
        public string Color { get; private set; }
        public string Brand { get; private set; }

        public Vehicle (string color, string brand ) {
            this.Color = color;
            this.Brand = brand;
        }
    }
}