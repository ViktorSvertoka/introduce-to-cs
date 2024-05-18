using System;

namespace introduce_to_c {
    class Program {
        static void Main() {

            // double user_input = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number with a dot: ");

            float user_input = float.Parse(Console.ReadLine());

            float result;

            result = user_input + 10f;

            // result = result * 2f;

            result *= 2f;

            result--;

            // result = user_input - 10f;
            // result = user_input * 10f;
            // result = user_input / 10f;
            // result = user_input % 10f;

            Console.WriteLine("Variable: " + result);
        }
    }
}
