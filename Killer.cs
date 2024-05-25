using System;

namespace introduce_to_c {

    class Killer : Robot {

        public int Health { get; set; }

        public Killer() {}

        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates) {
            this.Health = health;

        }

        public override void printValues() {
            base.printValues();

            Console.WriteLine("Health: " + this.Health);
        }



        public void Lazer() { 
            Console.WriteLine("Lazer shooting");
            this.surname = "Doe";

        }
    }
}