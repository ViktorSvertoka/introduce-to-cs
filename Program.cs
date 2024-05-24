using System;

namespace introduce_to_c {
    class Program {
        static void Main() {

            try {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            } catch {
                Console.WriteLine("You entered the wrong format!");
            }
            
        }
    }
}

