

namespace introduce_to_c {
    class Program {
        static void Main() {
            // Print("Hello");
            // string words = "Hello world";
            // Print(words);

            // int res1 = Summa(5, 9);
            // int a = 4, b = 7;
            // int res2 = Summa(a, b);
            // Print(res1.ToString());
            // Print(res2.ToString());

            byte[] nums = { 5, 7, 8, 3, 5 };
            byte res1 = Summa(nums);
            Console.WriteLine("Result: " + res1);

        }

        public static void Print(string word) {
            Console.WriteLine(word);
        }

         public static int Summa(int x, int y) {
            return x + y;
            
        }

        public static byte Summa(byte[] digits) {
            byte summ = 0;
            foreach (byte el in digits)
                summ += el;

            return summ;
        }
    }
}

