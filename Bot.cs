using System;
using introduce_to_c;

namespace project {

    class Bot : Robot {

        public Bot() {}

        public Bot(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates) {

        }

        public override void printValues() {
            Console.WriteLine(this.Name + " weight: " + this.Weight + ". Coordinates: ");
            foreach (byte el in this.Coordinates)
                Console.WriteLine(el);
        }
    }
}

