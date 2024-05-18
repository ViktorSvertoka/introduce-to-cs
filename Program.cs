using System;

namespace introduce_to_c {
    class Program {
        static void Main() {

            // byte number = 255; 8bit
            // short number = 32000; 16bit
            // int number = 100; 32bit
            long number = 1000; // 64bit
            number = 10;
            Console.WriteLine("Variable: " + number + ".");

            float num = 4.56f;
            // double num = 44.77d; 2x
            Console.WriteLine("Variable: " + num + ".");

            string word = "Variable: "; // string ""
            char symbol = '.'; // char ''
            Console.WriteLine(word + num + symbol);

            bool isHappy = true;
            // bool notHappy = false;
            Console.WriteLine(isHappy);

            int num_1 = 0, num_2 = 0;

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First: " + num_1 + ". " + "Second: " + num_2 + ".");
        }
    }
}
