using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace introduce_to_c {
    class Program {
        static void Main() {

            Robot bot = new Robot("Bot", 800, new byte[] {0, 0, 0});
            bot.printValues();


            Killer killer = new Killer("Killer", 1000, new byte[] {0, 0, 10}, 100, Type.Hero);
            killer.printValues();
            killer.Health = 100;
            killer.Lazer();


            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Alex", 400, new byte[] {0, 0, 10}, 100));
            robots.Add(new Killer("Bob", 600, new byte[] {0, 10, 10}, 100));
            robots.Add(new Killer("John", 800, new byte[] {10, 0, 10}, 100));
            robots.Add(new Killer("Josh", 500, new byte[] {0, 20, 30}, 100));

            Robot newRobot = null;
            foreach(Killer obj in robots) {
                if(obj.Name == "John") {
                    newRobot = obj as Robot;
                }
                Console.WriteLine(obj is Robot);
            }


            Multiply(1.5f, 3.6f);
            Multiply(1, 3);
            Multiply(5);
        }

        public static void Multiply(int a, int b) {
            int res = a * b;
            Console.WriteLine("Result: " + res);
        }

         public static void Multiply(float a, float b) {
            float res = a * b;
            Console.WriteLine("Result: " + res);
        }

         public static void Multiply(int a) {
            int res = a * 2;
            Console.WriteLine("Result: " + res);
        }
    }
}

