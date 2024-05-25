using System;

namespace introduce_to_c {
    class Robot {

        private string name;

        private int weight;

        private byte[] coordinates;

        protected string surname;

        public int Weight {
            get {
                return this.weight;
            }
            set {
                if(value < 1)
                    this.weight = 1;
                else
                    this.weight = value;
            }
        }

        public Robot(string name, int weight, byte[] coordinates) {
            Console.WriteLine("Object has been created");
            this.setValues(name, weight, coordinates);
        }

        public Robot() { }

        public void setValues(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void printValues() {
            Console.WriteLine(this.name + " weight: " + this.weight + ". Coordinates: ");
            foreach (byte el in this.coordinates)
                Console.WriteLine(el);
        }
    }
}