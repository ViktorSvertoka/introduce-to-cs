using System;

namespace introduce_to_c {
    abstract class Robot : IRun, IJump {

        private string name;

        private int weight;

        private byte[] coordinates;

         public string Name {
            get {
                return name;
            }
            private set { } 
                
        }

         public byte[] Coordinates {
            get {
                return coordinates;
            }
            private set { } 
                
        }

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

        public float speed { get; set; }

        public float y { get; set; }

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

        public abstract void printValues();

        public void RobotRun() {
            Console.WriteLine("Robot is now running");
        }

        public void Jump() {
            Console.WriteLine("Robot is now jumping");
        }
    }
}